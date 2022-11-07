using System;

using c = System.Console;

namespace prjKreisberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {

            c.WriteLine("Radius eingeben: ");
            double radius = Double.Parse(c.ReadLine());
            c.WriteLine(radius);

            c.WriteLine("Umfang ist: {0:F2}", Kreisberechnung.berechneUmfang(radius));
            c.WriteLine("Durchmesser ist: {0:F2}", Kreisberechnung.berechneDurchmesser(radius));
            c.WriteLine("Fläche ist: {0:F2}", Kreisberechnung.berechneFlaeche(radius));

            c.ReadKey();

        }
    }
}
