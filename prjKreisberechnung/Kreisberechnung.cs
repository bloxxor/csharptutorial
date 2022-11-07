using System;

namespace prjKreisberechnung
{
    public class Kreisberechnung
    {

        public static double berechneUmfang(double kreisRadius)
        {
            return 2 * Math.PI * kreisRadius; // Umfang

        }
        public static double berechneDurchmesser(double kreisRadius)
        {
            return 2 * kreisRadius; // Durchmesser
        }
        public static double berechneFlaeche(double kreisRadius)
        {
            return Math.PI * kreisRadius * kreisRadius; // Fläche
        }
        
    }
}
