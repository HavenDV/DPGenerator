﻿//HintName: H.Generators.IntegrationTests.MyControl.Properties.TupleIntControl.g.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    public partial class MyControl
    {
        /// <summary>
        /// Identifies the <see cref="TupleIntControl"/> dependency property.<br/>
        /// Default value: default(Tuple&lt;int, FrameworkElement&gt;)
        /// </summary>
        public static readonly global::Microsoft.UI.Xaml.DependencyProperty TupleIntControlProperty =
            global::Microsoft.UI.Xaml.DependencyProperty.Register(
                name: "TupleIntControl",
                propertyType: typeof(global::System.Tuple<int, global::Microsoft.UI.Xaml.FrameworkElement>),
                ownerType: typeof(global::H.Generators.IntegrationTests.MyControl),
                typeMetadata: new global::Microsoft.UI.Xaml.PropertyMetadata(
                    defaultValue: default(global::System.Tuple<int, global::Microsoft.UI.Xaml.FrameworkElement>),
                    propertyChangedCallback: null));

        /// <summary>
        /// Default value: default(Tuple&lt;int, FrameworkElement&gt;)
        /// </summary>
        public global::System.Tuple<int, global::Microsoft.UI.Xaml.FrameworkElement>? TupleIntControl
        {
            get => (global::System.Tuple<int, global::Microsoft.UI.Xaml.FrameworkElement>?)GetValue(TupleIntControlProperty);
            set => SetValue(TupleIntControlProperty, value);
        }

        partial void OnTupleIntControlChanged();
        partial void OnTupleIntControlChanged(global::System.Tuple<int, global::Microsoft.UI.Xaml.FrameworkElement>? newValue);
        partial void OnTupleIntControlChanged(global::System.Tuple<int, global::Microsoft.UI.Xaml.FrameworkElement>? oldValue, global::System.Tuple<int, global::Microsoft.UI.Xaml.FrameworkElement>? newValue);
    }
}