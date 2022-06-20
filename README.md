# DependencyPropertyGenerator
Dependency property source generator for WPF/UWP/WinUI/Uno platforms.

### Install
```
Install-Package DependencyPropertyGenerator // Generator
Install-Package DependencyPropertyGenerator.Core // Attributes
```

### Usage
```cs
using DependencyPropertyGenerator;
using System.Windows;
using System.Windows.Controls;

#nullable enable

namespace H.Generators.IntegrationTests;

[DependencyProperty<bool>("IsSpinning", DefaultValue = true)]
public partial class MainWindow : Window
{
    // Optional
    static partial void OnIsSpinningChanged(MainWindow sender, bool oldValue, bool newValue)
    {
    }
}

[AttachedDependencyProperty<object, TreeView>("SelectedItem", BindsTwoWayByDefault = true)]
public static partial class TreeViewExtensions
{
    // Optional
    static partial void OnSelectedItemChanged(TreeView sender, object? oldValue, object? newValue)
    {
    }
}
```
will generate:
```cs
//HintName: MainWindow_DependencyProperties.generated.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    public partial class MainWindow
    {
        public static readonly global::System.Windows.DependencyProperty IsSpinningProperty =
            global::System.Windows.DependencyProperty.Register(
                name: "IsSpinning",
                propertyType: typeof(bool),
                ownerType: typeof(MainWindow),
                typeMetadata: new global::System.Windows.FrameworkPropertyMetadata(
                    true,
                    global::System.Windows.FrameworkPropertyMetadataOptions.None,
                    static (sender, args) => OnIsSpinningChanged((MainWindow)sender, (bool)args.OldValue, (bool)args.NewValue)));

        public bool IsSpinning
        {
            get => (bool)GetValue(IsSpinningProperty);
            set => SetValue(IsSpinningProperty, value);
        }

        static partial void OnIsSpinningChanged(MainWindow sender, bool oldValue, bool newValue);
    }
}
```
```cs
//HintName: TreeViewExtensions_AttachedDependencyProperties.generated.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    public static partial class TreeViewExtensions
    {
        public static readonly global::System.Windows.DependencyProperty SelectedItemProperty =
            global::System.Windows.DependencyProperty.RegisterAttached(
                name: "SelectedItem",
                propertyType: typeof(object),
                ownerType: typeof(TreeViewExtensions),
                defaultMetadata: new global::System.Windows.FrameworkPropertyMetadata(
                    default(object),
                    global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    static (sender, args) => OnSelectedItemChanged((System.Windows.Controls.TreeView)sender, (object?)args.OldValue, (object?)args.NewValue)));
  
        public static void SetSelectedItem(global::System.Windows.DependencyObject element, object? value)
        {
            element.SetValue(SelectedItemProperty, value);
        }

        [global::System.Windows.AttachedPropertyBrowsableForType(typeof(System.Windows.Controls.TreeView))]
        public static object? GetSelectedItem(global::System.Windows.DependencyObject element)
        {
            return (object?)element.GetValue(SelectedItemProperty);
        }

        static partial void OnSelectedItemChanged(System.Windows.Controls.TreeView sender, object? oldValue, object? newValue);
    }
}
```

### Notes
To use generic attributes, you need to set up `LangVersion` in your .csproj:
```xml
<LangVersion>preview</LangVersion>
```
There are also non-Generic attributes here.

### Support
You can get answers to your questions in my discord support channel:  
https://discord.gg/g8u2t9dKgE