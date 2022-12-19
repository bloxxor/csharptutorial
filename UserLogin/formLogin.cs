using Datenzugriff;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms.VisualStyles;

namespace UserLogin {
    public partial class loginForm : Form {
        public loginForm() {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e) {

            DialogResult dialogResult = MessageBox.Show(
                "Wirklich beenden?",
                "Info von der: " + this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes ) {
                Application.Exit();
            }

        }

        private void buttonLogin_Click(object sender, EventArgs e) {

            if(this.textUserName.Text == "") {
                MessageBox.Show(
                    "Bitte Benutzernamen eingeben!",
                    "Login-Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            if (this.textPassword.Text == "") {
                MessageBox.Show(
                    "Bitte Passwort eingeben!",
                    "Login-Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            try {

                DataTable dataTable = Datenbank.ExecuteTable(
                    "uspLogin",
                    new SqlParameter("@User", this.textUserName.Text),
                    new SqlParameter("@Password", this.textPassword.Text)

                );

                if(dataTable.Rows.Count == 1) {

                    MessageBox.Show(
                        "Willkommen " + this.textUserName.Text,
                        "Systemmeldung",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    new formMain().Show(this);
                    this.Hide();

                } else {

                    MessageBox.Show(
                        "Login fehlgeschlagen.",
                        "Zugriff verweigert",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );

                    this.textUserName.Clear();
                    this.textPassword.Clear();
                    this.textUserName.Focus();
                
                }

            }
            catch ( Exception ex) {

                MessageBox.Show(
                    ex.Message,
                    "Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            }

        }

        private void checkBoxViewPassword_CheckedChanged(object sender, EventArgs e) {
            if(checkBoxViewPassword.Checked == true) {
                textPassword.PasswordChar = '\0';
                // Auch möglich:
                // textPassword.PasswordChar = (char)(0);
            } else {
                textPassword.PasswordChar = '*';
            }
        }

        private void loginForm_Load(object sender, EventArgs e) {

            ToolTip toolTip = new ToolTip();

            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.textUserName, "Benutzernamen eingeben");
            toolTip.SetToolTip(this.textPassword, "Passwort eingeben");
            toolTip.SetToolTip(this.checkBoxViewPassword, "Passwort anzeigen");

        }
    }

}
