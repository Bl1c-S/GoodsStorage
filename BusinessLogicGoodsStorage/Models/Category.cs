using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_GS.Models;

public class Category : GoodsBase
{
     public string Name => BaseName;

     public Category(string name)
     {
          BaseName = name;
     }
}
