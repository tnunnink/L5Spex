using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace L5Spex;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
            /*desktop.MainWindow.Width = 800;
            desktop.MainWindow.Height = 600;
            desktop.MainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;*/
        }

        base.OnFrameworkInitializationCompleted();
    }
}