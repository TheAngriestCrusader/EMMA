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

    private void HomeButton_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void SettingsButton_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }
}