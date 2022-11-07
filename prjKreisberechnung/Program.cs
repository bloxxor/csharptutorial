using System;

using c = System.Console;

namespace prjKreisberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {

            c.WriteLine("Radius eingeben (cm): ");
            double radius = Double.Parse(c.ReadLine());

            c.WriteLine("Umfang ist: {0:F2}cm", Kreisberechnung.berechneUmfang(radius));
            c.WriteLine("Durchmesser ist: {0:F2}cm", Kreisberechnung.berechneDurchmesser(radius));
            c.WriteLine("Fläche ist: {0:F2}cm²", Kreisberechnung.berechneFlaeche(radius));

            c.ReadKey();

        }
    }
}
