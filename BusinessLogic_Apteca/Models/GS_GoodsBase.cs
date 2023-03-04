using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_GS.Models;

public class GS_GoodsBase
{
    public Guid Id;
    public GS_GoodsBase()
    {
        Id = Guid.NewGuid();
    }
}
