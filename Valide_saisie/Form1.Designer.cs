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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 23);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(105, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 23);
            this.textBox4.TabIndex = 7;
            // 
            // lbltipdate
            // 
            this.lbltipdate.AutoSize = true;
            this.lbltipdate.Location = new System.Drawing.Point(242, 109);
            this.lbltipdate.Name = "lbltipdate";
            this.lbltipdate.Size = new System.Drawing.Size(87, 15);
            this.lbltipdate.TabIndex = 8;
            this.lbltipdate.Text = "(JJ/MM/AAAA)";
            // 
            // btnval
            // 
            this.btnval.Location = new System.Drawing.Point(318, 193);
            this.btnval.Name = "btnval";
            this.btnval.Size = new System.Drawing.Size(75, 23);
            this.btnval.TabIndex = 9;
            this.btnval.Text = "Valider";
            this.btnval.UseVisualStyleBackColor = true;
            // 
            // btneff
            // 
            this.btneff.Location = new System.Drawing.Point(319, 223);
            this.btneff.Name = "btneff";
            this.btneff.Size = new System.Drawing.Size(75, 23);
            this.btneff.TabIndex = 10;
            this.btneff.Text = "Effacer";
            this.btneff.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 258);
            this.Controls.Add(this.btneff);
            this.Controls.Add(this.btnval);
            this.Controls.Add(this.lbltipdate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lbltipdate;
        private Button btnval;
        private Button btneff;
    }
}