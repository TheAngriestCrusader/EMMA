using System.Windows;
using System.Windows.Controls;

namespace EMMA.UserControls.NavigationBar;

public partial class NavigationBar : UserControl
{
    private Window? _window = null;
    
    public NavigationBar()
    {
        InitializeComponent();
        Loaded += OnLoaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        _window = Window.GetWindow(this);
    }

    private void OnMinimiseButtonPress(object sender, RoutedEventArgs e)
    {
        Console.WriteLine(_window);
        if (_window == null) return;
        
        _window.WindowState = WindowState.Minimized;
    }

    private void OnMaximiseButtonPress(object sender, RoutedEventArgs e)
    {
        if (_window == null) return;
        
        _window.WindowState = _window.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
    }

    private void OnExitButtonPress(object sender, RoutedEventArgs e)
    {
        _window?.Close();
    }
}