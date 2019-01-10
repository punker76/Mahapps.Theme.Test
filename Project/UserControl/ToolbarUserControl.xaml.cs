using System.Windows;
using MahApps.Metro;

namespace MahApps.Prism.Test.UserControl
{
    /// <summary>
    /// Interaction logic for ToolbarUserControl.xaml
    /// </summary>
    public partial class ToolbarUserControl : System.Windows.Controls.UserControl
    {
        public ToolbarUserControl()
        {
            InitializeComponent();
        }

        private void ChangeToDarkOnClick(object sender, RoutedEventArgs e)
        {
            // Tests to see wat styles are currently used
            var theme = ThemeManager.DetectAppStyle(Application.Current);
            ThemeManager.ChangeAppStyle(Application.Current, theme.Item2, ThemeManager.GetAppTheme("BaseDark"));
        }

        private void ChangeToLightOnClick(object sender, RoutedEventArgs e)
        {
            // Tests to see wat styles are currently used
            var theme = ThemeManager.DetectAppStyle(Application.Current);
            ThemeManager.ChangeAppStyle(Application.Current, theme.Item2, ThemeManager.GetAppTheme("BaseLight"));
        }
    }
}
