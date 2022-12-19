using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausur {
    public class Kunde {

        public int Id;
        public string Name;
        public string Lastname;
        public int Plz;
        public string Stadt;
        public string Strasse;

        public Kunde(int id, string name, string lastname, int plz, string stadt, string strasse) { 
            Id = id;
            Name = name;
            Lastname = lastname;
            Plz = plz;
            Stadt = stadt;
            Strasse = strasse;
        }

        public int id { get => Id; set => Id = value; }
        public string name { get => Name; set => Name = value; }
        public string lastname { get => Lastname; set => Lastname = value; }
        public string stadt { get => Stadt; set => Stadt = value; }
        public int plz { get => Plz; set => Plz = value; }
        public string strasse { get => Strasse; set => Strasse = value;}

    }
}
