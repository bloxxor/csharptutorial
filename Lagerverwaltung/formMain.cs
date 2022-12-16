using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory {
    public partial class formMain : Form {

        Product product = new Product();

        public formMain() {
            InitializeComponent();
        }

        private void buttonDebug_Click(object sender, EventArgs e) {

            DataTable data = DatabaseAccess.ExecuteTable(
                "uspInventory",
                new SqlParameter("@action", "fetchAll")
            );

            Console.WriteLine("Daten: " + data.Columns.Count);

        }

        private void formMain_Load(object sender, EventArgs e) {

            dataGridViewFetchAll.AutoGenerateColumns = false;
            this.dataGridViewFetchAll.AutoResizeColumns();
            dataGridViewFetchAll.DataSource = product.fetchData();

            // Warehouse fetchData & Merge?
            // https://stackoverflow.com/questions/285474/merge-2-datatables-and-store-in-a-new-one

            // Debug
            Console.WriteLine("Daten: " + dataGridViewFetchAll.DataSource.ToString());

        }
    }
}
