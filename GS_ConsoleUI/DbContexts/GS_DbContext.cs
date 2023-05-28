using BusinessLogic_GS.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Console_UI.DbContexts;

public class GS_DbContext : DbContext
{
     public GS_DbContext(DbContextOptions options) : base(options)
     {
     }

     public DbSet<GoodsDTO> Goods { get; set; }
}
