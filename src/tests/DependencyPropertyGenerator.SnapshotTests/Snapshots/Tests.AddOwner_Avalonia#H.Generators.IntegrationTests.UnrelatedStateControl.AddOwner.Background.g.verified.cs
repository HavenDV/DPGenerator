﻿//HintName: H.Generators.IntegrationTests.UnrelatedStateControl.AddOwner.Background.g.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    public partial class UnrelatedStateControl
    {
        /// <summary>
        /// Identifies the <see cref="Background"/> dependency property.<br/>
        /// Default value: default(IBrush)
        /// </summary>
        public static readonly global::Avalonia.StyledProperty<global::Avalonia.Media.IBrush?> BackgroundProperty =
            global::Avalonia.Controls.Border.BackgroundProperty.AddOwner<global::H.Generators.IntegrationTests.UnrelatedStateControl>(
                null);

        /// <summary>
        /// Default value: default(IBrush)
        /// </summary>
        public global::Avalonia.Media.IBrush? Background
        {
            get => (global::Avalonia.Media.IBrush?)GetValue(BackgroundProperty);
            set => SetValue(BackgroundProperty, value);
        }

        partial void OnBackgroundChanged();
        partial void OnBackgroundChanged(global::Avalonia.Media.IBrush? newValue);
        partial void OnBackgroundChanged(global::Avalonia.Media.IBrush? oldValue, global::Avalonia.Media.IBrush? newValue);
    }
}