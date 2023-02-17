using BusinessLogic_Apteca.Models;
using BusinessLogic_Apteca.Services;
using BusinessLogic_Apteca.Settings;
using ConsoleApteca_UI;
using ConsoleApteca_UI.Viwes;
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
               servises.AddSingleton<FileManager<ApGoodsType>>();
               servises.AddSingleton<FileManager<ApGoods>>();

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