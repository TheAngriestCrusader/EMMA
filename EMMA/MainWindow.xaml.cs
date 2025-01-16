using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EMMA;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Loaded += OnLoaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        BlurWindow.EnableBlur(this);
    }

    private void DragMoveWindow(object sender, MouseButtonEventArgs e)
    {
        if (WindowState == WindowState.Maximized)
        {
            // Get the current mouse position relative to the screen.
            var mousePosition = e.GetPosition(this);
            var xOffset = mousePosition.X / ActualWidth;
            var yOffset = mousePosition.Y / ActualHeight;

            // Get the absolute position of the mouse on the screen.
            var screenMousePosition = PointToScreen(mousePosition);

            // Change the window state to normal.
            WindowState = WindowState.Normal;

            // Adjust the window's position to keep the cursor on the navigation bar.
            Left = screenMousePosition.X - (Width * xOffset);
            Top = screenMousePosition.Y - (Height * yOffset);
        }

        DragMove();
    }
}