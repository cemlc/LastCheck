﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCheck
{
    public static class Config
    {
        #region BibEntry ToString Config

        public static string Retract { get; private set; } = "  ";

        public static string LineFeed { get; private set; } = "\n";

        public static bool Align { get; private set; } = false;

        #endregion

        #region Public Static Method
        public static void Load()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
