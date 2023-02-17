using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_Apteca.Models;

public class ModelBase
{
    public string FilePath = string.Empty;
    public string Expansion = string.Empty;
    public Guid Id;
    public ModelBase()
    {
        Id = Guid.NewGuid();
    }
}
