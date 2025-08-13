# Shaka.Godot.OnReady

Source generator for Godot 4 .NET version which adds input actions as constant strings to your game project.

It will allow you to get lsp suggestions when using input actions in code.

The project will not compile if an input action name is changed without changing it in code.

The generated code looks like this:
```cs
namespace MyGame;

internal static partial class Actions
{
    internal const string Quit = "quit";
}
```

# Installation
## Add it to your godot project.
Since it's a source generator we need to add `PrivateAssets` and the `IncludeAssets` properties.
```xml
<PackageReference Include="Shaka.Godot.Actions" Version="x.x.x">
   <PrivateAssets>all</PrivateAssets>
   <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
</PackageReference>
```
Refer to the [nuget package page](https://www.nuget.org/packages/Shaka.Godot.Actions/) for available versions.

It will automatically read your `project.godot` and add the actions to a globally available static class.

# Usage

## Custom action
I added a custom action `quit` to my godot project.
A const string will be available at `MyGame.Actions.Quit`
(`MyGame` being your root namespace or custom defined namespace)
```cs
public override void _Input(InputEvent @event)
{
  if (@event.IsActionPressed(MyGame.Actions.Quit))
  {
    Quit();
  }
}
```

## Default Godot action
Godot adds multiple standard input actions which are included under `MyGame.Actions.Builtin`.
(`MyGame` being your root namespace or custom defined namespace)
```cs
public override void _Input(InputEvent @event)
{
  if (@event.IsActionPressed(MyGame.Actions.Builtin.UIAccept))
  {
    AcceptGift();
  }
}
```

# Configuration
## Actions namespace
### Default
By default, the actions class is created in the root namespace defined in your `csproj` with
```xml
 <PropertyGroup>
  <RootNamespace>MyGame</RootNamespace>
 </PropertyGroup>
```
So the actions class is accesible via `MyGame.Actions`.

If there is no root namespace, the namespace will be the name of the assembly(typically your project name.

### Custom
If you dont want the Actions class to be in the the default namespace, you can override it by adding the `SGActionsNamespace` property in a property group like this:
```xml
 <PropertyGroup>
  <SGActionsNamespace>MyActions</SGActionsNamespace>
 </PropertyGroup>
```
So the actions class is accesible via `MyActions.Actions`.
