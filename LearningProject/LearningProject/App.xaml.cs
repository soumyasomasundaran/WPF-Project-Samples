using Autofac;
using Autofac.Core;
using LearningProject.Core;
using LearningProject.MVVM.ViewModel;
using LearningProject.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LearningProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        public static IContainer Container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainViewModel>().As<MainViewModel>().SingleInstance();
            builder.RegisterType<HomeViewModel>().As<HomeViewModel>().SingleInstance();
            builder.RegisterType<SettingsViewModel>().As<SettingsViewModel>().SingleInstance();
            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();

            // Register the ViewModelFactory directly
            builder.Register<Func<Type, ViewModelBase>>(c =>
            {
                var container = c.Resolve<IComponentContext>();
                return type => container.Resolve(type) as ViewModelBase;
            }).SingleInstance();

            Container = builder.Build();

            using (var scope = Container.BeginLifetimeScope())
            {
                var window = new MainWindow
                {
                    DataContext = scope.Resolve<MainViewModel>()
            };
                window.Show();
            }
            
            base.OnStartup(e);
        }
    }
}
