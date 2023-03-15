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

               char keyChar = Console.ReadKey().KeyChar;

               if (GetBack(keyChar))
                    return;

               Strategy(keyChar);
          }
     }
     protected override void Strategy(char keyChar)
     {
          switch (keyChar)
          {
               case '1':

                    break;
               case '2':
                    break;
               case '3':
                    break;
               default:
                    Default(keyChar);
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
                         Console.WriteLine($"Помилка: Штрих-код менше 6 або більше 24 символів" +
                              $"\n або присутні пробели");
               }
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
          }
     }
}