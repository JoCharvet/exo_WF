using System.Drawing;
using System.Windows.Forms;

namespace Super_Addionneur_4000
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayRTB = new System.Windows.Forms.RichTextBox();
            this.BtnVid = new Super_Addionneur_4000.RoundedButton();
            this.BtnVal = new Super_Addionneur_4000.RoundedButton();
            this.Btn0 = new Super_Addionneur_4000.RoundedButton();
            this.Btn1 = new Super_Addionneur_4000.RoundedButton();
            this.Btn2 = new Super_Addionneur_4000.RoundedButton();
            this.Btn3 = new Super_Addionneur_4000.RoundedButton();
            this.Btn4 = new Super_Addionneur_4000.RoundedButton();
            this.Btn5 = new Super_Addionneur_4000.RoundedButton();
            this.Btn6 = new Super_Addionneur_4000.RoundedButton();
            this.Btn7 = new Super_Addionneur_4000.RoundedButton();
            this.Btn8 = new Super_Addionneur_4000.RoundedButton();
            this.Btn9 = new Super_Addionneur_4000.RoundedButton();
            this.BtnRnd = new Super_Addionneur_4000.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisplayRTB
            // 
            this.DisplayRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(64)))));
            this.DisplayRTB.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayRTB.ForeColor = System.Drawing.SystemColors.Info;
            this.DisplayRTB.Location = new System.Drawing.Point(11, 63);
            this.DisplayRTB.Name = "DisplayRTB";
            this.DisplayRTB.ReadOnly = true;
            this.DisplayRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.DisplayRTB.Size = new System.Drawing.Size(361, 117);
            this.DisplayRTB.TabIndex = 0;
            this.DisplayRTB.Text = "";
            // 
            // BtnVid
            // 
            this.BtnVid.BackColor = System.Drawing.Color.Firebrick;
            this.BtnVid.Enabled = false;
            this.BtnVid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVid.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnVid.Location = new System.Drawing.Point(34, 437);
            this.BtnVid.Name = "BtnVid";
            this.BtnVid.Size = new System.Drawing.Size(165, 56);
            this.BtnVid.TabIndex = 1;
            this.BtnVid.Text = "Vider";
            this.BtnVid.UseVisualStyleBackColor = false;
            this.BtnVid.Click += new System.EventHandler(this.BtnVid_Click);
            // 
            // BtnVal
            // 
            this.BtnVal.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnVal.Enabled = false;
            this.BtnVal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVal.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnVal.Location = new System.Drawing.Point(223, 402);
            this.BtnVal.Name = "BtnVal";
            this.BtnVal.Size = new System.Drawing.Size(129, 91);
            this.BtnVal.TabIndex = 2;
            this.BtnVal.Text = "Calculer";
            this.BtnVal.UseVisualStyleBackColor = false;
            this.BtnVal.Click += new System.EventHandler(this.BtnVal_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.SpringGreen;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn0.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(21, 220);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(44, 68);
            this.Btn0.TabIndex = 3;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.MediumPurple;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn1.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(71, 212);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(62, 68);
            this.Btn1.TabIndex = 4;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn2.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(139, 200);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(39, 88);
            this.Btn2.TabIndex = 5;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.Salmon;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn3.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(184, 246);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(44, 53);
            this.Btn3.TabIndex = 6;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.Gray;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn4.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(234, 200);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(68, 80);
            this.Btn4.TabIndex = 7;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn5.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(308, 212);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(44, 120);
            this.Btn5.TabIndex = 8;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn6.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(11, 294);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(97, 38);
            this.Btn6.TabIndex = 9;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.SkyBlue;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn7.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(34, 342);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(94, 86);
            this.Btn7.TabIndex = 10;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn8.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(134, 294);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(44, 86);
            this.Btn8.TabIndex = 11;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn9.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(184, 311);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(94, 53);
            this.Btn9.TabIndex = 12;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnRnd
            // 
            this.BtnRnd.BackColor = System.Drawing.Color.PaleVioletRed;
            this.BtnRnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRnd.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRnd.Location = new System.Drawing.Point(284, 342);
            this.BtnRnd.Name = "BtnRnd";
            this.BtnRnd.Size = new System.Drawing.Size(87, 38);
            this.BtnRnd.TabIndex = 13;
            this.BtnRnd.Text = "?";
            this.BtnRnd.UseVisualStyleBackColor = false;
            this.BtnRnd.Click += new System.EventHandler(this.BtnRnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Super Additionneur 4000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(225)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(384, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add((Button)this.BtnRnd);
            this.Controls.Add((Button)this.Btn9);
            this.Controls.Add((Button)this.Btn8);
            this.Controls.Add((Button)this.Btn7);
            this.Controls.Add((Button)this.Btn6);
            this.Controls.Add((Button)this.Btn5);
            this.Controls.Add((Button)this.Btn4);
            this.Controls.Add((Button)this.Btn3);
            this.Controls.Add((Button)this.Btn2);
            this.Controls.Add((Button)this.Btn1);
            this.Controls.Add((Button)this.Btn0);
            this.Controls.Add((Button)this.BtnVal);
            this.Controls.Add((Button)this.BtnVid);
            this.Controls.Add(this.DisplayRTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Super Additionneur -4000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox DisplayRTB;
        private RoundedButton BtnVid;
        private RoundedButton BtnVal;
        private RoundedButton Btn0;
        private RoundedButton Btn1;
        private RoundedButton Btn2;
        private RoundedButton Btn3;
        private RoundedButton Btn4;
        private RoundedButton Btn5;
        private RoundedButton Btn6;
        private RoundedButton Btn7;
        private RoundedButton Btn8;
        private RoundedButton Btn9;
        private RoundedButton BtnRnd;
        private System.Windows.Forms.Label label1;
    }
}

