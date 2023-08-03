using System.ComponentModel.DataAnnotations;

namespace BusinessLogic_GoodsStorage.DTOs;

public class CategoryDTO
{
     [Key]
     public Guid Id { get; set; }
     public int Name { get; set; }
}
