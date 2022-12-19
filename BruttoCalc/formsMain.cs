using System;
using System.Windows.Forms;

namespace BruttoCalc {
    public partial class q : Form {
        public q() {
            InitializeComponent();
        }
        private void formsMain_Load(object sender, EventArgs e) {

        }

        private void buttonReset_Click(object sender, EventArgs e) {
            this.textTotalAmount.Clear();
            this.textTaxAmount.Clear();
            this.textNetAmount.Clear();
            this.textTotalAmount.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e) {

            DialogResult dialogResult = MessageBox.Show(
                "Brutto-Rechner beenden?",
                "Brutto Rechner",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes) {
                Application.Exit();
            }

        }

        private void buttonCalculate_Click(object sender, EventArgs e) {

            double totalAmount = 0, taxAmount = 0, netAmount = 0;

            if (double.TryParse(this.textTotalAmount.Text, out totalAmount)) {
                if (double.TryParse(this.textTaxAmount.Text, out taxAmount)) {
                    netAmount = totalAmount - ((taxAmount / 100) * totalAmount);
                    this.textNetAmount.Text = netAmount.ToString("N2") + " €";
                }
                else {
                    this.textTaxAmount.Text = null;
                    MessageBox.Show("Steuerwert ist ungültig!");
                    this.textTaxAmount.Focus();
                }
            }
            else {
                this.textTotalAmount.Text = null;
                MessageBox.Show("Bruttowert ist ungültig");
                this.textTotalAmount.Focus();
                    
            }

        }
    }
}
