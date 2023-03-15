using ConsoleApteca_UI.Viwes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_GS_UI.Viwes;

public abstract class ViewBase : IView
{
     protected abstract void Strategy(char keyChar);

     protected void Default(char keyChar)
     {
          Console.Clear();
          Console.WriteLine($"Недійсний символ: {keyChar}");
          Task.Delay(300).Wait();
     }
     protected bool GetBack(char keyChar)
     {
          if (keyChar == 'n' || keyChar == 'N')
               return true;
          return false;
     }
     protected bool Confirmation(char keyChar)
     {
          if (keyChar == 'y' || keyChar == 'Y')
               return true;
          return false;
     }
}
