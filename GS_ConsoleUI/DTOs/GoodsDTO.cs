using SQLiteNetExtensions.Attributes;

namespace BusinessLogic_GS.DTOs;

public class GoodsDTO
{
     public Guid Id { get; set; }
     public Guid CategoryId { get; set; }
     public string Name { get; set; }

     [TextBlob("SeryalNumbersBlobbed")]
     public List<string> SeryalNumbers { get; set; }


     //public DTO_GS_Goods(List<string> seryalNumbers, GS_GoodsType goodsType)
     //{
     //     _seryalNumbers = seryalNumbers;
     //     Count = seryalNumbers.Count;
     //     Title_GSType = goodsType.Title;
     //}
}