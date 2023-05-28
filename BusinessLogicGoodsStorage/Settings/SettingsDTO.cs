using Newtonsoft.Json;

namespace BusinessLogic_GS.Settings;

public class SettingsDTO
{
     public string FilePathSettings = string.Empty;
     public string GoodsTypeDirectoriFilePath = string.Empty;
     public string GoodsStorageDirectoriFilePath = string.Empty;
     protected SettingsDTO CheckSetting()
     {
          string filePathSettings = Path.Combine(Environment.CurrentDirectory, "AppSettings.json");

          if (File.Exists(filePathSettings))
          {
               string jsonSettings = File.ReadAllText(filePathSettings);
               SettingsDTO deresializedSettings = JsonConvert.DeserializeObject<SettingsDTO>(jsonSettings)!;

               if (deresializedSettings != null)
                    return deresializedSettings;
          }

          var defaultSettings = CreateDefaultSettings();
          return defaultSettings;
     }

     private SettingsDTO CreateDefaultSettings()
     {
          FilePathSettings = Path.Combine(Environment.CurrentDirectory, "AppSettings.json");
          GoodsTypeDirectoriFilePath = Path.Combine(Environment.CurrentDirectory, "GoodsTypeStorage");
          GoodsStorageDirectoriFilePath = Path.Combine(Environment.CurrentDirectory, "GoodsStorage");

          Directory.CreateDirectory(GoodsTypeDirectoriFilePath);
          Directory.CreateDirectory(GoodsStorageDirectoriFilePath);

          string jsonData = JsonConvert.SerializeObject(this);
          File.WriteAllText(FilePathSettings, jsonData);

          return this;
     }
     protected void SaveSettings()
     {
          string jsonSetting = JsonConvert.SerializeObject(this);
          File.WriteAllText(FilePathSettings, jsonSetting);
     }
}
