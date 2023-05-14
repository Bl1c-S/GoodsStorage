namespace BusinessLogic_GS.Settings;

public class Settings : DTOSettings
{
     public Settings()
     {
          DTOSettings settings = CheckSetting();
          this.FilePathSettings = settings.FilePathSettings;
          this.GoodsTypeDirectoriFilePath = settings.GoodsTypeDirectoriFilePath;
          this.GoodsStorageDirectoriFilePath = settings.GoodsStorageDirectoriFilePath;
     }
}
