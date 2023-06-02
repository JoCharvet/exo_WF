namespace ValidSaisie_Reprise
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAideDate = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtbNom = new System.Windows.Forms.TextBox();
            this.txtbDate = new System.Windows.Forms.TextBox();
            this.txtbMontant = new System.Windows.Forms.TextBox();
            this.txtbCP = new System.Windows.Forms.TextBox();
            this.btnValid = new System.Windows.Forms.Button();
            this.btnEffac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nom";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(43, 101);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblAideDate
            // 
            this.lblAideDate.AutoSize = true;
            this.lblAideDate.Location = new System.Drawing.Point(295, 101);
            this.lblAideDate.Name = "lblAideDate";
            this.lblAideDate.Size = new System.Drawing.Size(87, 15);
            this.lblAideDate.TabIndex = 2;
            this.lblAideDate.Text = "(JJ/MM/AAAA)";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(46, 143);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(53, 15);
            this.lblMontant.TabIndex = 3;
            this.lblMontant.Text = "Montant";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(46, 183);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(70, 15);
            this.lblCP.TabIndex = 4;
            this.lblCP.Text = "Code Postal";
            // 
            // txtbNom
            // 
            this.txtbNom.Location = new System.Drawing.Point(154, 56);
            this.txtbNom.Name = "txtbNom";
            this.txtbNom.Size = new System.Drawing.Size(124, 23);
            this.txtbNom.TabIndex = 5;
            // 
            // txtbDate
            // 
            this.txtbDate.Location = new System.Drawing.Point(154, 98);
            this.txtbDate.Name = "txtbDate";
            this.txtbDate.Size = new System.Drawing.Size(124, 23);
            this.txtbDate.TabIndex = 6;
            // 
            // txtbMontant
            // 
            this.txtbMontant.Location = new System.Drawing.Point(154, 140);
            this.txtbMontant.Name = "txtbMontant";
            this.txtbMontant.Size = new System.Drawing.Size(124, 23);
            this.txtbMontant.TabIndex = 7;
            // 
            // txtbCP
            // 
            this.txtbCP.Location = new System.Drawing.Point(154, 180);
            this.txtbCP.Name = "txtbCP";
            this.txtbCP.Size = new System.Drawing.Size(124, 23);
            this.txtbCP.TabIndex = 8;
            // 
            // btnValid
            // 
            this.btnValid.Location = new System.Drawing.Point(350, 175);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(75, 23);
            this.btnValid.TabIndex = 9;
            this.btnValid.Text = "Valider";
            this.btnValid.UseVisualStyleBackColor = true;
            // 
            // btnEffac
            // 
            this.btnEffac.Location = new System.Drawing.Point(350, 204);
            this.btnEffac.Name = "btnEffac";
            this.btnEffac.Size = new System.Drawing.Size(75, 23);
            this.btnEffac.TabIndex = 10;
            this.btnEffac.Text = "Effacer";
            this.btnEffac.UseVisualStyleBackColor = true;
            this.btnEffac.Click += new System.EventHandler(this.btnEffac_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 249);
            this.Controls.Add(this.btnEffac);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.txtbCP);
            this.Controls.Add(this.txtbMontant);
            this.Controls.Add(this.txtbDate);
            this.Controls.Add(this.txtbNom);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblAideDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Les contrôles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblDate;
        private Label lblAideDate;
        private Label lblMontant;
        private Label lblCP;
        private TextBox txtbNom;
        private TextBox txtbDate;
        private TextBox txtbMontant;
        private TextBox txtbCP;
        private Button btnValid;
        private Button btnEffac;
    }
}