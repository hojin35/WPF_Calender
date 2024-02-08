using Prism.Ioc;
using Prism.Unity;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows;
using WPF_Calender.Services;
using WPF_Calender.Views;

namespace WPF_Calender
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Calender>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IDialogService, DialogService>();
            containerRegistry.RegisterForNavigation<Calender>();
        }
    }

}
