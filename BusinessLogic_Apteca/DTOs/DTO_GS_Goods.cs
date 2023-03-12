using BusinessLogic_GS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_GS.DTOs;

public class DTO_GS_Goods
{
     private List<string> _seryalNumbers;
     public int Count;
     public GS_GoodsType GoodsType;
}