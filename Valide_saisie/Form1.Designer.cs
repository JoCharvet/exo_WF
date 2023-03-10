namespace Valide_saisie
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblmontant = new System.Windows.Forms.Label();
            this.lblcode = new System.Windows.Forms.Label();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.txtBDate = new System.Windows.Forms.TextBox();
            this.txtBSum = new System.Windows.Forms.TextBox();
            this.txtBCP = new System.Windows.Forms.TextBox();
            this.lbltipdate = new System.Windows.Forms.Label();
            this.btnval = new System.Windows.Forms.Button();
            this.btneff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 71);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(34, 15);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(12, 106);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(31, 15);
            this.lbldate.TabIndex = 1;
            this.lbldate.Text = "Date";
            // 
            // lblmontant
            // 
            this.lblmontant.AutoSize = true;
            this.lblmontant.Location = new System.Drawing.Point(12, 139);
            this.lblmontant.Name = "lblmontant";
            this.lblmontant.Size = new System.Drawing.Size(53, 15);
            this.lblmontant.TabIndex = 2;
            this.lblmontant.Text = "Montant";
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Location = new System.Drawing.Point(12, 169);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(70, 15);
            this.lblcode.TabIndex = 3;
            this.lblcode.Text = "Code Postal";
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(105, 71);
            this.txtBName.Name = "txtBName";
            this.txtBName.PlaceholderText = "nom-composé";
            this.txtBName.Size = new System.Drawing.Size(248, 23);
            this.txtBName.TabIndex = 4;
            this.txtBName.Tag = "nom-composé 30 caracteres maximum";
            this.txtBName.Enter += new System.EventHandler(this.txtB_FocusON);
            this.txtBName.Leave += new System.EventHandler(this.txtB_FocusOff);
            // 
            // txtBDate
            // 
            this.txtBDate.Location = new System.Drawing.Point(105, 106);
            this.txtBDate.Name = "txtBDate";
            this.txtBDate.PlaceholderText = "26\\09\\2025";
            this.txtBDate.Size = new System.Drawing.Size(178, 23);
            this.txtBDate.TabIndex = 5;
            this.txtBDate.Tag = "24/05/2025";
            this.txtBDate.Enter += new System.EventHandler(this.txtB_FocusON);
            this.txtBDate.Leave += new System.EventHandler(this.txtB_FocusOff);
            // 
            // txtBSum
            // 
            this.txtBSum.Location = new System.Drawing.Point(105, 139);
            this.txtBSum.Name = "txtBSum";
            this.txtBSum.PlaceholderText = "1255,99";
            this.txtBSum.Size = new System.Drawing.Size(162, 23);
            this.txtBSum.TabIndex = 6;
            this.txtBSum.Tag = "1246.99 ";
            this.txtBSum.Enter += new System.EventHandler(this.txtB_FocusON);
            this.txtBSum.Leave += new System.EventHandler(this.txtB_FocusOff);
            // 
            // txtBCP
            // 
            this.txtBCP.Location = new System.Drawing.Point(105, 169);
            this.txtBCP.Name = "txtBCP";
            this.txtBCP.PlaceholderText = "68100 ";
            this.txtBCP.Size = new System.Drawing.Size(162, 23);
            this.txtBCP.TabIndex = 7;
            this.txtBCP.Tag = "";
            this.txtBCP.Enter += new System.EventHandler(this.txtB_FocusON);
            this.txtBCP.Leave += new System.EventHandler(this.txtB_FocusOff);
            // 
            // lbltipdate
            // 
            this.lbltipdate.AutoSize = true;
            this.lbltipdate.Location = new System.Drawing.Point(305, 110);
            this.lbltipdate.Name = "lbltipdate";
            this.lbltipdate.Size = new System.Drawing.Size(87, 15);
            this.lbltipdate.TabIndex = 8;
            this.lbltipdate.Text = "(JJ/MM/AAAA)";
            // 
            // btnval
            // 
            this.btnval.Enabled = false;
            this.btnval.Location = new System.Drawing.Point(318, 193);
            this.btnval.Name = "btnval";
            this.btnval.Size = new System.Drawing.Size(75, 23);
            this.btnval.TabIndex = 9;
            this.btnval.Text = "Valider";
            this.btnval.UseVisualStyleBackColor = true;
            this.btnval.Click += new System.EventHandler(this.btnval_Click);
            // 
            // btneff
            // 
            this.btneff.Location = new System.Drawing.Point(319, 223);
            this.btneff.Name = "btneff";
            this.btneff.Size = new System.Drawing.Size(75, 23);
            this.btneff.TabIndex = 10;
            this.btneff.Text = "Effacer";
            this.btneff.UseVisualStyleBackColor = true;
            this.btneff.Click += new System.EventHandler(this.btneff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 344);
            this.Controls.Add(this.btneff);
            this.Controls.Add(this.btnval);
            this.Controls.Add(this.lbltipdate);
            this.Controls.Add(this.txtBCP);
            this.Controls.Add(this.txtBSum);
            this.Controls.Add(this.txtBDate);
            this.Controls.Add(this.txtBName);
            this.Controls.Add(this.lblcode);
            this.Controls.Add(this.lblmontant);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblNom);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Les Contrôles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNom;
        private Label lbldate;
        private Label lblmontant;
        private Label lblcode;
        private TextBox txtBName;
        private TextBox txtBDate;
        private TextBox txtBSum;
        private TextBox txtBCP;
        private Label lbltipdate;
        private Button btnval;
        private Button btneff;
    }
}