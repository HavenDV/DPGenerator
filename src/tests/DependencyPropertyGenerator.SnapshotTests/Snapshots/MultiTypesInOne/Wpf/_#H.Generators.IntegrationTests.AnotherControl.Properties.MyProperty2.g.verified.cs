﻿//HintName: H.Generators.IntegrationTests.AnotherControl.Properties.MyProperty2.g.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class AnotherControl
    {
        /// <summary>
        /// Identifies the <see cref="MyProperty2"/> dependency property.<br/>
        /// Default value: default((int, string))
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        public static readonly global::System.Windows.DependencyProperty MyProperty2Property =
            global::System.Windows.DependencyProperty.Register(
                name: "MyProperty2",
                propertyType: typeof((int, string)),
                ownerType: typeof(global::H.Generators.IntegrationTests.AnotherControl),
                typeMetadata: new global::System.Windows.FrameworkPropertyMetadata(
                    defaultValue: default((int, string)),
                    flags: global::System.Windows.FrameworkPropertyMetadataOptions.None,
                    propertyChangedCallback: static (sender, args) =>
                    {
                        ((global::H.Generators.IntegrationTests.AnotherControl)sender).OnMyProperty2Changed();
                    },
                    coerceValueCallback: null,
                    isAnimationProhibited: false),
                validateValueCallback: null);

        /// <summary>
        /// Default value: default((int, string))
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public (int, string) MyProperty2
        {
            get => ((int, string))GetValue(MyProperty2Property);
            set => SetValue(MyProperty2Property, value);
        }

        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnMyProperty2Changed();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnMyProperty2Changed((int, string) newValue);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnMyProperty2Changed((int, string) oldValue, (int, string) newValue);
    }
}