using System;
using System.Windows;
using MahApps.Metro;

namespace MahApps.Prism.Test
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ThemeManager.AddAccent("CustomAccent", new Uri("pack://application:,,,/MahApps.Prism.Test;component/Styles/CustomAccent.xaml"));
            ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent("CustomAccent"), ThemeManager.GetAppTheme("BaseDark"));

            base.OnStartup(e);
        }
    }

   
}