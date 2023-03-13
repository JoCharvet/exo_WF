namespace Emprunts
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
            this.lblCap = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblNbMois = new System.Windows.Forms.Label();
            this.lblDuree2 = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(24, 45);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(34, 15);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Location = new System.Drawing.Point(24, 95);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(99, 15);
            this.lblCap.TabIndex = 1;
            this.lblCap.Text = "Capital Emprunté";
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Location = new System.Drawing.Point(24, 150);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(100, 15);
            this.lblDuree.TabIndex = 2;
            this.lblDuree.Text = "Durée en mois du";
            // 
            // lblNbMois
            // 
            this.lblNbMois.AutoSize = true;
            this.lblNbMois.Location = new System.Drawing.Point(172, 150);
            this.lblNbMois.Name = "lblNbMois";
            this.lblNbMois.Size = new System.Drawing.Size(25, 15);
            this.lblNbMois.TabIndex = 3;
            this.lblNbMois.Text = "120";
            // 
            // lblDuree2
            // 
            this.lblDuree2.AutoSize = true;
            this.lblDuree2.Location = new System.Drawing.Point(24, 165);
            this.lblDuree2.Name = "lblDuree2";
            this.lblDuree2.Size = new System.Drawing.Size(92, 15);
            this.lblDuree2.TabIndex = 4;
            this.lblDuree2.Text = "remboursement";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(24, 208);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(168, 15);
            this.lblPeriod.TabIndex = 5;
            this.lblPeriod.Text = "Périodicité du remboursement";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(24, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 79);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblDuree2);
            this.Controls.Add(this.lblNbMois);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblCap);
            this.Controls.Add(this.lblNom);
            this.Name = "Form1";
            this.Text = "Emprunts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNom;
        private Label lblCap;
        private Label lblDuree;
        private Label lblNbMois;
        private Label lblDuree2;
        private Label lblPeriod;
        private ListBox listBox1;
    }
}