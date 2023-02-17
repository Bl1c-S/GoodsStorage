using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApteca_UI.Navigation
{
     public static class ControlKeyBoard
     {
          public static bool GetBack(char keyChar)
          {
               if (keyChar == 'n' || keyChar == 'N')
                    return true;
               return false;
          }
          public static bool Confirmation(char keyChar)
          {
               if (keyChar == 'y' || keyChar == 'Y')
                    return true;
               return false;
          }
          public static void Default(char keyChar)
          {
               Console.Clear();
               Console.WriteLine($"хуйня якась: {keyChar}");
               Task.Delay(2000).Wait();
          }
     }
}
