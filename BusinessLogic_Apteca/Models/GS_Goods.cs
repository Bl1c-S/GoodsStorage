namespace BusinessLogic_GS.Models;

public class GS_Goods : GS_GoodsBase
{
     private List <string> _seryalNumbers;
     public int Count => _seryalNumbers.Count;
     public string Name => BaseName;
     public GS_Category Category { get; private set; }

     public GS_Goods(GS_Category category, string name)
     {
          _seryalNumbers= new List<string>();
          Category = category;
          BaseName = name;
     }
     public bool AddSN(string sn)
     {
          if (_seryalNumbers.Contains(sn))
               return false;
          if (sn.Length < 4 || sn.Length > 32)
               return false;

          _seryalNumbers.Add(sn);
          return true;
     }
}
