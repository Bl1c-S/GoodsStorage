using BusinessLogic_GS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_GS.DbContexts;

public class GS_DbContext : DbContext
{
     public GS_DbContext(DbContextOptions options) : base(options)
     {
     }

     public DbSet<GS_Goods> Goods { get; set; }
}
