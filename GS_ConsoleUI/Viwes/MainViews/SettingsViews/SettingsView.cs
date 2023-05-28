using BusinessLogic_GS.Settings;
using Console_UI.Viwes;

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

               ConsoleKey key = Console.ReadKey().Key;

               if (GetBack(key))
                    return;
          }
     }
     protected override void Strategy(ConsoleKey key)
     {
          switch (key)
          {
               default:
                    Default(key);
                    break;
          }
     }
     public void ShowSettings()
    {
        Console.WriteLine($"Шлях до файлу налаштуваннь: {_settings.FilePathSettings}");
        Console.WriteLine("", _settings.GoodsStorageDirectoriFilePath);
        Console.WriteLine("", _settings.GoodsTypeDirectoriFilePath);

    }
}