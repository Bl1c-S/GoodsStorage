using BusinessLogic_GS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_GoodsStorage.Services
{
     public interface IGS_Provaider
     {
          Task<IEnumerable<GS_Goods>> GetAllGoods();
     }
}
