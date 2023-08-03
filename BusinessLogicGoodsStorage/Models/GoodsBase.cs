namespace BusinessLogic_GS.Models;

public class GoodsBase
{
     private const int MIN_SN_LENGTH = 4;
     private const int MAX_SN_LENGTH = 64;

     public int MinSnLength => MIN_SN_LENGTH;
     public int MaxSnLength => MAX_SN_LENGTH;

     public Guid Id { get; private set; }
     protected string BaseName;
     public GoodsBase()
     {
          Id = Guid.NewGuid();
          BaseName = string.Empty;
     }
}
