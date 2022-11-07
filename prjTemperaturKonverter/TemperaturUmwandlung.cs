using System;

namespace prjTemperaturKonverter
{
    public static class TemperaturUmwandlung
    {
        public static double getCelToFahr(string strCel)
        {
            double dblCel = Double.Parse(strCel);
            double dblFahr = (dblCel * 9 / 5) + 32;
            return dblFahr;
        }

        public static double getFahrToCel(string strFahr)
        {
            double dblFahr = Double.Parse(strFahr);
            double dblCel = (dblFahr - 32) * 5 / 9;
            return dblCel;
        }
    }
}
