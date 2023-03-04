using BusinessLogic_GS.Settings;
using ConsoleApteca_UI.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApteca_UI.Viwes;

public class MainView : IView
{
     private readonly RealizationView _realizationView;
     private readonly StorageView _storageView;
     private readonly SettingsView _settingsView;

     public MainView(RealizationView realization, StorageView storage)
     {
          _realizationView = realization;
          _storageView = storage;
     }

     private void Strategy(char keyChar)
     {
          switch (keyChar)
          {
               case '1':
                    Realization();
                    break;
               case '2':
                    Storage();
                    break;
               case '3':
                    Settings();
                    break;
               default:
                    ControlKeyBoard.Default(keyChar);
                    break;
          }
     }
     public void Main()
     {
          while (true)
          {
               Console.Clear();
               Console.ForegroundColor= ConsoleColor.Cyan;
               Console.WriteLine(" -- Меню --\n");
               Console.ForegroundColor = ConsoleColor.White;
               Console.WriteLine(" 1 ) Продати товар");
               Console.WriteLine(" 2 ) Склад");
               Console.WriteLine(" 3 ) Налаштування");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("\n E ) Вихід");
               Console.ForegroundColor = ConsoleColor.White;

               char keyChar = Console.ReadKey().KeyChar;

               if (keyChar == 'e' || keyChar == 'E')
                    return;

               Strategy(keyChar);
          }
     }
     private void Storage()
     {
          while (true)
          {
               Console.Clear();
               Console.ForegroundColor = ConsoleColor.DarkYellow;
               Console.WriteLine(" -- Склад : Керування складом --\n");
               Console.ForegroundColor = ConsoleColor.White;
               Console.WriteLine(" 1 ) Створити прихідну накладну");
               Console.WriteLine(" 2 ) Списати товар зі складу");
               Console.WriteLine(" 3 ) Переглянути весь склад");
               Console.WriteLine(" 4 ) Створити новий вид товару");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("\n N ) Відміна");
               Console.ForegroundColor = ConsoleColor.White;

               char keyChar = Console.ReadKey().KeyChar;

               if (ControlKeyBoard.GetBack(keyChar))
                    return;

               _storageView.Strategy(keyChar);
          }
     }
     private void Realization()
     {
          while (true)
          {
               Console.Clear();
               Console.ForegroundColor = ConsoleColor.Blue;
               Console.WriteLine(" -- Реалізація : Продати товар --\n");
               Console.ForegroundColor = ConsoleColor.White;
               Console.WriteLine(" 1 ) Додати товар до реалізації");
               Console.WriteLine(" 2 ) Видалити товар з реалізації");
               Console.ForegroundColor = ConsoleColor.DarkGreen;
               Console.Write("\n Y ) Продати   ");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("N) Відміна");
               Console.ForegroundColor = ConsoleColor.White;
               char keyChar = Console.ReadKey().KeyChar;

               if (ControlKeyBoard.Confirmation(keyChar))
                    break;
               if (ControlKeyBoard.GetBack(keyChar))
                    return;

               _realizationView.Strategy(keyChar);
          }
     }

     private void Settings()
     {
          while (true)
          {
               Console.Clear();
               Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine(" -- Налаштування --\n");
               Console.ForegroundColor = ConsoleColor.White;

               _settingsView.ShowSettings();

               Console.ForegroundColor = ConsoleColor.DarkGreen;
               Console.Write("\n Y ) Зберегти   ");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("\n N ) Відміна");
               Console.ForegroundColor = ConsoleColor.White;

               char keyChar = Console.ReadKey().KeyChar;

               if (ControlKeyBoard.GetBack(keyChar))
                    return;
          }
     }
}
