﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HottaPiz.Infrastructure.Utilities.PathTools
{
    public static class PathGenerator
    {
        public static string GetPizzaImageAddress(string imageName)
        {
            return $"/images/{imageName}";
        }
    }
}
