# Shaka.Godot.OnReady

Source generator for Godot 4 .NET version.
Source generator which adds input actions as constant strings.

## Add it to your godot project.
```xml
<PackageReference Include="Shaka.Godot.Actions" Version="x.x.x">
   <PrivateAssets>all</PrivateAssets>
   <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
</PackageReference>
```

It will automatically read your `project.godot` and add the actions to a globally available static class.

## Example

### Custom action
Let's say i have added a custom action `quit`
A const string will be available at `RootNamespace.Actions.Quit`

```cs
public override void _Input(InputEvent @event)
{
  if (@event.IsActionPressed(Actions.Quit))
  {
    Quit();
  }
}
```

### Default Godot action
Godot adds multiple standard input actions which are included under `RootNamespace.Actions.Builtin`.
```cs
public override void _Input(InputEvent @event)
{
  if (@event.IsActionPressed(Actions.Builtin.UIAccept))
  {
    Quit();
  }
}
```
