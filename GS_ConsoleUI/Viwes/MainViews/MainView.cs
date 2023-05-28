using Console_GS_UI.Viwes.MainViews.SettingsViews;
using Console_GS_UI.Viwes.MainViews.RealizationViews;
using Console_GS_UI.Viwes.MainViews.ReceivingViews;
using Console_GS_UI.Viwes.MainViews.StorageViews;
using Console_UI.Viwes;

namespace Console_GS_UI.Viwes.MainViews;

public class MainView : ViewBase
{
     private readonly RealizationView _realizationView;
     private readonly StorageView _storageView;
     private readonly SettingsView _settingsView;
     private readonly ReceivingView _receivingView;

     public MainView(RealizationView realization
          , StorageView storage
          , ReceivingView receivingView,
          SettingsView settingsView)
     {
          _realizationView = realization;
          _storageView = storage;
          _receivingView = receivingView;
          _settingsView = settingsView;
     }

     public void Main()
     {
          while (true)
          {
               Console.Clear();
               Console.ForegroundColor = ConsoleColor.Cyan;
               Console.WriteLine(" -- Меню --\n");
               Console.ForegroundColor = ConsoleColor.White;
               Console.WriteLine(" 1 ) -- Реалізація : Продати товар --");
               Console.WriteLine(" 2 ) -- Склад : Керування складом --");
               Console.WriteLine(" 3 ) -- Прихідні накладні : Прихід товару --");
               Console.WriteLine(" 4 ) -- Налаштування --");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("\n E ) Вихід");
               Console.ForegroundColor = ConsoleColor.White;

               ConsoleKey key = Console.ReadKey().Key;

               if (key == ConsoleKey.E)
                    break;

               Strategy(key);
          }
     }
     protected override void Strategy(ConsoleKey key)
     {
          switch (key)
          {
               case ConsoleKey.D1:
                    _realizationView.Main();
                    break;
               case ConsoleKey.D2:
                    _storageView.Main();
                    break;
               case ConsoleKey.D3:
                    _receivingView.Main();
                    break;
               case ConsoleKey.D4:
                    _settingsView.Main();
                    break;
               default:
                    Default(key);
                    break;
          }
     }
}
