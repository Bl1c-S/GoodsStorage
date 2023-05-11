namespace Console_GS_UI.Viwes.MainViews.ReceivingViews;

public class ReceivingView : ViewBase
{
     public void Main()
     {
          while (true)
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

               ConsoleKey key = Console.ReadKey().Key;

               if (GetBack(key))
                    return;

               //Strategy(key);
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
               default:
                    Default(key);
                    break;
          }
     }
     public void AddGoodsByBarcode()
     {
          while (true)
          {
               Console.Clear();
               Console.ForegroundColor = ConsoleColor.DarkRed;
               Console.WriteLine(" -- Прихід : Додати товар з  штрих-кодом --\n");
               Console.ForegroundColor = ConsoleColor.White;
               Console.WriteLine(" Оберіть вид товару:");
               //Обираю товар
               List<string> newSeryalNumbers = new();

               while (true)
               {
                    Console.WriteLine(" Введіть штрих-код:");
                    string sn = Console.ReadLine()!;
                    if (!string.IsNullOrEmpty(sn) && sn.Length >= 6 && sn.Length <= 24 && sn.Contains(' '))
                    {
                         newSeryalNumbers.Add(sn);
                         break;
                    }
                    else
                         Console.WriteLine($" Помилка: Штрих-код менше 6 або більше 24 символів" +
                              $"\n або присутні пробели");
               }
               Console.ForegroundColor = ConsoleColor.DarkGreen;
               Console.Write("\n Y ) Продати   ");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("N) Відміна");
               Console.ForegroundColor = ConsoleColor.White;
               ConsoleKey key = Console.ReadKey().Key;

               if (Confirmation(key))
                    break;
               if (GetBack(key))
                    return;
          }
     }
}