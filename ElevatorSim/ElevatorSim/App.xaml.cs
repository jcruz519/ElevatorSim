using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ElevatorSim.Models;
using ElevatorSim.ViewModels;

namespace ElevatorSim
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddScoped<ITextFileInputReader, TextFileInputReader>();
            })
            .Build();

            AppHost.Services.GetRequiredService<ITextFileInputReader>();
        }
    }

}
