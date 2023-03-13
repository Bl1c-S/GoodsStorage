using BusinessLogic_GS.Settings;
using Console_GS_UI.Viwes;
using Console_GS_UI.Viwes.RealizationView;
using Console_GS_UI.Viwes.ReceivingView;
using Console_GS_UI.Viwes.StorageView;
using ConsoleApteca_UI.Viwes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public override void Strategy(char keyChar)
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
                Receiving();
                break;
            case '4':
                Settings();
                break;
            default:
                Default(keyChar);
                break;
        }
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

            char keyChar = Console.ReadKey().KeyChar;

            if (keyChar == 'e' || keyChar == 'E')
                return;

            Strategy(keyChar);
        }
    }

    private void Receiving()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" -- Прихідні накладні : Прихід товару --\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" 1 ) Додати товар з штрих-кодом");
        Console.WriteLine(" 2 ) Додати товар в кількості");
        Console.WriteLine(" 3 ) Створити новий вид товару");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n N ) Відміна");
        Console.ForegroundColor = ConsoleColor.White;

        char keyChar = Console.ReadKey().KeyChar;

        if (GetBack(keyChar))
            return;

        _receivingView.Strategy(keyChar);
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

            if (GetBack(keyChar))
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

            if (Confirmation(keyChar))
                break;
            if (GetBack(keyChar))
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

            if (GetBack(keyChar))
                return;
        }
    }
}
