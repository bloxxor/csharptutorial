using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Gehalt {
    public class Person {

        // Nummerierung startet bei 1, nicht bei 0
        private static int idAutowert = 1;

        private int Id;
        private string Name;
        private int Alter;
        private int Gehalt;

        public Person( string name, int alter, int gehalt) {
            Id = idAutowert;
            Name = name;
            Alter = alter;
            Gehalt = gehalt;
            idAutowert++;
        }

        public int id { get => Id; set => Id = value; }
        public string name { get => Name; set => Name = value; }
        public int alter { get => Alter; set => Alter = value; }
        public int gehalt { get => Gehalt; set => Gehalt = value; }

    }
}
