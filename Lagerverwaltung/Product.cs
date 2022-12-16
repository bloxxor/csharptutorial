using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory {
    public class Product {

        private int Art_id;
        private int Art_nr;
        private string Name;
        private double Price;
        private double Category_ID;
        private double Category_name;
        private double Purchase_Price;

        public int art_id { get => Art_id; set => Art_id = value; }
        public int art_nr { get => Art_nr; set => Art_nr = value; }
        public string name { get => Name; set => Name = value; }
        public double price { get => Price; set => Price = value; }
        public double category_ID { get => Category_ID; set => Category_ID = value; }
        public double category_name { get => Category_name; set => Category_name = value; }
        public double purchase_Price { get => Purchase_Price; set => Purchase_Price = value; }

        public DataTable fetchData() {

            DataTable dataTable = DatabaseAccess.ExecuteTable(
                "uspInventory",
                new SqlParameter("@action", "fetchAll"),
                new SqlParameter("@art_id", art_id),
                new SqlParameter("@art_name", name),
                new SqlParameter("@price", price),
                new SqlParameter("@category_ID", category_ID),
                new SqlParameter("@category_name", category_name),
                new SqlParameter("@purchase_price", purchase_Price),
                new SqlParameter("@warehouse_location", "warehouse_location"),
                new SqlParameter("@warehouse_name", "warehouse_name")
            );

            return dataTable;

        }

    }
}
