using ConsoleApteca_UI.Viwes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_GS_UI.Viwes;

public abstract class ViewBase : IView
{
     protected abstract void Strategy(ConsoleKey key);

     protected void Default(ConsoleKey key)
     {
          Console.Clear();
          Console.WriteLine($"Недійсний символ: {key}");
          Task.Delay(300).Wait();
     }
     protected bool GetBack(ConsoleKey keyChar)
     {
          if (keyChar == ConsoleKey.N)
               return true;
          return false;
     }
     protected bool Confirmation(ConsoleKey keyChar)
     {
          if (keyChar == ConsoleKey.Y)
               return true;
          return false;
     }
}
