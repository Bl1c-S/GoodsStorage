using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_GS.Models;

public class GS_Category : GS_GoodsBase
{
     public string Name => BaseName;

     public GS_Category(string name)
     {
          BaseName = name;
     }
}
