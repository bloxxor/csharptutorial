using System;

using c = System.Console;

namespace prjTemperaturKonverter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            c.WriteLine("Auswahl Konvertierungstyp");
            c.WriteLine("C: Celsius > Fahrenheit");
            c.WriteLine("F: Fahrenheit > Celsius");
            c.Write(": ");

            string strSelection = c.ReadLine();
            double dblFahrenheit, dblCelsius;

            switch(strSelection.ToUpper())
            {
                case "C":
                    c.Write("Celsius-Wert eingeben: ");
                    dblFahrenheit = TemperaturUmwandlung.getCelToFahr(c.ReadLine());
                    c.WriteLine("Celsius nach Fahrenheit: {0:F2}°F", dblFahrenheit);
                    break;
                case "F":
                    c.Write("Fahrenheit-Wert eingeben: ");
                    dblCelsius = TemperaturUmwandlung.getFahrToCel(c.ReadLine());
                    c.WriteLine("Fahrenheit nach Celsius: {0:F2}°C", dblCelsius);
                    break;
                default:
                    c.WriteLine("Ungültige Eingabe!");
                    break;
            }

            c.ReadKey();

        }
    }
}
