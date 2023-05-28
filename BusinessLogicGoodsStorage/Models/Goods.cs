namespace BusinessLogic_GS.Models;

public class Goods : GoodsBase
{
     public List <string> _seryalNumbers { get; private set; }
     public string Name => BaseName;
     public Category Category { get; private set; }

     public Goods(Category category, string name)
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
