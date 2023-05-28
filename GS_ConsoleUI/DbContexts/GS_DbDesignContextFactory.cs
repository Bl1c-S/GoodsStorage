using Console_UI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Console_UI.DbContexts;

public class GS_DbDesignContextFactory : IDesignTimeDbContextFactory<GS_DbContext>
{
     public GS_DbContext CreateDbContext(string[] args)
     {
          DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Sourse=GoodsStorage.db").Options;

          return new GS_DbContext(options);
     }
}