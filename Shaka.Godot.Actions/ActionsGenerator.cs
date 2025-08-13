using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Nova.SourceGenerator;

[Generator]
public sealed class ActionsGenerator : IIncrementalGenerator
{
	private static readonly TextInfo TextInfo = CultureInfo.InvariantCulture.TextInfo;

	public void Initialize(IncrementalGeneratorInitializationContext context)
	{
		var actionLines = context.AdditionalTextsProvider
				.Where(file => file.Path.EndsWith("project.godot"))
				.Select((file, cancellationToken) =>
				{
					var text = file.GetText(cancellationToken);
					return text!.ToString();
				});

		context.RegisterSourceOutput(actionLines, (spc, lines) =>
		{
			if (lines is not null)
			{
				var sb = new StringBuilder();
				foreach (var action in ReadActionNames(lines))
				{

					var actionParts = TextInfo.ToTitleCase(action).Split(' ', '_', '-');
					var pascalCaseAction = string.Concat(actionParts);

					sb.AppendLine(@$"internal const string {pascalCaseAction} = ""{action}"";");
				}

				string source =
						$$"""
						namespace Nova;

						internal static class Actions
						{
							{{sb}}

							{{DefaultActions}}
						}
						""";
				spc.AddSource("Actions.g.cs", SourceText.From(source, Encoding.UTF8));
			}
		});
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

	private const string DefaultActions =
		"""
		internal static class Default
		{
		  internal const string UiAccept = "ui_accept";  
		  internal const string UiSelect = "ui_select";  
		  internal const string UiCancel = "ui_cancel";  
		  internal const string UiFocusNext = "ui_focus_next";  
		  internal const string UiFocusPrev = "ui_focus_prev";  
		  internal const string UiLeft = "ui_left";  
		  internal const string UiRight = "ui_right";  
		  internal const string UiUp = "ui_up";  
		  internal const string UiDown = "ui_down";  
		  internal const string UiPageUp = "ui_page_up";  
		  internal const string UiPageDown = "ui_page_down";  
		  internal const string UiHome = "ui_home";  
		  internal const string UiEnd = "ui_end";  
		  internal const string UiTextNewline = "ui_text_newline";  
		  internal const string UiTextDelete = "ui_text_delete";  
		  internal const string UiTextBackspace = "ui_text_backspace";  
		  internal const string UiTextCaretLeft = "ui_text_caret_left";  
		  internal const string UiTextCaretRight = "ui_text_caret_right";  
		  internal const string UiTextCaretUp = "ui_text_caret_up";  
		  internal const string UiTextCaretDown = "ui_text_caret_down";  
		  internal const string UiTextSelectAll = "ui_text_select_all";  
		  internal const string UiTextCut = "ui_text_cut";  
		  internal const string UiTextCopy = "ui_text_copy";  
		  internal const string UiTextPaste = "ui_text_paste";  
		  internal const string UiTextUndo = "ui_text_undo";  
		  internal const string UiTextRedo = "ui_text_redo";  
		  internal const string UiTextScrollUp = "ui_text_scroll_up";  
		  internal const string UiTextScrollDown = "ui_text_scroll_down";  
		  internal const string UiTextSelectWordUnderCaret = "ui_text_select_word_under_caret";  
		  internal const string UiTextAddSelectionForNextOccurrence = "ui_text_add_selection_for_next_occurrence";  
		  internal const string UiTextRemoveSelectionForNextOccurrence = "ui_text_remove_selection_for_next_occurrence";  
		  internal const string UiScrollUp = "ui_scroll_up";  
		  internal const string UiScrollDown = "ui_scroll_down";  
		  internal const string UiScrollLeft = "ui_scroll_left";  
		  internal const string UiScrollRight = "ui_scroll_right";  
		  internal const string UiMenu = "ui_menu";  
		  internal const string UiDropDown = "ui_drop_down";  
		  internal const string UiPopupMenu = "ui_popup_menu";  
		  internal const string UiTextSubmit = "ui_text_submit";  
		}
		""";
}
