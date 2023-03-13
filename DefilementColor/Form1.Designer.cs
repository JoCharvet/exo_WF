namespace DefilementColor
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
            this.lblRouge = new System.Windows.Forms.Label();
            this.lblVert = new System.Windows.Forms.Label();
            this.lblBleu = new System.Windows.Forms.Label();
            this.hsbRouge = new System.Windows.Forms.HScrollBar();
            this.hsbVert = new System.Windows.Forms.HScrollBar();
            this.hsbBleu = new System.Windows.Forms.HScrollBar();
            this.nudRouge = new System.Windows.Forms.NumericUpDown();
            this.nudVert = new System.Windows.Forms.NumericUpDown();
            this.nudBleu = new System.Windows.Forms.NumericUpDown();
            this.affichageCol = new System.Windows.Forms.RichTextBox();
            this.txtBRouge = new System.Windows.Forms.TextBox();
            this.txtBVert = new System.Windows.Forms.TextBox();
            this.txtBBleu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBleu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRouge
            // 
            this.lblRouge.AutoSize = true;
            this.lblRouge.Location = new System.Drawing.Point(21, 45);
            this.lblRouge.Name = "lblRouge";
            this.lblRouge.Size = new System.Drawing.Size(41, 15);
            this.lblRouge.TabIndex = 0;
            this.lblRouge.Text = "Rouge";
            // 
            // lblVert
            // 
            this.lblVert.AutoSize = true;
            this.lblVert.Location = new System.Drawing.Point(21, 95);
            this.lblVert.Name = "lblVert";
            this.lblVert.Size = new System.Drawing.Size(27, 15);
            this.lblVert.TabIndex = 1;
            this.lblVert.Text = "Vert";
            // 
            // lblBleu
            // 
            this.lblBleu.AutoSize = true;
            this.lblBleu.Location = new System.Drawing.Point(21, 146);
            this.lblBleu.Name = "lblBleu";
            this.lblBleu.Size = new System.Drawing.Size(30, 15);
            this.lblBleu.TabIndex = 2;
            this.lblBleu.Text = "Bleu";
            // 
            // hsbRouge
            // 
            this.hsbRouge.LargeChange = 1;
            this.hsbRouge.Location = new System.Drawing.Point(85, 45);
            this.hsbRouge.Maximum = 255;
            this.hsbRouge.Name = "hsbRouge";
            this.hsbRouge.Size = new System.Drawing.Size(117, 17);
            this.hsbRouge.TabIndex = 3;
            this.hsbRouge.Value = 127;
            this.hsbRouge.ValueChanged += new System.EventHandler(this.changeColor2);
            // 
            // hsbVert
            // 
            this.hsbVert.LargeChange = 1;
            this.hsbVert.Location = new System.Drawing.Point(85, 93);
            this.hsbVert.Maximum = 255;
            this.hsbVert.Name = "hsbVert";
            this.hsbVert.Size = new System.Drawing.Size(117, 17);
            this.hsbVert.TabIndex = 4;
            this.hsbVert.Value = 127;
            this.hsbVert.ValueChanged += new System.EventHandler(this.changeColor2);
            // 
            // hsbBleu
            // 
            this.hsbBleu.LargeChange = 1;
            this.hsbBleu.Location = new System.Drawing.Point(85, 146);
            this.hsbBleu.Maximum = 255;
            this.hsbBleu.Name = "hsbBleu";
            this.hsbBleu.Size = new System.Drawing.Size(117, 17);
            this.hsbBleu.TabIndex = 5;
            this.hsbBleu.Value = 127;
            this.hsbBleu.ValueChanged += new System.EventHandler(this.changeColor2);
            // 
            // nudRouge
            // 
            this.nudRouge.Location = new System.Drawing.Point(223, 43);
            this.nudRouge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRouge.Name = "nudRouge";
            this.nudRouge.Size = new System.Drawing.Size(57, 23);
            this.nudRouge.TabIndex = 6;
            // 
            // nudVert
            // 
            this.nudVert.Location = new System.Drawing.Point(223, 93);
            this.nudVert.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudVert.Name = "nudVert";
            this.nudVert.Size = new System.Drawing.Size(57, 23);
            this.nudVert.TabIndex = 7;
            // 
            // nudBleu
            // 
            this.nudBleu.Location = new System.Drawing.Point(223, 144);
            this.nudBleu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBleu.Name = "nudBleu";
            this.nudBleu.Size = new System.Drawing.Size(57, 23);
            this.nudBleu.TabIndex = 8;
            // 
            // affichageCol
            // 
            this.affichageCol.BackColor = System.Drawing.Color.White;
            this.affichageCol.Location = new System.Drawing.Point(44, 185);
            this.affichageCol.Name = "affichageCol";
            this.affichageCol.ReadOnly = true;
            this.affichageCol.Size = new System.Drawing.Size(236, 55);
            this.affichageCol.TabIndex = 9;
            this.affichageCol.Text = "";
            // 
            // txtBRouge
            // 
            this.txtBRouge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.txtBRouge.Location = new System.Drawing.Point(298, 42);
            this.txtBRouge.Name = "txtBRouge";
            this.txtBRouge.ReadOnly = true;
            this.txtBRouge.Size = new System.Drawing.Size(49, 23);
            this.txtBRouge.TabIndex = 10;
            // 
            // txtBVert
            // 
            this.txtBVert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBVert.Location = new System.Drawing.Point(298, 92);
            this.txtBVert.Name = "txtBVert";
            this.txtBVert.ReadOnly = true;
            this.txtBVert.Size = new System.Drawing.Size(49, 23);
            this.txtBVert.TabIndex = 11;
            // 
            // txtBBleu
            // 
            this.txtBBleu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.txtBBleu.Location = new System.Drawing.Point(298, 144);
            this.txtBBleu.Name = "txtBBleu";
            this.txtBBleu.ReadOnly = true;
            this.txtBBleu.Size = new System.Drawing.Size(49, 23);
            this.txtBBleu.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 257);
            this.Controls.Add(this.txtBBleu);
            this.Controls.Add(this.txtBVert);
            this.Controls.Add(this.txtBRouge);
            this.Controls.Add(this.affichageCol);
            this.Controls.Add(this.nudBleu);
            this.Controls.Add(this.nudVert);
            this.Controls.Add(this.nudRouge);
            this.Controls.Add(this.hsbBleu);
            this.Controls.Add(this.hsbVert);
            this.Controls.Add(this.hsbRouge);
            this.Controls.Add(this.lblBleu);
            this.Controls.Add(this.lblVert);
            this.Controls.Add(this.lblRouge);
            this.Name = "Form1";
            this.Text = "Defilement";
            ((System.ComponentModel.ISupportInitialize)(this.nudRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBleu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRouge;
        private Label lblVert;
        private Label lblBleu;
        private HScrollBar hsbRouge;
        private HScrollBar hsbVert;
        private HScrollBar hsbBleu;
        private NumericUpDown nudRouge;
        private NumericUpDown nudVert;
        private NumericUpDown nudBleu;
        private RichTextBox affichageCol;
        private TextBox txtBRouge;
        private TextBox txtBVert;
        private TextBox txtBBleu;
    }
}