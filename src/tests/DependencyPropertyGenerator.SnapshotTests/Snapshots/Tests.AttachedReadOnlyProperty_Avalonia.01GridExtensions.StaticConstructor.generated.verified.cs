﻿//HintName: GridExtensions.StaticConstructor.generated.cs

using System;

#nullable enable

namespace H.Generators.IntegrationTests
{
    public partial class GridExtensions
    {
        static GridExtensions()
        {
            AttachedReadOnlyPropertyProperty.Changed.Subscribe(static x => OnAttachedReadOnlyPropertyChanged(
                (global::Avalonia.Controls.Grid)x.Sender,
                (object?)x.OldValue.GetValueOrDefault(),
                (object?)x.NewValue.GetValueOrDefault()));
        }
    }
}