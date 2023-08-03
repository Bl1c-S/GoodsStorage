using BusinessLogic_GS.DTOs;
using BusinessLogic_GS.Models;
using Console_UI.DbContexts;

namespace Console_UI.Services.GS_GoodsCreator;

public class GoodsCreator : IGoodsCreator
{
     private readonly GS_DbContextFactory _DbContextFactory;

     public GoodsCreator(GS_DbContextFactory dbContextFactory)
     {
          _DbContextFactory = dbContextFactory;
     }
     public async Task Create(Goods goods)
     {
          using (GS_DbContext context = _DbContextFactory.CreateDbContext())
          {
               GoodsDTO goodsDTO = ToGoodsDTO(goods);

               context.Goods.Add(goodsDTO);
               await context.SaveChangesAsync();
          }
     }

     private GoodsDTO ToGoodsDTO(Goods goods)
     {
          return new GoodsDTO()
          {
               //SeryalNumbers = goods._seryalNumbers,
               CategoryId = goods.Category.Id,
               Id = goods.Id,
               Name = goods.Name,
          };
     }
}