using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_Apteca.Models;

public class ApGoods : ModelBase
{
     public readonly DateTime DateAddedToWarehouse;
     public readonly string SeryalNubmer;
     public ApGoodsType GoodsType { get; private set; }

     public ApGoods(string seryalNubmer, ApGoodsType goodsType)
     {
          SeryalNubmer = seryalNubmer;
          Expansion = ".apgoods";
          FilePath = SeryalNubmer + Id + Expansion;

          GoodsType = goodsType;
          DateAddedToWarehouse = DateTime.Now;
     }
}
