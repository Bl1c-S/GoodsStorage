using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_Apteca.Models;

public class ApGoodsType : ModelBase
{
     public string Title { get; private set; }

     public ApGoodsType(string title, string directoryFilePath)
     {
          Title = title;
          Expansion = ".apgoodstype";
          FilePath = Path.Combine(directoryFilePath, title + Id + Expansion);
     }
}
