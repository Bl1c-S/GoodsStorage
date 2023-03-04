using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_GS.Models;

public class GS_GoodsType : GS_GoodsBase
{
     public string Title { get; private set; }

     public GS_GoodsType(string title)
     {
          Title = title;
     }
}
