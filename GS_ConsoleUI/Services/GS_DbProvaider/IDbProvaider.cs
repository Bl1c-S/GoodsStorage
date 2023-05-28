using BusinessLogic_GS.Models;

namespace Console_UI.Services;

public interface IDbProvaider
{
     Task<IEnumerable<Goods>> GetAllGoods();
}
