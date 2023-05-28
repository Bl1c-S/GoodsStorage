using Console_UI.DbContexts;
using BusinessLogic_GS.Models;
using Microsoft.EntityFrameworkCore;
using BusinessLogic_GS.DTOs;
using Microsoft.EntityFrameworkCore.Internal;

namespace Console_UI.Services;

public class DbProvaider : IDbProvaider
{
     private readonly DbContextFactory<GS_DbContext> _DbContextFactory;

     public DbProvaider(DbContextFactory<GS_DbContext> dbContextFactory)
     {
          _DbContextFactory = dbContextFactory;
     }

     public async Task<IEnumerable<Goods>> GetAllGoods()
     {
          using (GS_DbContext context = _DbContextFactory.CreateDbContext())
          {
               IEnumerable<GoodsDTO> goodsDTOs = await context.Goods.ToListAsync();

               return goodsDTOs.Select(r => ToGS_Goods(r));
          }
     }

     private Goods ToGS_Goods(GoodsDTO r)
     {
          return new Goods(new Category(r.Name), r.Name);
     }
}