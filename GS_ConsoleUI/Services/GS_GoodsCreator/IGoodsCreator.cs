using BusinessLogic_GS.Models;

namespace Console_UI.Services.GS_GoodsCreator;

public interface IGoodsCreator
{
     Task Create(Goods goods);
}
