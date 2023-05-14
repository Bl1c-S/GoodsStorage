namespace BusinessLogic_GS.Models;

public class GS_GoodsBase
{
     public Guid Id { get; private set; }
     protected string BaseName;
     public GS_GoodsBase()
     {
          Id = Guid.NewGuid();
          BaseName = string.Empty;
     }
}
