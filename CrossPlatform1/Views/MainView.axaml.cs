using System;
using Avalonia;
using Avalonia.Controls;

namespace CrossPlatform1.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        // Initial update
        UpdateScreenSizeLabel(this.Bounds);

        // Subscribe to size changes
        this.GetObservable(BoundsProperty)
            .Subscribe(bounds => UpdateScreenSizeLabel(bounds));
    }

    private void UpdateScreenSizeLabel(Rect bounds)
    {
        if (this.FindControl<Label>("ScreenSizeLabel") is { } label)
        {
            var size = this.Bounds.Size;
            label.Content = $"Window size: {size.Width:0} x {size.Height:0}";
        }
    }
}
