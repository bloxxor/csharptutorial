using System.Windows.Forms;

namespace Gehalt {
    partial class formMain {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.labelListe = new System.Windows.Forms.Label();
            this.groupBoxAddPerson = new System.Windows.Forms.GroupBox();
            this.buttonHinzufuegen = new System.Windows.Forms.Button();
            this.labelGehalt = new System.Windows.Forms.Label();
            this.labelAlter = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxGehalt = new System.Windows.Forms.TextBox();
            this.textBoxAlter = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listViewPersons = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAlter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGehalt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxStatistik = new System.Windows.Forms.GroupBox();
            this.textBoxGehaltDurchschnitt = new System.Windows.Forms.TextBox();
            this.textBoxAlterDurchschnitt = new System.Windows.Forms.TextBox();
            this.textBoxAnzahl = new System.Windows.Forms.TextBox();
            this.labelGehaltDurchschnitt = new System.Windows.Forms.Label();
            this.labelAlterDurchschnitt = new System.Windows.Forms.Label();
            this.labelAnzahl = new System.Windows.Forms.Label();
            this.groupBoxSortierung = new System.Windows.Forms.GroupBox();
            this.radioButtonSortGehalt = new System.Windows.Forms.RadioButton();
            this.radioButtonSortAlter = new System.Windows.Forms.RadioButton();
            this.radioButtonSortName = new System.Windows.Forms.RadioButton();
            this.radioButtonUnsortiert = new System.Windows.Forms.RadioButton();
            this.groupBoxAddPerson.SuspendLayout();
            this.groupBoxStatistik.SuspendLayout();
            this.groupBoxSortierung.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelListe
            // 
            this.labelListe.AutoSize = true;
            this.labelListe.Location = new System.Drawing.Point(12, 9);
            this.labelListe.Name = "labelListe";
            this.labelListe.Size = new System.Drawing.Size(166, 13);
            this.labelListe.TabIndex = 0;
            this.labelListe.Text = "Liste der eingegebenen Personen";
            // 
            // groupBoxAddPerson
            // 
            this.groupBoxAddPerson.Controls.Add(this.buttonHinzufuegen);
            this.groupBoxAddPerson.Controls.Add(this.labelGehalt);
            this.groupBoxAddPerson.Controls.Add(this.labelAlter);
            this.groupBoxAddPerson.Controls.Add(this.labelName);
            this.groupBoxAddPerson.Controls.Add(this.textBoxGehalt);
            this.groupBoxAddPerson.Controls.Add(this.textBoxAlter);
            this.groupBoxAddPerson.Controls.Add(this.textBoxName);
            this.groupBoxAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddPerson.Location = new System.Drawing.Point(430, 177);
            this.groupBoxAddPerson.Name = "groupBoxAddPerson";
            this.groupBoxAddPerson.Size = new System.Drawing.Size(358, 173);
            this.groupBoxAddPerson.TabIndex = 1;
            this.groupBoxAddPerson.TabStop = false;
            this.groupBoxAddPerson.Text = "Personeneingabe";
            // 
            // buttonHinzufuegen
            // 
            this.buttonHinzufuegen.Location = new System.Drawing.Point(264, 117);
            this.buttonHinzufuegen.Name = "buttonHinzufuegen";
            this.buttonHinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.buttonHinzufuegen.TabIndex = 3;
            this.buttonHinzufuegen.Text = "Hinzufügen";
            this.buttonHinzufuegen.UseVisualStyleBackColor = true;
            this.buttonHinzufuegen.Click += new System.EventHandler(this.buttonHinzufuegen_Click);
            // 
            // labelGehalt
            // 
            this.labelGehalt.AutoSize = true;
            this.labelGehalt.Location = new System.Drawing.Point(6, 89);
            this.labelGehalt.Name = "labelGehalt";
            this.labelGehalt.Size = new System.Drawing.Size(38, 13);
            this.labelGehalt.TabIndex = 1;
            this.labelGehalt.Text = "Gehalt";
            // 
            // labelAlter
            // 
            this.labelAlter.AutoSize = true;
            this.labelAlter.Location = new System.Drawing.Point(6, 61);
            this.labelAlter.Name = "labelAlter";
            this.labelAlter.Size = new System.Drawing.Size(28, 13);
            this.labelAlter.TabIndex = 1;
            this.labelAlter.Text = "Alter";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textBoxGehalt
            // 
            this.textBoxGehalt.Location = new System.Drawing.Point(73, 89);
            this.textBoxGehalt.Name = "textBoxGehalt";
            this.textBoxGehalt.Size = new System.Drawing.Size(266, 20);
            this.textBoxGehalt.TabIndex = 2;
            // 
            // textBoxAlter
            // 
            this.textBoxAlter.Location = new System.Drawing.Point(73, 61);
            this.textBoxAlter.Name = "textBoxAlter";
            this.textBoxAlter.Size = new System.Drawing.Size(266, 20);
            this.textBoxAlter.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(73, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(266, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // listViewPersons
            // 
            this.listViewPersons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName,
            this.columnHeaderAlter,
            this.columnHeaderGehalt});
            this.listViewPersons.GridLines = true;
            this.listViewPersons.HideSelection = false;
            this.listViewPersons.Location = new System.Drawing.Point(15, 25);
            this.listViewPersons.Name = "listViewPersons";
            this.listViewPersons.Size = new System.Drawing.Size(773, 146);
            this.listViewPersons.TabIndex = 2;
            this.listViewPersons.UseCompatibleStateImageBehavior = false;
            this.listViewPersons.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            // 
            // columnHeaderAlter
            // 
            this.columnHeaderAlter.Text = "Alter";
            // 
            // columnHeaderGehalt
            // 
            this.columnHeaderGehalt.Text = "Gehalt";
            // 
            // groupBoxStatistik
            // 
            this.groupBoxStatistik.Controls.Add(this.textBoxGehaltDurchschnitt);
            this.groupBoxStatistik.Controls.Add(this.textBoxAlterDurchschnitt);
            this.groupBoxStatistik.Controls.Add(this.textBoxAnzahl);
            this.groupBoxStatistik.Controls.Add(this.labelGehaltDurchschnitt);
            this.groupBoxStatistik.Controls.Add(this.labelAlterDurchschnitt);
            this.groupBoxStatistik.Controls.Add(this.labelAnzahl);
            this.groupBoxStatistik.Location = new System.Drawing.Point(15, 177);
            this.groupBoxStatistik.Name = "groupBoxStatistik";
            this.groupBoxStatistik.Size = new System.Drawing.Size(246, 173);
            this.groupBoxStatistik.TabIndex = 1;
            this.groupBoxStatistik.TabStop = false;
            this.groupBoxStatistik.Text = "Statistik";
            // 
            // textBoxGehaltDurchschnitt
            // 
            this.textBoxGehaltDurchschnitt.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxGehaltDurchschnitt.Enabled = false;
            this.textBoxGehaltDurchschnitt.Location = new System.Drawing.Point(131, 92);
            this.textBoxGehaltDurchschnitt.Name = "textBoxGehaltDurchschnitt";
            this.textBoxGehaltDurchschnitt.Size = new System.Drawing.Size(100, 20);
            this.textBoxGehaltDurchschnitt.TabIndex = 1;
            // 
            // textBoxAlterDurchschnitt
            // 
            this.textBoxAlterDurchschnitt.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxAlterDurchschnitt.Enabled = false;
            this.textBoxAlterDurchschnitt.Location = new System.Drawing.Point(131, 59);
            this.textBoxAlterDurchschnitt.Name = "textBoxAlterDurchschnitt";
            this.textBoxAlterDurchschnitt.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlterDurchschnitt.TabIndex = 1;
            // 
            // textBoxAnzahl
            // 
            this.textBoxAnzahl.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxAnzahl.Enabled = false;
            this.textBoxAnzahl.Location = new System.Drawing.Point(131, 28);
            this.textBoxAnzahl.Name = "textBoxAnzahl";
            this.textBoxAnzahl.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnzahl.TabIndex = 1;
            // 
            // labelGehaltDurchschnitt
            // 
            this.labelGehaltDurchschnitt.AutoSize = true;
            this.labelGehaltDurchschnitt.Location = new System.Drawing.Point(6, 99);
            this.labelGehaltDurchschnitt.Name = "labelGehaltDurchschnitt";
            this.labelGehaltDurchschnitt.Size = new System.Drawing.Size(83, 13);
            this.labelGehaltDurchschnitt.TabIndex = 0;
            this.labelGehaltDurchschnitt.Text = "Mittleres Gehalt:";
            // 
            // labelAlterDurchschnitt
            // 
            this.labelAlterDurchschnitt.AutoSize = true;
            this.labelAlterDurchschnitt.Location = new System.Drawing.Point(6, 62);
            this.labelAlterDurchschnitt.Name = "labelAlterDurchschnitt";
            this.labelAlterDurchschnitt.Size = new System.Drawing.Size(73, 13);
            this.labelAlterDurchschnitt.TabIndex = 0;
            this.labelAlterDurchschnitt.Text = "Mittleres Alter:";
            // 
            // labelAnzahl
            // 
            this.labelAnzahl.AutoSize = true;
            this.labelAnzahl.Location = new System.Drawing.Point(6, 31);
            this.labelAnzahl.Name = "labelAnzahl";
            this.labelAnzahl.Size = new System.Drawing.Size(108, 13);
            this.labelAnzahl.TabIndex = 0;
            this.labelAnzahl.Text = "Anzahl der Personen:";
            // 
            // groupBoxSortierung
            // 
            this.groupBoxSortierung.Controls.Add(this.radioButtonSortGehalt);
            this.groupBoxSortierung.Controls.Add(this.radioButtonSortAlter);
            this.groupBoxSortierung.Controls.Add(this.radioButtonSortName);
            this.groupBoxSortierung.Controls.Add(this.radioButtonUnsortiert);
            this.groupBoxSortierung.Location = new System.Drawing.Point(271, 177);
            this.groupBoxSortierung.Name = "groupBoxSortierung";
            this.groupBoxSortierung.Size = new System.Drawing.Size(153, 173);
            this.groupBoxSortierung.TabIndex = 3;
            this.groupBoxSortierung.TabStop = false;
            this.groupBoxSortierung.Text = "Sortierung";
            // 
            // radioButtonSortGehalt
            // 
            this.radioButtonSortGehalt.AutoSize = true;
            this.radioButtonSortGehalt.Location = new System.Drawing.Point(9, 88);
            this.radioButtonSortGehalt.Name = "radioButtonSortGehalt";
            this.radioButtonSortGehalt.Size = new System.Drawing.Size(83, 17);
            this.radioButtonSortGehalt.TabIndex = 1;
            this.radioButtonSortGehalt.Text = "nach Gehalt";
            this.radioButtonSortGehalt.UseVisualStyleBackColor = true;
            this.radioButtonSortGehalt.CheckedChanged += new System.EventHandler(this.radioButtonSort_CheckedChanged);
            // 
            // radioButtonSortAlter
            // 
            this.radioButtonSortAlter.AutoSize = true;
            this.radioButtonSortAlter.Location = new System.Drawing.Point(9, 65);
            this.radioButtonSortAlter.Name = "radioButtonSortAlter";
            this.radioButtonSortAlter.Size = new System.Drawing.Size(73, 17);
            this.radioButtonSortAlter.TabIndex = 1;
            this.radioButtonSortAlter.Text = "nach Alter";
            this.radioButtonSortAlter.UseVisualStyleBackColor = true;
            this.radioButtonSortAlter.CheckedChanged += new System.EventHandler(this.radioButtonSort_CheckedChanged);
            // 
            // radioButtonSortName
            // 
            this.radioButtonSortName.AutoSize = true;
            this.radioButtonSortName.Location = new System.Drawing.Point(9, 42);
            this.radioButtonSortName.Name = "radioButtonSortName";
            this.radioButtonSortName.Size = new System.Drawing.Size(80, 17);
            this.radioButtonSortName.TabIndex = 1;
            this.radioButtonSortName.Text = "nach Name";
            this.radioButtonSortName.UseVisualStyleBackColor = true;
            this.radioButtonSortName.CheckedChanged += new System.EventHandler(this.radioButtonSort_CheckedChanged);
            // 
            // radioButtonUnsortiert
            // 
            this.radioButtonUnsortiert.AutoSize = true;
            this.radioButtonUnsortiert.Checked = true;
            this.radioButtonUnsortiert.Location = new System.Drawing.Point(9, 19);
            this.radioButtonUnsortiert.Name = "radioButtonUnsortiert";
            this.radioButtonUnsortiert.Size = new System.Drawing.Size(70, 17);
            this.radioButtonUnsortiert.TabIndex = 0;
            this.radioButtonUnsortiert.TabStop = true;
            this.radioButtonUnsortiert.Text = "Unsortiert";
            this.radioButtonUnsortiert.UseVisualStyleBackColor = true;
            this.radioButtonUnsortiert.CheckedChanged += new System.EventHandler(this.radioButtonSort_CheckedChanged);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.groupBoxSortierung);
            this.Controls.Add(this.listViewPersons);
            this.Controls.Add(this.groupBoxStatistik);
            this.Controls.Add(this.groupBoxAddPerson);
            this.Controls.Add(this.labelListe);
            this.Name = "formMain";
            this.Text = "Gehaltsverzeichnis";
            this.groupBoxAddPerson.ResumeLayout(false);
            this.groupBoxAddPerson.PerformLayout();
            this.groupBoxStatistik.ResumeLayout(false);
            this.groupBoxStatistik.PerformLayout();
            this.groupBoxSortierung.ResumeLayout(false);
            this.groupBoxSortierung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListe;
        private System.Windows.Forms.GroupBox groupBoxAddPerson;
        private System.Windows.Forms.ListView listViewPersons;
        private System.Windows.Forms.GroupBox groupBoxStatistik;
        private System.Windows.Forms.Label labelGehaltDurchschnitt;
        private System.Windows.Forms.Label labelAlterDurchschnitt;
        private System.Windows.Forms.Label labelAnzahl;
        private System.Windows.Forms.TextBox textBoxGehaltDurchschnitt;
        private System.Windows.Forms.TextBox textBoxAlterDurchschnitt;
        private System.Windows.Forms.TextBox textBoxAnzahl;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelGehalt;
        private System.Windows.Forms.Label labelAlter;
        private System.Windows.Forms.TextBox textBoxGehalt;
        private System.Windows.Forms.TextBox textBoxAlter;
        private System.Windows.Forms.GroupBox groupBoxSortierung;
        private System.Windows.Forms.Button buttonHinzufuegen;
        private System.Windows.Forms.RadioButton radioButtonSortName;
        private System.Windows.Forms.RadioButton radioButtonUnsortiert;
        private System.Windows.Forms.RadioButton radioButtonSortGehalt;
        private System.Windows.Forms.RadioButton radioButtonSortAlter;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderAlter;
        private System.Windows.Forms.ColumnHeader columnHeaderGehalt;
    }
}

