using System;

using c = System.Console;

namespace prjKreisberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int intFalse = 0;
            double radius;


            do
            {

                c.WriteLine("Radius eingeben (cm): ");
                radius = Double.Parse(c.ReadLine());

                if (intFalse >= 3)
                {
                    c.Clear();
                    c.WriteLine("Nur positive Zahlen!\nTschau!");
                    c.ReadKey();
                    Environment.Exit(0);
                }

                c.Clear();
                intFalse++;

            } while (radius <= 0);

            c.WriteLine("Umfang ist: {0:F2}cm", Kreisberechnung.berechneUmfang(radius));
            c.WriteLine("Durchmesser ist: {0:F2}cm", Kreisberechnung.berechneDurchmesser(radius));
            c.WriteLine("Fläche ist: {0:F2}cm²", Kreisberechnung.berechneFlaeche(radius));

            c.ReadKey();

        }
    }
}
