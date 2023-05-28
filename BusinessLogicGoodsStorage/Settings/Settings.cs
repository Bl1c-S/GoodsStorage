namespace BusinessLogic_GS.Settings;

public class Settings : SettingsDTO
{
     public Settings()
     {
          SettingsDTO settings = CheckSetting();
          this.FilePathSettings = settings.FilePathSettings;
          this.GoodsTypeDirectoriFilePath = settings.GoodsTypeDirectoriFilePath;
          this.GoodsStorageDirectoriFilePath = settings.GoodsStorageDirectoriFilePath;
     }
}
