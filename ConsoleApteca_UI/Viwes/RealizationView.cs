namespace ConsoleApteca_UI.Viwes
{
     public class RealizationView : IView
     {
          public void Strategy(char keyChar)
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
                         Console.Clear();
                         Console.WriteLine($"хуйня якась: {keyChar}");
                         Task.Delay(300).Wait();
                         break;
               }
          }
     }
}