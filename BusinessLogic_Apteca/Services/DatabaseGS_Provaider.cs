using BusinessLogic_GoodsStorage.DbContexts;
using BusinessLogic_GS.DbContexts;
using BusinessLogic_GS.DTOs;
using BusinessLogic_GS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_GoodsStorage.Services;

public class DatabaseGS_Provaider : IGS_Provaider
{
     private readonly GS_DbContextFactory _DbContextFactory;

     public DatabaseGS_Provaider(GS_DbContextFactory dbContextFactory)
     {
          _DbContextFactory = dbContextFactory;
     }

     public async Task<IEnumerable<GS_Goods>> GetAllGoods()
     {
          using (GS_DbContext context = _DbContextFactory.CreateDbContext())
          {
               IEnumerable<DTO_GS_Goods> goodsDTOs = await context.Goods.ToListAsync();

               return goodsDTOs.Select(r => ToGS_Goods(r));
          }
     }

     private GS_Goods ToGS_Goods(DTO_GS_Goods r)
     {
          return new GS_Goods(new GS_Category(r.Name), r.Name);
     }
}