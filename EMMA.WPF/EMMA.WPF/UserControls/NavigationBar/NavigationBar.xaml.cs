using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace EMMA.UserControls.NavigationBar;

public partial class NavigationBar : UserControl
{
    public NavigationBar()
    {
        InitializeComponent();
        HomeButton.Click += HomeButton_Click;
        SettingsButton.Click += SettingsButton_Click;
    }

    private MainWindow GetMainWindow()
    {
        MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;

        if (mainWindow == null)
        {
            throw new InvalidDataException("mainWindow is null");
        }

        return mainWindow;
    }

    private void HomeButton_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        GetMainWindow().MainFrame.Navigate(new Pages.Home());
    }

    private void SettingsButton_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }
}