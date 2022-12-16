using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EmployeeManagement {
    public partial class formMain : Form {

        Employee employee = new Employee();
        string empID = "";

        public formMain() {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e) {

            // Prüfe ob alle Felder ausgefüllt
            if (string.IsNullOrWhiteSpace(textBoxEmployeeName.Text)) {
                MessageBox.Show(
                    "Enter a name",
                    "Error"
                );
                textBoxEmployeeName.Select();
            }
            else if (string.IsNullOrWhiteSpace(textBoxCurrentCity.Text)) {
                MessageBox.Show(
                    "Enter a City",
                    "Error"
                );
                textBoxEmployeeName.Select();
            }
            else if (string.IsNullOrWhiteSpace(textBoxDepartment.Text)) {
                MessageBox.Show(
                    "Enter a Department",
                    "Error"
                );
                textBoxEmployeeName.Select();
            }
            // Sonderfall ComboBox: Auf Selected Index prüfen
            else if (comboBoxGender.SelectedIndex <= -1) {
                MessageBox.Show(
                    "Enter a Gender",
                    "Error"
                );
                comboBoxGender.Select();
            } else {
                employee.name = textBoxEmployeeName.Text;
                employee.city = textBoxCurrentCity.Text;
                employee.department = textBoxDepartment.Text;
                employee.gender = comboBoxGender.Text;
            }

            try {
                employee.saveRecord();
                this.ClearData();
            } catch(Exception ex) {
                System.Console.WriteLine(ex.Message);
            }

        }

        private void ClearData() {
            this.buttonSave.Text = "Save";
            this.textBoxEmployeeName.Clear();
            this.textBoxCurrentCity.Clear();
            this.textBoxDepartment.Clear();
            // Clear Dropdown (ComboBox)
            this.comboBoxGender.SelectedIndex = -1;
            
            empID = "";

            this.dataGridViewEmployees.AutoGenerateColumns = false;
            this.dataGridViewEmployees.AutoResizeColumns();
            dataGridViewEmployees.DataSource = employee.fetchData();

        }
        private void buttonClear_Click(object sender, EventArgs e) {
            ClearData();
        }
        private void buttonDelete_Click(object sender, EventArgs e) {

            if(!string.IsNullOrEmpty(empID)) {
                try {
                    employee.deleteRecord(empID);
                    ClearData();
                } catch (Exception ex) {
                    MessageBox.Show("Error: ", ex.Message);
                }
            }
            else {
                MessageBox.Show("Select a record", "System Message");
            }
        }

        private void formMain_Load(object sender, EventArgs e) {
            dataGridViewEmployees.AutoGenerateColumns = false;
            this.dataGridViewEmployees.AutoResizeColumns();
            dataGridViewEmployees.DataSource = employee.fetchData();
        }

        private void dataGridViewEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {

                buttonSave.Text = "Update";
                empID = dataGridViewEmployees.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataTable dataTable = employee.fetchRecord(empID);

                if (dataTable.Rows.Count > 0) {
                    textBoxEmployeeName.Text = dataTable.Rows[0][0].ToString();
                    textBoxCurrentCity.Text = dataTable.Rows[0][1].ToString();
                    textBoxDepartment.Text = dataTable.Rows[0][2].ToString();
                    comboBoxGender.Text = dataTable.Rows[0][3].ToString();
                    employee.empID = empID;
                }
                else {
                    ClearData();
                }

            }
        }
    }
}
