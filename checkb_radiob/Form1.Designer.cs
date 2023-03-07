namespace checkb_radiob
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
            this.lblTxt = new System.Windows.Forms.Label();
            this.txtBInput = new System.Windows.Forms.TextBox();
            this.gBChoices = new System.Windows.Forms.GroupBox();
            this.cBCase = new System.Windows.Forms.CheckBox();
            this.cBForeC = new System.Windows.Forms.CheckBox();
            this.cBBackG = new System.Windows.Forms.CheckBox();
            this.txtBOutput = new System.Windows.Forms.TextBox();
            this.gBBackground = new System.Windows.Forms.GroupBox();
            this.cBBlue = new System.Windows.Forms.CheckBox();
            this.cBGreen = new System.Windows.Forms.CheckBox();
            this.cBRed = new System.Windows.Forms.CheckBox();
            this.gBChar = new System.Windows.Forms.GroupBox();
            this.cBCharBlack = new System.Windows.Forms.CheckBox();
            this.cBCharWhite = new System.Windows.Forms.CheckBox();
            this.cbCharRed = new System.Windows.Forms.CheckBox();
            this.gBCase = new System.Windows.Forms.GroupBox();
            this.cBUpperCase = new System.Windows.Forms.CheckBox();
            this.cBLowerCase = new System.Windows.Forms.CheckBox();
            this.gBChoices.SuspendLayout();
            this.gBBackground.SuspendLayout();
            this.gBChar.SuspendLayout();
            this.gBCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Location = new System.Drawing.Point(50, 21);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(145, 25);
            this.lblTxt.TabIndex = 0;
            this.lblTxt.Text = "Tapez votre texte";
            // 
            // txtBInput
            // 
            this.txtBInput.Location = new System.Drawing.Point(45, 65);
            this.txtBInput.Name = "txtBInput";
            this.txtBInput.Size = new System.Drawing.Size(469, 31);
            this.txtBInput.TabIndex = 1;
            // 
            // gBChoices
            // 
            this.gBChoices.Controls.Add(this.cBCase);
            this.gBChoices.Controls.Add(this.cBForeC);
            this.gBChoices.Controls.Add(this.cBBackG);
            this.gBChoices.Enabled = false;
            this.gBChoices.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gBChoices.Location = new System.Drawing.Point(565, 12);
            this.gBChoices.Name = "gBChoices";
            this.gBChoices.Size = new System.Drawing.Size(307, 157);
            this.gBChoices.TabIndex = 2;
            this.gBChoices.TabStop = false;
            this.gBChoices.Text = "Choix";
            // 
            // cBCase
            // 
            this.cBCase.AutoSize = true;
            this.cBCase.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBCase.Location = new System.Drawing.Point(25, 105);
            this.cBCase.Name = "cBCase";
            this.cBCase.Size = new System.Drawing.Size(83, 29);
            this.cBCase.TabIndex = 2;
            this.cBCase.Text = "Casse";
            this.cBCase.UseVisualStyleBackColor = true;
            this.cBCase.CheckedChanged += new System.EventHandler(this.cBCase_CheckedChanged);
            // 
            // cBForeC
            // 
            this.cBForeC.AutoSize = true;
            this.cBForeC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBForeC.Location = new System.Drawing.Point(25, 70);
            this.cBForeC.Name = "cBForeC";
            this.cBForeC.Size = new System.Drawing.Size(215, 29);
            this.cBForeC.TabIndex = 1;
            this.cBForeC.Text = "Couleur des caractères";
            this.cBForeC.UseVisualStyleBackColor = true;
            this.cBForeC.CheckedChanged += new System.EventHandler(this.cBForeC_CheckedChanged);
            // 
            // cBBackG
            // 
            this.cBBackG.AutoSize = true;
            this.cBBackG.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBBackG.Location = new System.Drawing.Point(25, 35);
            this.cBBackG.Name = "cBBackG";
            this.cBBackG.Size = new System.Drawing.Size(168, 29);
            this.cBBackG.TabIndex = 0;
            this.cBBackG.Text = "Couleur du fond";
            this.cBBackG.UseVisualStyleBackColor = true;
            this.cBBackG.CheckedChanged += new System.EventHandler(this.cBBackG_CheckedChanged);
            // 
            // txtBOutput
            // 
            this.txtBOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBOutput.Location = new System.Drawing.Point(45, 138);
            this.txtBOutput.Name = "txtBOutput";
            this.txtBOutput.ReadOnly = true;
            this.txtBOutput.Size = new System.Drawing.Size(469, 31);
            this.txtBOutput.TabIndex = 3;
            // 
            // gBBackground
            // 
            this.gBBackground.Controls.Add(this.cBBlue);
            this.gBBackground.Controls.Add(this.cBGreen);
            this.gBBackground.Controls.Add(this.cBRed);
            this.gBBackground.Enabled = false;
            this.gBBackground.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gBBackground.Location = new System.Drawing.Point(45, 203);
            this.gBBackground.Name = "gBBackground";
            this.gBBackground.Size = new System.Drawing.Size(150, 149);
            this.gBBackground.TabIndex = 4;
            this.gBBackground.TabStop = false;
            this.gBBackground.Text = "Fond";
            // 
            // cBBlue
            // 
            this.cBBlue.AutoSize = true;
            this.cBBlue.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBBlue.Location = new System.Drawing.Point(13, 104);
            this.cBBlue.Name = "cBBlue";
            this.cBBlue.Size = new System.Drawing.Size(80, 29);
            this.cBBlue.TabIndex = 2;
            this.cBBlue.Text = "Bleue";
            this.cBBlue.UseVisualStyleBackColor = true;
            // 
            // cBGreen
            // 
            this.cBGreen.AutoSize = true;
            this.cBGreen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBGreen.Location = new System.Drawing.Point(13, 69);
            this.cBGreen.Name = "cBGreen";
            this.cBGreen.Size = new System.Drawing.Size(69, 29);
            this.cBGreen.TabIndex = 1;
            this.cBGreen.Text = "Vert";
            this.cBGreen.UseVisualStyleBackColor = true;
            // 
            // cBRed
            // 
            this.cBRed.AutoSize = true;
            this.cBRed.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBRed.Location = new System.Drawing.Point(13, 34);
            this.cBRed.Name = "cBRed";
            this.cBRed.Size = new System.Drawing.Size(89, 29);
            this.cBRed.TabIndex = 0;
            this.cBRed.Text = "Rouge";
            this.cBRed.UseVisualStyleBackColor = true;
            // 
            // gBChar
            // 
            this.gBChar.Controls.Add(this.cBCharBlack);
            this.gBChar.Controls.Add(this.cBCharWhite);
            this.gBChar.Controls.Add(this.cbCharRed);
            this.gBChar.Enabled = false;
            this.gBChar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gBChar.Location = new System.Drawing.Point(219, 203);
            this.gBChar.Name = "gBChar";
            this.gBChar.Size = new System.Drawing.Size(161, 150);
            this.gBChar.TabIndex = 5;
            this.gBChar.TabStop = false;
            this.gBChar.Text = "Caractères";
            // 
            // cBCharBlack
            // 
            this.cBCharBlack.AutoSize = true;
            this.cBCharBlack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBCharBlack.Location = new System.Drawing.Point(13, 105);
            this.cBCharBlack.Name = "cBCharBlack";
            this.cBCharBlack.Size = new System.Drawing.Size(72, 29);
            this.cBCharBlack.TabIndex = 2;
            this.cBCharBlack.Text = "Noir";
            this.cBCharBlack.UseVisualStyleBackColor = true;
            // 
            // cBCharWhite
            // 
            this.cBCharWhite.AutoSize = true;
            this.cBCharWhite.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBCharWhite.Location = new System.Drawing.Point(13, 70);
            this.cBCharWhite.Name = "cBCharWhite";
            this.cBCharWhite.Size = new System.Drawing.Size(79, 29);
            this.cBCharWhite.TabIndex = 1;
            this.cBCharWhite.Text = "Blanc";
            this.cBCharWhite.UseVisualStyleBackColor = true;
            // 
            // cbCharRed
            // 
            this.cbCharRed.AutoSize = true;
            this.cbCharRed.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbCharRed.Location = new System.Drawing.Point(13, 35);
            this.cbCharRed.Name = "cbCharRed";
            this.cbCharRed.Size = new System.Drawing.Size(89, 29);
            this.cbCharRed.TabIndex = 0;
            this.cbCharRed.Text = "Rouge";
            this.cbCharRed.UseVisualStyleBackColor = true;
            // 
            // gBCase
            // 
            this.gBCase.Controls.Add(this.cBUpperCase);
            this.gBCase.Controls.Add(this.cBLowerCase);
            this.gBCase.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gBCase.Location = new System.Drawing.Point(411, 248);
            this.gBCase.Name = "gBCase";
            this.gBCase.Size = new System.Drawing.Size(201, 105);
            this.gBCase.TabIndex = 6;
            this.gBCase.TabStop = false;
            this.gBCase.Text = "Casse";
            // 
            // cBUpperCase
            // 
            this.cBUpperCase.AutoSize = true;
            this.cBUpperCase.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBUpperCase.Location = new System.Drawing.Point(6, 65);
            this.cBUpperCase.Name = "cBUpperCase";
            this.cBUpperCase.Size = new System.Drawing.Size(124, 29);
            this.cBUpperCase.TabIndex = 1;
            this.cBUpperCase.Text = "Majuscules";
            this.cBUpperCase.UseVisualStyleBackColor = true;
            // 
            // cBLowerCase
            // 
            this.cBLowerCase.AutoSize = true;
            this.cBLowerCase.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBLowerCase.Location = new System.Drawing.Point(6, 30);
            this.cBLowerCase.Name = "cBLowerCase";
            this.cBLowerCase.Size = new System.Drawing.Size(125, 29);
            this.cBLowerCase.TabIndex = 0;
            this.cBLowerCase.Text = "Minuscules";
            this.cBLowerCase.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 387);
            this.Controls.Add(this.gBCase);
            this.Controls.Add(this.gBChar);
            this.Controls.Add(this.gBBackground);
            this.Controls.Add(this.txtBOutput);
            this.Controls.Add(this.gBChoices);
            this.Controls.Add(this.txtBInput);
            this.Controls.Add(this.lblTxt);
            this.Name = "Form1";
            this.Text = "CheckBox et RadioButton";
            this.gBChoices.ResumeLayout(false);
            this.gBChoices.PerformLayout();
            this.gBBackground.ResumeLayout(false);
            this.gBBackground.PerformLayout();
            this.gBChar.ResumeLayout(false);
            this.gBChar.PerformLayout();
            this.gBCase.ResumeLayout(false);
            this.gBCase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTxt;
        private TextBox txtBInput;
        private GroupBox gBChoices;
        private CheckBox cBCase;
        private CheckBox cBForeC;
        private CheckBox cBBackG;
        private TextBox txtBOutput;
        private GroupBox gBBackground;
        private CheckBox cBBlue;
        private CheckBox cBGreen;
        private CheckBox cBRed;
        private GroupBox gBChar;
        private CheckBox cBCharBlack;
        private CheckBox cBCharWhite;
        private CheckBox cbCharRed;
        private GroupBox gBCase;
        private CheckBox cBUpperCase;
        private CheckBox cBLowerCase;
    }
}