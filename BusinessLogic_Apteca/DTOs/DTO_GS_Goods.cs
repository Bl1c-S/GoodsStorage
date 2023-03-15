using BusinessLogic_GS.Models;

namespace BusinessLogic_GS.DTOs;

public class DTO_GS_Goods
{
     public List<string> _seryalNumbers;
     public GS_GoodsType GoodsType;
     public int Count;

     public DTO_GS_Goods(List<string> seryalNumbers, GS_GoodsType goodsType)
     {
          _seryalNumbers = seryalNumbers;
          Count = seryalNumbers.Count;
          GoodsType = goodsType;
     }
}