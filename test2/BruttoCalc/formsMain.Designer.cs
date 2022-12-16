namespace BruttoCalc {
    partial class q {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(q));
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelTaxAmount = new System.Windows.Forms.Label();
            this.labelNetAmount = new System.Windows.Forms.Label();
            this.textTotalAmount = new System.Windows.Forms.TextBox();
            this.textTaxAmount = new System.Windows.Forms.TextBox();
            this.textNetAmount = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalAmount.Font = new System.Drawing.Font("Get Schwifty", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.Location = new System.Drawing.Point(12, 9);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(171, 23);
            this.labelTotalAmount.TabIndex = 3;
            this.labelTotalAmount.Text = "Bruttobetrag eingeben";
            // 
            // labelTaxAmount
            // 
            this.labelTaxAmount.AutoSize = true;
            this.labelTaxAmount.Location = new System.Drawing.Point(12, 62);
            this.labelTaxAmount.Name = "labelTaxAmount";
            this.labelTaxAmount.Size = new System.Drawing.Size(55, 13);
            this.labelTaxAmount.TabIndex = 0;
            this.labelTaxAmount.Text = "- Steuer %";
            // 
            // labelNetAmount
            // 
            this.labelNetAmount.AutoSize = true;
            this.labelNetAmount.Location = new System.Drawing.Point(12, 120);
            this.labelNetAmount.Name = "labelNetAmount";
            this.labelNetAmount.Size = new System.Drawing.Size(33, 13);
            this.labelNetAmount.TabIndex = 0;
            this.labelNetAmount.Text = "Netto";
            // 
            // textTotalAmount
            // 
            this.textTotalAmount.Location = new System.Drawing.Point(12, 39);
            this.textTotalAmount.Name = "textTotalAmount";
            this.textTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.textTotalAmount.TabIndex = 0;
            // 
            // textTaxAmount
            // 
            this.textTaxAmount.Location = new System.Drawing.Point(15, 78);
            this.textTaxAmount.Name = "textTaxAmount";
            this.textTaxAmount.Size = new System.Drawing.Size(100, 20);
            this.textTaxAmount.TabIndex = 1;
            // 
            // textNetAmount
            // 
            this.textNetAmount.Enabled = false;
            this.textNetAmount.Location = new System.Drawing.Point(15, 136);
            this.textNetAmount.Name = "textNetAmount";
            this.textNetAmount.Size = new System.Drawing.Size(100, 20);
            this.textNetAmount.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(15, 181);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Berechnen";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(96, 181);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(121, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Neue Berechnung";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(223, 181);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Beenden";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // q
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textNetAmount);
            this.Controls.Add(this.textTaxAmount);
            this.Controls.Add(this.textTotalAmount);
            this.Controls.Add(this.labelNetAmount);
            this.Controls.Add(this.labelTaxAmount);
            this.Controls.Add(this.labelTotalAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "q";
            this.Text = "Netto-Rechner";
            this.Load += new System.EventHandler(this.formsMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelTaxAmount;
        private System.Windows.Forms.Label labelNetAmount;
        private System.Windows.Forms.TextBox textTotalAmount;
        private System.Windows.Forms.TextBox textTaxAmount;
        private System.Windows.Forms.TextBox textNetAmount;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
    }
}

