using System.ComponentModel.DataAnnotations;

namespace BusinessLogic_GS.DTOs;

public class GoodsDTO
{
     [Key]
     public Guid Id { get; set; }
     public Guid CategoryId { get; set; }
     public string Name { get; set; }
     public string SeryalNumbers { get; set; }


     //public DTO_GS_Goods(List<string> seryalNumbers, GS_GoodsType goodsType)
     //{
     //     _seryalNumbers = seryalNumbers;
     //     Count = seryalNumbers.Count;
     //     Title_GSType = goodsType.Title;
     //}
}