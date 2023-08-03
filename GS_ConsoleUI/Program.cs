using BusinessLogic_GS.Settings;
using Console_GS_UI.Viwes.MainViews;
using Console_GS_UI.Viwes.MainViews.RealizationViews;
using Console_GS_UI.Viwes.MainViews.ReceivingViews;
using Console_GS_UI.Viwes.MainViews.SettingsViews;
using Console_GS_UI.Viwes.MainViews.StorageViews;
using Console_UI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;

public class Program
{
     private const string CONECTION_STRING = "Data Source=GoodsStorage.db";
     public static void Main(string[] args)
     {
          Console.OutputEncoding = Encoding.UTF8;

          DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CONECTION_STRING).Options;
          using (GS_DbContext dbContext = new GS_DbContext(options))
          {
               dbContext.Database.Migrate();
          }

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

          host.Start();

          var main = host.Services.GetRequiredService<MainView>();
          main.Main();
     }
}