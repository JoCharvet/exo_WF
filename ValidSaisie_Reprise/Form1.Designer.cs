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
            lblName = new Label();
            lblDate = new Label();
            lblAideDate = new Label();
            lblMontant = new Label();
            lblCP = new Label();
            txtbNom = new TextBox();
            txtbDate = new TextBox();
            txtbMontant = new TextBox();
            txtbCP = new TextBox();
            btnValid = new Button();
            btnEffac = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(43, 59);
            lblName.Name = "lblName";
            lblName.Size = new Size(34, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nom";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(43, 101);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            // 
            // lblAideDate
            // 
            lblAideDate.AutoSize = true;
            lblAideDate.Location = new Point(295, 101);
            lblAideDate.Name = "lblAideDate";
            lblAideDate.Size = new Size(87, 15);
            lblAideDate.TabIndex = 2;
            lblAideDate.Text = "(JJ/MM/AAAA)";
            // 
            // lblMontant
            // 
            lblMontant.AutoSize = true;
            lblMontant.Location = new Point(46, 143);
            lblMontant.Name = "lblMontant";
            lblMontant.Size = new Size(53, 15);
            lblMontant.TabIndex = 3;
            lblMontant.Text = "Montant";
            // 
            // lblCP
            // 
            lblCP.AutoSize = true;
            lblCP.Location = new Point(46, 183);
            lblCP.Name = "lblCP";
            lblCP.Size = new Size(70, 15);
            lblCP.TabIndex = 4;
            lblCP.Text = "Code Postal";
            // 
            // txtbNom
            // 
            txtbNom.Location = new Point(154, 56);
            txtbNom.Name = "txtbNom";
            txtbNom.Size = new Size(124, 23);
            txtbNom.TabIndex = 5;
            // 
            // txtbDate
            // 
            txtbDate.Location = new Point(154, 98);
            txtbDate.Name = "txtbDate";
            txtbDate.Size = new Size(124, 23);
            txtbDate.TabIndex = 6;
            // 
            // txtbMontant
            // 
            txtbMontant.Location = new Point(154, 140);
            txtbMontant.Name = "txtbMontant";
            txtbMontant.Size = new Size(124, 23);
            txtbMontant.TabIndex = 7;
            // 
            // txtbCP
            // 
            txtbCP.Location = new Point(154, 180);
            txtbCP.Name = "txtbCP";
            txtbCP.Size = new Size(124, 23);
            txtbCP.TabIndex = 8;
            txtbCP.Leave += txtb_Leave;
            // 
            // btnValid
            // 
            btnValid.Enabled = false;
            btnValid.Location = new Point(350, 175);
            btnValid.Name = "btnValid";
            btnValid.Size = new Size(75, 23);
            btnValid.TabIndex = 9;
            btnValid.Text = "Valider";
            btnValid.UseVisualStyleBackColor = true;
            // 
            // btnEffac
            // 
            btnEffac.Location = new Point(350, 204);
            btnEffac.Name = "btnEffac";
            btnEffac.Size = new Size(75, 23);
            btnEffac.TabIndex = 10;
            btnEffac.Text = "Effacer";
            btnEffac.UseVisualStyleBackColor = true;
            btnEffac.Click += btnEffac_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 249);
            Controls.Add(btnEffac);
            Controls.Add(btnValid);
            Controls.Add(txtbCP);
            Controls.Add(txtbMontant);
            Controls.Add(txtbDate);
            Controls.Add(txtbNom);
            Controls.Add(lblCP);
            Controls.Add(lblMontant);
            Controls.Add(lblAideDate);
            Controls.Add(lblDate);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Les contrôles";
            ResumeLayout(false);
            PerformLayout();
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