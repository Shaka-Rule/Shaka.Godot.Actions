using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;

namespace Shaka.Godot.Actions;

[Generator]
public sealed class ActionsGenerator : IIncrementalGenerator
{
	private static readonly TextInfo TextInfo = CultureInfo.InvariantCulture.TextInfo;

	private static readonly DiagnosticDescriptor SGA001ProjectGodotNotFound =
		new(
				id: "SGA001",
				title: "project.godot not found",
				messageFormat: "The godot project file 'project.godot' was not found. Add it to the project with <ItemGroup><AdditionalFiles Include=\"./project.godot\" /></ItemGroup>.",
				category: "SourceGenerator",
				DiagnosticSeverity.Warning,
				isEnabledByDefault: true);

	public void Initialize(IncrementalGeneratorInitializationContext context)
	{
		var rootNameSpaceProvider = context.AnalyzerConfigOptionsProvider
				.Select((p, _) =>
						{
							if (p.GlobalOptions.TryGetValue("build_property.SGActionsNamespace", out string? ns)) return ns;
							if (p.GlobalOptions.TryGetValue("build_property.RootNamespace", out ns)) return ns;
							if (p.GlobalOptions.TryGetValue("build_property.AssemblyName", out ns)) return ns;

							return ns;
						});

		var actionLinesProvider = context.AdditionalTextsProvider
				.Where(file => file.Path.EndsWith("project.godot"))
				.Select((file, cancellationToken) =>
				{
					var text = file.GetText(cancellationToken);
					return text!.ToString();
				}).Collect();

		var combinedProviders = actionLinesProvider.Combine(rootNameSpaceProvider);

		context.RegisterSourceOutput(combinedProviders, (ctx, provValues) =>
		{
			var (lines, @namespace) = provValues;

			var sb = new StringBuilder();
			if (lines.Length > 0)
			{
				foreach (var action in ReadActionNames(lines[0]))
				{
					var actionParts = TextInfo.ToTitleCase(action).Split(' ', '_', '-');
					var pascalCaseAction = string.Concat(actionParts);

					sb.AppendLine(@$"internal const string {pascalCaseAction} = ""{action}"";");
				}
			}
			else
			{
				ctx.ReportDiagnostic(Diagnostic.Create(SGA001ProjectGodotNotFound, Location.None));
			}

			string builtinsSource = GenerateBuiltinActionsClass(@namespace);
			var syntaxTree = CSharpSyntaxTree.ParseText(builtinsSource);
			var root = syntaxTree.GetRoot();
			builtinsSource = root.NormalizeWhitespace().ToFullString();
			ctx.AddSource("Actions.Builtins.g.cs", SourceText.From(builtinsSource, Encoding.UTF8));

			string source = GenerateActionsClass(@namespace, sb.ToString());
			syntaxTree = CSharpSyntaxTree.ParseText(source);
			root = syntaxTree.GetRoot();
			source = root.NormalizeWhitespace().ToFullString();
			ctx.AddSource("Actions.g.cs", SourceText.From(source, Encoding.UTF8));
		});
	}

	private static string GenerateBuiltinActionsClass(string? @namespace)
	{
		string builtinsSource = ReadEmbeddedResource($"{nameof(ActionsGenerator)}.StaticFiles.Actions.Builtin.cs");
		return GenerateActionsClass(@namespace, builtinsSource);
	}

	private static string GenerateActionsClass(string? @namespace, string actions)
	{
		var namespaceStatement = @namespace is not null ? $"namespace {@namespace};" : string.Empty;
		string source =
				$$"""
				{{namespaceStatement}}

				internal static partial class Actions
				{
					{{actions}}
				}
				""";

		return source;
	}

	private static List<string> ReadActionNames(string lines)
	{

		var actionNames = new List<string>();
		bool inInputSection = false;

		foreach (var line in lines.Split('\n'))
		{
			var lineTxt = line.Trim();

			if (lineTxt.StartsWith("["))
			{
				inInputSection = lineTxt == "[input]";
				continue;
			}

			if (inInputSection && lineTxt.Contains("="))
			{
				var splitIndex = lineTxt.IndexOf('=');
				var action = lineTxt[..splitIndex].Trim();

				actionNames.Add(action);
			}
		}

		return actionNames;
	}

	private static string ReadEmbeddedResource(string resourceName)
	{
		var assembly = typeof(ActionsGenerator).Assembly;
		using var stream = assembly.GetManifestResourceStream(resourceName)
			?? throw new InvalidOperationException($"Resource '{resourceName}' not found.");
		using var reader = new StreamReader(stream);
		return reader.ReadToEnd();
	}
}
