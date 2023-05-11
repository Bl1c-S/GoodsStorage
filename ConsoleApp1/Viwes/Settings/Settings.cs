﻿using BusinessLogic_GS.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_GS.Settings;

public class Settings : DTOSettings
{
     public Settings()
     {
          DTOSettings settings = CheckSetting();
          this.FilePathSettings = settings.FilePathSettings;
          this.GoodsTypeDirectoriFilePath = settings.GoodsTypeDirectoriFilePath;
          this.GoodsStorageDirectoriFilePath = settings.GoodsStorageDirectoriFilePath;
     }
}
