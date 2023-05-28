using Microsoft.EntityFrameworkCore;

namespace Console_UI.DbContexts
{
     public class GS_DbContextFactory
     {
          private readonly string _connectionString;

          public GS_DbContextFactory(string connectionString)
          {
               _connectionString = connectionString;
          }

          public GS_DbContext CreateDbContext()
          {
               DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Sourse=GoodsStorage.db").Options;

               return new GS_DbContext(options);
          }
     }
}
