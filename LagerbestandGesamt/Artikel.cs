using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerbestandGesamt {
    public class Artikel {

        private static int idAutowert = 1;

        private int Id;
        private int ArtikelNr;
        private string ArtikelName;
        private int ArtikelPreis;
        private int Lagerbestand;

        public Artikel( int artikelNr, string artikelName, int artikelPreis, int lagerbestand) {
            Id = idAutowert;
            ArtikelNr = artikelNr;
            ArtikelName = artikelName;
            ArtikelPreis = artikelPreis;
            Lagerbestand = lagerbestand;
            idAutowert++;
        }

        public int id { get => Id; set => Id = value; }
        public int artikelNr { get => ArtikelNr; set => ArtikelNr = value; }
        public string artikelName { get => ArtikelName; set => ArtikelName = value; }
        public int artikelPreis { get => ArtikelPreis; set => ArtikelPreis = value; }
        public int lagerbestand { get => Lagerbestand; set => Lagerbestand = value; }
    }
}
