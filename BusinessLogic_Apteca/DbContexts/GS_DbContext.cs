using BusinessLogic_GS.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic_GS.DbContexts;

public class GS_DbContext : DbContext
{
     public GS_DbContext(DbContextOptions options) : base(options)
     {
     }

     public DbSet<DTO_GS_Goods> Goods { get; set; }
}
