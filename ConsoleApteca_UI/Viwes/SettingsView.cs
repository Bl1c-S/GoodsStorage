using BusinessLogic_GS.Settings;

namespace ConsoleApteca_UI.Viwes;

public class SettingsView
{
     private Settings _settings;

     public SettingsView(Settings settings)
     {
          _settings = settings;
     }
     public void ShowSettings()
     {
          Console.WriteLine("", _settings.FilePathSettings);
          Console.WriteLine("", _settings.GoodsStorageDirectoriFilePath);
          Console.WriteLine("", _settings.GoodsTypeDirectoriFilePath);

     }
}