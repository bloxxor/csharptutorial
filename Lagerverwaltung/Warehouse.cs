using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory {
    internal class Warehouse {

        private int Warehouse_ID;
        private string Name;
        private string Location;

        public int warehouse_ID { get => Warehouse_ID; set => Warehouse_ID = value; }
        public string name { get => Name; set => Name = value; }
        public string location { get => Location; set => Location = value; }

    }
}
