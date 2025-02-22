using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using IGDGQuantumTest.Host.Views;
using Avalonia.Diagnostics;

namespace IGDGQuantumTest.Host
{
    public class App : Application
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
                DevTools.Attach(desktop.MainWindow); // Attach the Avalonia DevTools
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
