using System; // Direktive, binden Libraries ein
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using c = System.Console; // Aliasname, wird in der Praxis eher nicht erwünscht!!!!!!!!!!!!!

namespace prjWaehrungsrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // lokale Variablen
            double dblKurs, dblEuro, dblWhrg;

            c.WriteLine("Wir rechnen eine beliebige Währung in den Euro um!\n");

            c.WriteLine("Bitte den Umrechnungskurs eingeben: ");
            dblKurs = Convert.ToDouble(c.ReadLine());  // std.-input stream von der Konsole

            c.WriteLine("Bitte den Umrechnungsbetrag eingeben: ");
            dblWhrg = Convert.ToDouble(c.ReadLine());  // std.-input stream von der Konsole

            // Berechnung
            dblEuro = dblWhrg / dblKurs;
            c.WriteLine("Sie erhalten " + dblEuro.ToString("0.00 Euro"));

            // Warte auf Tastendruck
            c.ReadKey();

        }   
    }
}
