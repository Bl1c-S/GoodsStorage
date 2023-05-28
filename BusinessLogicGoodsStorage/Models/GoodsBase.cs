namespace BusinessLogic_GS.Models;

public class GoodsBase
{
     public Guid Id { get; private set; }
     protected string BaseName;
     public GoodsBase()
     {
          Id = Guid.NewGuid();
          BaseName = string.Empty;
     }
}
