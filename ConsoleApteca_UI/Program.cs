using BusinessLogic_GS.Settings;
using Console_GS_UI.Viwes.MainViews;
using Console_GS_UI.Viwes.MainViews.RealizationViews;
using Console_GS_UI.Viwes.MainViews.ReceivingViews;
using Console_GS_UI.Viwes.MainViews.SettingsViews;
using Console_GS_UI.Viwes.MainViews.StorageViews;
using ConsoleApteca_UI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;

public class Program
{
     public static void Main(string[] args)
     {
          Console.OutputEncoding = Encoding.UTF8;

          IHost host = Host.CreateDefaultBuilder().ConfigureServices(servises =>
          {
               servises.AddSingleton<Settings>();
               servises.AddSingleton<SettingsView>();
               servises.AddSingleton<ReceivingView>();
               servises.AddScoped<RealizationView>();
               servises.AddScoped<StorageView>();

               servises.AddSingleton<MainView>();
          }).
          Build();

          var sett = host.Services.GetRequiredService<Settings>();


          host.Start();

          var main = host.Services.GetRequiredService<MainView>();
          main.Main();
     }
}