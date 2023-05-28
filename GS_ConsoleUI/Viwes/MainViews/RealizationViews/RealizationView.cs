using Console_UI.Viwes;

namespace Console_GS_UI.Viwes.MainViews.RealizationViews;

public class RealizationView : ViewBase
{
     public void Main()
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
               ConsoleKey key = Console.ReadKey().Key;

               if (Confirmation(key))
                    break;
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
}