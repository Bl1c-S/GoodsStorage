using BusinessLogic_GS.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_GoodsStorage.DbContexts
{
     public class GS_DbContextFactory
     {
          private readonly string _connectionString;

          public GS_DbContextFactory(string connectionString)
          {
               _connectionString = connectionString;
          }

          public GS_DbContext CreateDbContext(string[] args)
          {
               DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Sourse=GoodsStorage.db").Options;

               return new GS_DbContext(options);
          }
     }
}
