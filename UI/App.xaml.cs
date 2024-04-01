using Business;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using UI.Helpers;
using UI.ViewModels;

namespace UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var services = new ServiceCollection();
            services.AddBusinessServices();
            services.AddViewModels();
            var serviceProvider = services.BuildServiceProvider();
            DiResolver.SetContainer(serviceProvider);
        }
    }

}
