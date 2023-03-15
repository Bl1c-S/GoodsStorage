using ConsoleApteca_UI.Viwes;

namespace Console_GS_UI.Viwes.MainViews.RealizationViews
{
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
                    char keyChar = Console.ReadKey().KeyChar;

                    if (Confirmation(keyChar))
                         break;
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
    }
}