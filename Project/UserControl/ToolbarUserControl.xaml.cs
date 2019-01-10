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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            // Tests to see wat styles are currently used
            var theme = ThemeManager.DetectAppStyle(Application.Current); //BaseLight, even though the theme is set to BaseDark
            ThemeManager.ChangeAppStyle(Application.Current, theme.Item2, ThemeManager.GetAppTheme("BaseDark"));
            var theme1 = ThemeManager.DetectAppStyle(Application.Current); //BaseDark, After changing it it does detect as BaseDark, but Theme is not effected
            ThemeManager.ChangeAppStyle(Application.Current, theme.Item2, ThemeManager.GetAppTheme("BaseLight"));
            var theme2 = ThemeManager.DetectAppStyle(Application.Current); // BaseLight, Does again nothing
        }
    }
}
