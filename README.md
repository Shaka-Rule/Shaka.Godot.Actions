# 🎯 Shaka.Godot.Actions

A **C# Source Generator** for **Godot 4 .NET** that automatically turns your input actions into **compile-time safe static StringName**.  

✨ **Benefits**:
- 🖱 **IDE Autocompletion** for input actions.
- 🔒 **Compile-time safety**: Your project won’t build if you rename actions in Godot but forget to update them in code.
- ⚡ **No runtime reflection** — all generated at build time.

Example of generated code:
```csharp
namespace MyGame;

internal static partial class Actions
{
    internal static Godot.StringName Quit = "quit";
}
```

---

## 🚀 Features

- 🛡 **Compile-time safety** for all input actions.
- 📜 **Clean, readable generated code**.
- 🔍 **LSP/IDE autocompletion** in C# editors.
- 🧩 **Supports both custom and built-in Godot actions**.
- 🔧 **Configurable namespace support**.
- 📂 **Automatically reads `project.godot`** to generate constants.

---

## 📦 Installation

Add it to your Godot project via NuGet.  
Since this is a source generator, make sure to include the `PrivateAssets` and `IncludeAssets` properties:

```xml
<PackageReference Include="Shaka.Godot.Actions" Version="x.x.x">
   <PrivateAssets>all</PrivateAssets>
   <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
</PackageReference>
```

🔗 **Check the [NuGet package page](https://www.nuget.org/packages/Shaka.Godot.Actions/)** for the latest version.

The generator will automatically read your `project.godot` file and generate a globally available static `Actions` class.

---

## 🕹 Usage

### 🎯 Custom Actions
If you define a custom action in Godot (e.g., `quit`), you can access it with `MyGame.Actions.Quit`:

```csharp
public override void _Input(InputEvent @event)
{
    if (@event.IsActionPressed(MyGame.Actions.Quit))
    {
        Quit();
    }
}
```

### ⚙ Built-in Godot Actions
Godot’s default input actions are included under `MyGame.Actions.Builtin.UIAccept`:

```csharp
public override void _Input(InputEvent @event)
{
    if (@event.IsActionPressed(MyGame.Actions.Builtin.UIAccept))
    {
        AcceptGift();
    }
}
```

---

## ⚙ Configuration

### Actions Namespace

#### 📌 Default
By default, the generated `Actions` class is placed in the root namespace defined in your `.csproj`:

```xml
<PropertyGroup>
    <RootNamespace>MyGame</RootNamespace>
</PropertyGroup>
```

This means the class is accessible via:
```csharp
MyGame.Actions
```

If no root namespace is defined, the namespace will default to the assembly name — typically your project name.

#### ✏ Custom Namespace
If you don’t want the `Actions` class to be in the default namespace, override it by adding the `SGActionsNamespace` property:

```xml
<PropertyGroup>
    <SGActionsNamespace>MyActions</SGActionsNamespace>
</PropertyGroup>
```
The class will then be accessible via:
```csharp
MyActions.Actions
```

💡 **Tip**: This is useful if you want to group input actions into a dedicated namespace to avoid cluttering your main game namespace.

---

## 🤝 Contributing
Pull requests are welcome!  
If you have ideas for new features, bug fixes, or improvements, feel free to open an issue or PR.

---

## 📜 License
This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.
