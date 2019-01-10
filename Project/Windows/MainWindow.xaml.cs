using System.Windows;
using MahApps.Metro;

namespace MahApps.Prism.Test.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += (sender, args) => { ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent("CustomAccent"), ThemeManager.GetAppTheme("BaseDark")); };
        }
    }
}