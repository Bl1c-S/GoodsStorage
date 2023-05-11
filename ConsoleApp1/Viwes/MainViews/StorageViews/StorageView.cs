using BusinessLogic_GS.Settings;

namespace Console_GS_UI.Viwes.MainViews.StorageViews;

public class StorageView : ViewBase
{
     private readonly Settings _settings;

     public StorageView(Settings settings)
     {
          _settings = settings;
     }
     public void Main()
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

               ConsoleKey key = Console.ReadKey().Key;

               if (GetBack(key))
                    return;

               Strategy(key);
          }
     }
     protected override void Strategy(ConsoleKey key)
     {
          switch (key)
          {
               case ConsoleKey.D1:
                    break;
               case ConsoleKey.D2:
                    break;
               case ConsoleKey.D3:
                    break;
               case ConsoleKey.D4:
                    CreateNewGoodsType();
                    break;
               default:
                    Default(key);
                    break;
          }
     }
     public void CreateIncomingInvoice()
     {

     }
     public void CreateNewGoodsType()
     {
          while (true)
          {
               Console.Clear();
               Console.ForegroundColor = ConsoleColor.Magenta;
               Console.WriteLine("-- Створити новий вид товару --\n");
               Console.ForegroundColor = ConsoleColor.White;
               Console.WriteLine(" - Введіть назву товару:");
               string name = Console.ReadLine()!;

               while (true)
               {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Y ) Підтвердити   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("N ) Назад");
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKey key = Console.ReadKey().Key;

                    if (Confirmation(key))
                    {
                         Console.Clear();
                         Console.WriteLine("Створення нового виду товару...");
                         string filePathGoodsTypeDirectory = Path.Combine(_settings.GoodsStorageDirectoriFilePath, name);

                         Console.Clear();
                         Console.WriteLine($"Створено новий вид товару: {name}");
                         Task.Delay(2000).Wait();
                         return;
                    }
                    if (GetBack(key))
                         return;
               }
          }
     }
}