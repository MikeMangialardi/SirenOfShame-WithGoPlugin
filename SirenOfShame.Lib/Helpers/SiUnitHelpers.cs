﻿namespace SirenOfShame.Lib.Helpers
{
    public static class SiUnitHelpers
    {
        public static string ToBinaryString(uint i)
        {
            if (i > 1024 * 1024 * 1024)
            {
                return (i / (1024 * 1024 * 1024.0)).ToString("#,##0.##") + " Gi";
            }
            if (i > 1024 * 1024)
            {
                return (i / (1024 * 1024.0)).ToString("#,##0.##") + " Mi";
            }
            if (i > 1024)
            {
                return (i / 1024.0).ToString("#,##0.##") + " Ki";
            }
            return i.ToString("#,##0.##");
        }
    }
}
