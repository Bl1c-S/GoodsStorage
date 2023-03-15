using BusinessLogic_GS.Settings;
using Console_GS_UI.Viwes.MainViews.RealizationViews;
using Console_GS_UI.Viwes.MainViews.ReceivingViews;
using Console_GS_UI.Viwes.MainViews.StorageViews;

namespace Console_GS_UI.Viwes.MainViews.SettingsViews;

public class SettingsView : ViewBase
{
    private Settings _settings;

    public SettingsView(Settings settings)
    {
        _settings = settings;
    }
     public void Main()
     {
          while (true)
          {
               Console.Clear();
               Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine(" -- Налаштування --\n");
               Console.ForegroundColor = ConsoleColor.White;

               ShowSettings();

               Console.ForegroundColor = ConsoleColor.DarkGreen;
               Console.Write("\n Y ) Зберегти   ");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("\n N ) Відміна");
               Console.ForegroundColor = ConsoleColor.White;

               char keyChar = Console.ReadKey().KeyChar;

               if (GetBack(keyChar))
                    return;
          }
     }
     protected override void Strategy(char keyChar)
     {
          switch (keyChar)
          {
               default:
                    Default(keyChar);
                    break;
          }
     }
     public void ShowSettings()
    {
        Console.WriteLine("", _settings.FilePathSettings);
        Console.WriteLine("", _settings.GoodsStorageDirectoriFilePath);
        Console.WriteLine("", _settings.GoodsTypeDirectoriFilePath);

    }
}