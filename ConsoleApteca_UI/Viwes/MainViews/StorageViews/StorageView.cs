using BusinessLogic_GS.Models;
using BusinessLogic_GS.Settings;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Console_GS_UI.Viwes.MainViews.StorageViews;

public class StorageView : ViewBase
{
    private readonly Settings _settings;

    public StorageView(Settings settings)
    {
        _settings = settings;
    }

    public override void Strategy(char keyChar)
    {
        switch (keyChar)
        {
            case '4':
                CreateNewGoodsType();
                break;
            default:
                Default(keyChar);
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

            GS_GoodsType goodsType = new(name);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" Y ) Підтвердити   ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("N ) Назад");
                Console.ForegroundColor = ConsoleColor.White;
                char keyChar = Console.ReadKey().KeyChar;

                if (Confirmation(keyChar))
                {
                    Console.Clear();
                    Console.WriteLine("Створення нового виду товару...");
                    string filePathGoodsTypeDirectory = Path.Combine(_settings.GoodsStorageDirectoriFilePath, name);

                    Console.Clear();
                    Console.WriteLine($"Створено новий вид товару: {name}");
                    Task.Delay(2000).Wait();
                    return;
                }
                if (GetBack(keyChar))
                    return;
            }
        }
    }
}