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
            this.lblNom.Location = new System.Drawing.Point(17, 118);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(52, 25);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(17, 177);
            this.lbldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(49, 25);
            this.lbldate.TabIndex = 1;
            this.lbldate.Text = "Date";
            // 
            // lblmontant
            // 
            this.lblmontant.AutoSize = true;
            this.lblmontant.Location = new System.Drawing.Point(17, 232);
            this.lblmontant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmontant.Name = "lblmontant";
            this.lblmontant.Size = new System.Drawing.Size(80, 25);
            this.lblmontant.TabIndex = 2;
            this.lblmontant.Text = "Montant";
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Location = new System.Drawing.Point(17, 282);
            this.lblcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(106, 25);
            this.lblcode.TabIndex = 3;
            this.lblcode.Text = "Code Postal";
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(150, 118);
            this.txtBName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBName.Name = "txtBName";
            this.txtBName.PlaceholderText = "nom-composé";
            this.txtBName.Size = new System.Drawing.Size(352, 31);
            this.txtBName.TabIndex = 4;
            this.txtBName.Tag = "nom-composé 30 caracteres maximum";
            this.txtBName.Enter += new System.EventHandler(this.txtB_FocusON);
            this.txtBName.Leave += new System.EventHandler(this.txtB_FocusOff);
            // 
            // txtBDate
            // 
            this.txtBDate.Location = new System.Drawing.Point(150, 177);
            this.txtBDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBDate.Name = "txtBDate";
            this.txtBDate.PlaceholderText = "26\\09\\2025";
            this.txtBDate.Size = new System.Drawing.Size(253, 31);
            this.txtBDate.TabIndex = 5;
            this.txtBDate.Tag = "24/05/2025";
            this.txtBDate.Enter += new System.EventHandler(this.txtB_FocusON);
            this.txtBDate.Leave += new System.EventHandler(this.txtB_FocusOff);
            // 
            // txtBSum
            // 
            this.txtBSum.Location = new System.Drawing.Point(150, 232);
            this.txtBSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBSum.Name = "txtBSum";
            this.txtBSum.PlaceholderText = "1,255,99";
            this.txtBSum.Size = new System.Drawing.Size(230, 31);
            this.txtBSum.TabIndex = 6;
            this.txtBSum.Tag = "1,246.99 ";
            this.txtBSum.Enter += new System.EventHandler(this.txtB_FocusON);
            this.txtBSum.Leave += new System.EventHandler(this.txtB_FocusOff);
            // 
            // txtBCP
            // 
            this.txtBCP.Location = new System.Drawing.Point(150, 282);
            this.txtBCP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBCP.Name = "txtBCP";
            this.txtBCP.PlaceholderText = "68100 ";
            this.txtBCP.Size = new System.Drawing.Size(230, 31);
            this.txtBCP.TabIndex = 7;
            this.txtBCP.Tag = "";
            this.txtBCP.Enter += new System.EventHandler(this.txtB_FocusON);
            this.txtBCP.Leave += new System.EventHandler(this.txtB_FocusOff);
            // 
            // lbltipdate
            // 
            this.lbltipdate.AutoSize = true;
            this.lbltipdate.Location = new System.Drawing.Point(436, 183);
            this.lbltipdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipdate.Name = "lbltipdate";
            this.lbltipdate.Size = new System.Drawing.Size(127, 25);
            this.lbltipdate.TabIndex = 8;
            this.lbltipdate.Text = "(JJ/MM/AAAA)";
            // 
            // btnval
            // 
            this.btnval.Location = new System.Drawing.Point(454, 322);
            this.btnval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnval.Name = "btnval";
            this.btnval.Size = new System.Drawing.Size(107, 38);
            this.btnval.TabIndex = 9;
            this.btnval.Text = "Valider";
            this.btnval.UseVisualStyleBackColor = true;
            this.btnval.Click += new System.EventHandler(this.btnval_Click);
            // 
            // btneff
            // 
            this.btneff.Location = new System.Drawing.Point(456, 372);
            this.btneff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneff.Name = "btneff";
            this.btneff.Size = new System.Drawing.Size(107, 38);
            this.btneff.TabIndex = 10;
            this.btneff.Text = "Effacer";
            this.btneff.UseVisualStyleBackColor = true;
            this.btneff.Click += new System.EventHandler(this.btneff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 574);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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