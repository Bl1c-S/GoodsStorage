namespace BusinessLogic_GS.Models;

public class Goods : GoodsBase
{
     private List<string> _seryalNumbers;
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
          if (sn.Length < MinSnLength || sn.Length > MaxSnLength)
               return false;

          _seryalNumbers.Add(sn);
          return true;
     }
}