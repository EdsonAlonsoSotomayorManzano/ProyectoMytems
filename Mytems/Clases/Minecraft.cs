﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace Mytems.Clases
{
    class Minecraft
    {
        [PrimaryKey, AutoIncrement]
        public string objectName { get; set; }
        public string ObjectColor { get; set; }
        public string price { get; set; }
        public Object Image { get; set; }

        public override string ToString()
        {
            return $"{objectName}-{ObjectColor}-{price}-{Image}";
        }

    }
}