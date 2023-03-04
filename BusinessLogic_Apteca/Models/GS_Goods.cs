using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_GS.Models;

public class GS_Goods : GS_GoodsBase
{
     public readonly DateTime DateAddedToWarehouse;
     private List <string> _seryalNumbers;
     public int Count => _seryalNumbers.Count;
     public GS_GoodsType GoodsType { get; private set; }

     public GS_Goods(GS_GoodsType goodsType)
     {
          _seryalNumbers= new List<string>();
          GoodsType = goodsType;
          DateAddedToWarehouse = DateTime.Now;
     }
     public bool AddSN(string sn) 
     {
          if (_seryalNumbers.Contains(sn))
               return false;
          if (sn.Length < 6 || sn.Length > 32)
               return false;

          _seryalNumbers.Add(sn);
          return true;
     }
}
