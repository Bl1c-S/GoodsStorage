using BusinessLogic_Apteca.Models;
using BusinessLogic_Apteca.Services;
using BusinessLogic_Apteca.Settings;
using ConsoleApteca_UI.Navigation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApteca_UI.Viwes;

public class StorageView
{
     private readonly Settings _settings;
     private readonly FileManager<ApGoodsType> _fileManager;

     public StorageView(Settings settings, FileManager<ApGoodsType> fileManager)
     {
          _settings = settings;
          _fileManager = fileManager;
     }

     public void Strategy(char keyChar)
     {
          switch (keyChar)
          {
               case '4':
                    CreateNewGoodsType();
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

               ApGoodsType goodsType = new(name, _settings.GoodsTypeDirectoriFilePath);

               while (true)
               {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.Write(" Y ) Підтвердити   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("N ) Назад");
                    Console.ForegroundColor = ConsoleColor.White;
                    char keyChar = Console.ReadKey().KeyChar;

                    if (ControlKeyBoard.Confirmation(keyChar))
                    {
                         Console.Clear();
                         Console.WriteLine("Створення нового виду товару...");
                         string filePathGoodsTypeDirectory = Path.Combine(_settings.GoodsStorageDirectoriFilePath, name);

                         Directory.CreateDirectory(filePathGoodsTypeDirectory);
                         _fileManager.Create(goodsType);

                         Console.Clear();
                         Console.WriteLine($"Створено новий вид товару: {name}");
                         Task.Delay(2000).Wait();
                         return;
                    }
                    if (ControlKeyBoard.GetBack(keyChar))
                         return;
               }
          }
     }
}