﻿//HintName: GridExtensions.AttachedProperties.BindEventProperty.generated.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    public partial class GridExtensions : global::Avalonia.AvaloniaObject
    {
        /// <summary>
        /// Default value: default(object)
        /// </summary>
        public static readonly global::Avalonia.AttachedProperty<object?> BindEventPropertyProperty =
            global::Avalonia.AvaloniaProperty.RegisterAttached<global::H.Generators.IntegrationTests.GridExtensions, global::Avalonia.Controls.Grid, object?>(
                name: "BindEventProperty",
                defaultValue: default(object),
                inherits: false,
                defaultBindingMode: global::Avalonia.Data.BindingMode.OneWay,
                validate: null,
                coerce: null);

        /// <summary>
        /// Default value: default(object)
        /// </summary>
        public static void SetBindEventProperty(global::Avalonia.IAvaloniaObject element, object? value)
        {
            element = element ?? throw new global::System.ArgumentNullException(nameof(element));

            element.SetValue(BindEventPropertyProperty, value);
        }

        /// <summary>
        /// Default value: default(object)
        /// </summary>
        public static object? GetBindEventProperty(global::Avalonia.IAvaloniaObject element)
        {
            element = element ?? throw new global::System.ArgumentNullException(nameof(element));

            return (object?)element.GetValue(BindEventPropertyProperty);
        }

        static partial void OnBindEventPropertyChanged();
        static partial void OnBindEventPropertyChanged(global::Avalonia.Controls.Grid grid);
        static partial void OnBindEventPropertyChanged(global::Avalonia.Controls.Grid grid, object? newValue);
        static partial void OnBindEventPropertyChanged(global::Avalonia.Controls.Grid grid, object? oldValue, object? newValue);

        static partial void OnBindEventPropertyChanged_BeforeBind(
            global::Avalonia.Controls.Grid grid,
            object? oldValue,
            object? newValue);
        static partial void OnBindEventPropertyChanged_AfterBind(
            global::Avalonia.Controls.Grid grid,
            object? oldValue,
            object? newValue);

        static partial void OnBindEventPropertyChanged(
            global::Avalonia.Controls.Grid grid,
            object? oldValue,
            object? newValue)
        {
            OnBindEventPropertyChanged_BeforeBind(
                grid,
                oldValue,
                newValue);

            if (oldValue is not default(object))
            {
                grid.KeyUp -= OnBindEventPropertyChanged_KeyUp;
            }
            if (newValue is not default(object))
            {
                grid.KeyUp += OnBindEventPropertyChanged_KeyUp;
            }

            OnBindEventPropertyChanged_AfterBind(
                grid,
                oldValue,
                newValue);
        }
    }
}