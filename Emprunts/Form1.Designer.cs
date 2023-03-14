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
            this.hscbDuree = new System.Windows.Forms.HScrollBar();
            this.gbTaux = new System.Windows.Forms.GroupBox();
            this.rdb9 = new System.Windows.Forms.RadioButton();
            this.rdb8 = new System.Windows.Forms.RadioButton();
            this.rdb7 = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblNbRemb = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblRemboursements = new System.Windows.Forms.Label();
            this.txtbNom = new System.Windows.Forms.TextBox();
            this.txtbCapitalE = new System.Windows.Forms.TextBox();
            this.gbTaux.SuspendLayout();
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
            this.listBox1.Size = new System.Drawing.Size(256, 109);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // hscbDuree
            // 
            this.hscbDuree.LargeChange = 1;
            this.hscbDuree.Location = new System.Drawing.Point(210, 150);
            this.hscbDuree.Name = "hscbDuree";
            this.hscbDuree.Size = new System.Drawing.Size(131, 17);
            this.hscbDuree.TabIndex = 7;
            this.hscbDuree.ValueChanged += new System.EventHandler(this.hscbDuree_ValueChanged);
            // 
            // gbTaux
            // 
            this.gbTaux.Controls.Add(this.rdb9);
            this.gbTaux.Controls.Add(this.rdb8);
            this.gbTaux.Controls.Add(this.rdb7);
            this.gbTaux.Location = new System.Drawing.Point(400, 55);
            this.gbTaux.Name = "gbTaux";
            this.gbTaux.Size = new System.Drawing.Size(108, 153);
            this.gbTaux.TabIndex = 8;
            this.gbTaux.TabStop = false;
            this.gbTaux.Text = "Taux d\'intérêt";
            // 
            // rdb9
            // 
            this.rdb9.AutoSize = true;
            this.rdb9.Location = new System.Drawing.Point(32, 110);
            this.rdb9.Name = "rdb9";
            this.rdb9.Size = new System.Drawing.Size(41, 19);
            this.rdb9.TabIndex = 2;
            this.rdb9.TabStop = true;
            this.rdb9.Tag = "9";
            this.rdb9.Text = "9%";
            this.rdb9.UseVisualStyleBackColor = true;
            this.rdb9.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // rdb8
            // 
            this.rdb8.AutoSize = true;
            this.rdb8.Location = new System.Drawing.Point(32, 72);
            this.rdb8.Name = "rdb8";
            this.rdb8.Size = new System.Drawing.Size(41, 19);
            this.rdb8.TabIndex = 1;
            this.rdb8.TabStop = true;
            this.rdb8.Tag = "8";
            this.rdb8.Text = "8%";
            this.rdb8.UseVisualStyleBackColor = true;
            this.rdb8.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // rdb7
            // 
            this.rdb7.AutoSize = true;
            this.rdb7.Location = new System.Drawing.Point(32, 36);
            this.rdb7.Name = "rdb7";
            this.rdb7.Size = new System.Drawing.Size(41, 19);
            this.rdb7.TabIndex = 0;
            this.rdb7.TabStop = true;
            this.rdb7.Tag = "7";
            this.rdb7.Text = "7%";
            this.rdb7.UseVisualStyleBackColor = true;
            this.rdb7.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(543, 87);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(543, 125);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblNbRemb
            // 
            this.lblNbRemb.AutoSize = true;
            this.lblNbRemb.ForeColor = System.Drawing.Color.Red;
            this.lblNbRemb.Location = new System.Drawing.Point(382, 241);
            this.lblNbRemb.Name = "lblNbRemb";
            this.lblNbRemb.Size = new System.Drawing.Size(19, 15);
            this.lblNbRemb.TabIndex = 11;
            this.lblNbRemb.Text = "40";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.ForeColor = System.Drawing.Color.Red;
            this.lblMontant.Location = new System.Drawing.Point(500, 290);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(49, 15);
            this.lblMontant.TabIndex = 12;
            this.lblMontant.Text = "5 483,36";
            // 
            // lblRemboursements
            // 
            this.lblRemboursements.AutoSize = true;
            this.lblRemboursements.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRemboursements.Location = new System.Drawing.Point(453, 241);
            this.lblRemboursements.Name = "lblRemboursements";
            this.lblRemboursements.Size = new System.Drawing.Size(143, 21);
            this.lblRemboursements.TabIndex = 13;
            this.lblRemboursements.Text = "Remboursements";
            // 
            // txtbNom
            // 
            this.txtbNom.Location = new System.Drawing.Point(152, 42);
            this.txtbNom.Name = "txtbNom";
            this.txtbNom.Size = new System.Drawing.Size(110, 23);
            this.txtbNom.TabIndex = 14;
            // 
            // txtbCapitalE
            // 
            this.txtbCapitalE.Location = new System.Drawing.Point(152, 92);
            this.txtbCapitalE.Name = "txtbCapitalE";
            this.txtbCapitalE.Size = new System.Drawing.Size(110, 23);
            this.txtbCapitalE.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(651, 346);
            this.Controls.Add(this.txtbCapitalE);
            this.Controls.Add(this.txtbNom);
            this.Controls.Add(this.lblRemboursements);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblNbRemb);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbTaux);
            this.Controls.Add(this.hscbDuree);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblDuree2);
            this.Controls.Add(this.lblNbMois);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblCap);
            this.Controls.Add(this.lblNom);
            this.Name = "Form1";
            this.Text = "Emprunts";
            this.gbTaux.ResumeLayout(false);
            this.gbTaux.PerformLayout();
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
        private HScrollBar hscbDuree;
        private GroupBox gbTaux;
        private RadioButton rdb9;
        private RadioButton rdb8;
        private RadioButton rdb7;
        private Button btnOk;
        private Button btnAnnuler;
        private Label lblNbRemb;
        private Label lblMontant;
        private Label lblRemboursements;
        private TextBox txtbNom;
        private TextBox txtbCapitalE;
    }
}