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
            this.cBBlue = new System.Windows.Forms.RadioButton();
            this.cBGreen = new System.Windows.Forms.RadioButton();
            this.cBRed = new System.Windows.Forms.RadioButton();
            this.gBChar = new System.Windows.Forms.GroupBox();
            this.cBCharBlack = new System.Windows.Forms.RadioButton();
            this.cBCharWhite = new System.Windows.Forms.RadioButton();
            this.cbCharRed = new System.Windows.Forms.RadioButton();
            this.gBCase = new System.Windows.Forms.GroupBox();
            this.cBUpperCase = new System.Windows.Forms.RadioButton();
            this.cBLowerCase = new System.Windows.Forms.RadioButton();
            this.gBChoices.SuspendLayout();
            this.gBBackground.SuspendLayout();
            this.gBChar.SuspendLayout();
            this.gBCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Location = new System.Drawing.Point(35, 13);
            this.lblTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(95, 15);
            this.lblTxt.TabIndex = 0;
            this.lblTxt.Text = "Tapez votre texte";
            // 
            // txtBInput
            // 
            this.txtBInput.Location = new System.Drawing.Point(32, 39);
            this.txtBInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtBInput.Name = "txtBInput";
            this.txtBInput.Size = new System.Drawing.Size(330, 23);
            this.txtBInput.TabIndex = 1;
            this.txtBInput.TextChanged += new System.EventHandler(this.txtBInput_TextChanged);
            // 
            // gBChoices
            // 
            this.gBChoices.Controls.Add(this.cBCase);
            this.gBChoices.Controls.Add(this.cBForeC);
            this.gBChoices.Controls.Add(this.cBBackG);
            this.gBChoices.Enabled = false;
            this.gBChoices.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gBChoices.Location = new System.Drawing.Point(396, 7);
            this.gBChoices.Margin = new System.Windows.Forms.Padding(2);
            this.gBChoices.Name = "gBChoices";
            this.gBChoices.Padding = new System.Windows.Forms.Padding(2);
            this.gBChoices.Size = new System.Drawing.Size(215, 94);
            this.gBChoices.TabIndex = 2;
            this.gBChoices.TabStop = false;
            this.gBChoices.Text = "Choix";
            // 
            // cBCase
            // 
            this.cBCase.AutoSize = true;
            this.cBCase.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBCase.Location = new System.Drawing.Point(18, 63);
            this.cBCase.Margin = new System.Windows.Forms.Padding(2);
            this.cBCase.Name = "cBCase";
            this.cBCase.Size = new System.Drawing.Size(56, 19);
            this.cBCase.TabIndex = 2;
            this.cBCase.Text = "Casse";
            this.cBCase.UseVisualStyleBackColor = true;
            this.cBCase.CheckedChanged += new System.EventHandler(this.cBCase_CheckedChanged);
            // 
            // cBForeC
            // 
            this.cBForeC.AutoSize = true;
            this.cBForeC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBForeC.Location = new System.Drawing.Point(18, 42);
            this.cBForeC.Margin = new System.Windows.Forms.Padding(2);
            this.cBForeC.Name = "cBForeC";
            this.cBForeC.Size = new System.Drawing.Size(145, 19);
            this.cBForeC.TabIndex = 1;
            this.cBForeC.Text = "Couleur des caractères";
            this.cBForeC.UseVisualStyleBackColor = true;
            this.cBForeC.CheckedChanged += new System.EventHandler(this.cBForeC_CheckedChanged);
            // 
            // cBBackG
            // 
            this.cBBackG.AutoSize = true;
            this.cBBackG.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBBackG.Location = new System.Drawing.Point(18, 21);
            this.cBBackG.Margin = new System.Windows.Forms.Padding(2);
            this.cBBackG.Name = "cBBackG";
            this.cBBackG.Size = new System.Drawing.Size(113, 19);
            this.cBBackG.TabIndex = 0;
            this.cBBackG.Text = "Couleur du fond";
            this.cBBackG.UseVisualStyleBackColor = true;
            this.cBBackG.CheckedChanged += new System.EventHandler(this.cBBackG_CheckedChanged);
            // 
            // txtBOutput
            // 
            this.txtBOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBOutput.Location = new System.Drawing.Point(32, 83);
            this.txtBOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtBOutput.Name = "txtBOutput";
            this.txtBOutput.ReadOnly = true;
            this.txtBOutput.Size = new System.Drawing.Size(330, 23);
            this.txtBOutput.TabIndex = 3;
            // 
            // gBBackground
            // 
            this.gBBackground.Controls.Add(this.cBBlue);
            this.gBBackground.Controls.Add(this.cBGreen);
            this.gBBackground.Controls.Add(this.cBRed);
            this.gBBackground.Enabled = false;
            this.gBBackground.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gBBackground.Location = new System.Drawing.Point(32, 122);
            this.gBBackground.Margin = new System.Windows.Forms.Padding(2);
            this.gBBackground.Name = "gBBackground";
            this.gBBackground.Padding = new System.Windows.Forms.Padding(2);
            this.gBBackground.Size = new System.Drawing.Size(105, 89);
            this.gBBackground.TabIndex = 4;
            this.gBBackground.TabStop = false;
            this.gBBackground.Text = "Fond";
            this.gBBackground.EnabledChanged += new System.EventHandler(this.gBBackground_EnabledChanged);
            // 
            // cBBlue
            // 
            this.cBBlue.AutoSize = true;
            this.cBBlue.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBBlue.Location = new System.Drawing.Point(9, 62);
            this.cBBlue.Margin = new System.Windows.Forms.Padding(2);
            this.cBBlue.Name = "cBBlue";
            this.cBBlue.Size = new System.Drawing.Size(54, 19);
            this.cBBlue.TabIndex = 2;
            this.cBBlue.Tag = "#0000FF";
            this.cBBlue.Text = "Bleue";
            this.cBBlue.UseVisualStyleBackColor = true;
            this.cBBlue.CheckedChanged += new System.EventHandler(this.cBBGColor_CheckedChanged);
            // 
            // cBGreen
            // 
            this.cBGreen.AutoSize = true;
            this.cBGreen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBGreen.Location = new System.Drawing.Point(9, 41);
            this.cBGreen.Margin = new System.Windows.Forms.Padding(2);
            this.cBGreen.Name = "cBGreen";
            this.cBGreen.Size = new System.Drawing.Size(45, 19);
            this.cBGreen.TabIndex = 1;
            this.cBGreen.Tag = "#008000";
            this.cBGreen.Text = "Vert";
            this.cBGreen.UseVisualStyleBackColor = true;
            this.cBGreen.CheckedChanged += new System.EventHandler(this.cBBGColor_CheckedChanged);
            // 
            // cBRed
            // 
            this.cBRed.AutoSize = true;
            this.cBRed.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBRed.Location = new System.Drawing.Point(9, 20);
            this.cBRed.Margin = new System.Windows.Forms.Padding(2);
            this.cBRed.Name = "cBRed";
            this.cBRed.Size = new System.Drawing.Size(59, 19);
            this.cBRed.TabIndex = 0;
            this.cBRed.Tag = "#F00";
            this.cBRed.Text = "Rouge";
            this.cBRed.UseVisualStyleBackColor = true;
            this.cBRed.CheckedChanged += new System.EventHandler(this.cBBGColor_CheckedChanged);
            // 
            // gBChar
            // 
            this.gBChar.Controls.Add(this.cBCharBlack);
            this.gBChar.Controls.Add(this.cBCharWhite);
            this.gBChar.Controls.Add(this.cbCharRed);
            this.gBChar.Enabled = false;
            this.gBChar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gBChar.Location = new System.Drawing.Point(153, 122);
            this.gBChar.Margin = new System.Windows.Forms.Padding(2);
            this.gBChar.Name = "gBChar";
            this.gBChar.Padding = new System.Windows.Forms.Padding(2);
            this.gBChar.Size = new System.Drawing.Size(113, 90);
            this.gBChar.TabIndex = 5;
            this.gBChar.TabStop = false;
            this.gBChar.Text = "Caractères";
            this.gBChar.EnabledChanged += new System.EventHandler(this.gBChar_EnabledChanged);
            // 
            // cBCharBlack
            // 
            this.cBCharBlack.AutoSize = true;
            this.cBCharBlack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBCharBlack.Location = new System.Drawing.Point(9, 63);
            this.cBCharBlack.Margin = new System.Windows.Forms.Padding(2);
            this.cBCharBlack.Name = "cBCharBlack";
            this.cBCharBlack.Size = new System.Drawing.Size(48, 19);
            this.cBCharBlack.TabIndex = 2;
            this.cBCharBlack.Tag = "#000";
            this.cBCharBlack.Text = "Noir";
            this.cBCharBlack.UseVisualStyleBackColor = true;
            this.cBCharBlack.CheckedChanged += new System.EventHandler(this.cbCharColor_CheckedChanged);
            // 
            // cBCharWhite
            // 
            this.cBCharWhite.AutoSize = true;
            this.cBCharWhite.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBCharWhite.Location = new System.Drawing.Point(9, 42);
            this.cBCharWhite.Margin = new System.Windows.Forms.Padding(2);
            this.cBCharWhite.Name = "cBCharWhite";
            this.cBCharWhite.Size = new System.Drawing.Size(54, 19);
            this.cBCharWhite.TabIndex = 1;
            this.cBCharWhite.Tag = "#FFF";
            this.cBCharWhite.Text = "Blanc";
            this.cBCharWhite.UseVisualStyleBackColor = true;
            this.cBCharWhite.CheckedChanged += new System.EventHandler(this.cbCharColor_CheckedChanged);
            // 
            // cbCharRed
            // 
            this.cbCharRed.AutoSize = true;
            this.cbCharRed.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbCharRed.Location = new System.Drawing.Point(9, 21);
            this.cbCharRed.Margin = new System.Windows.Forms.Padding(2);
            this.cbCharRed.Name = "cbCharRed";
            this.cbCharRed.Size = new System.Drawing.Size(59, 19);
            this.cbCharRed.TabIndex = 0;
            this.cbCharRed.Tag = "#F00";
            this.cbCharRed.Text = "Rouge";
            this.cbCharRed.UseVisualStyleBackColor = true;
            this.cbCharRed.CheckedChanged += new System.EventHandler(this.cbCharColor_CheckedChanged);
            // 
            // gBCase
            // 
            this.gBCase.Controls.Add(this.cBUpperCase);
            this.gBCase.Controls.Add(this.cBLowerCase);
            this.gBCase.Enabled = false;
            this.gBCase.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gBCase.Location = new System.Drawing.Point(288, 149);
            this.gBCase.Margin = new System.Windows.Forms.Padding(2);
            this.gBCase.Name = "gBCase";
            this.gBCase.Padding = new System.Windows.Forms.Padding(2);
            this.gBCase.Size = new System.Drawing.Size(141, 63);
            this.gBCase.TabIndex = 6;
            this.gBCase.TabStop = false;
            this.gBCase.Text = "Casse";
            this.gBCase.EnabledChanged += new System.EventHandler(this.gBCase_EnabledChanged);
            // 
            // cBUpperCase
            // 
            this.cBUpperCase.AutoSize = true;
            this.cBUpperCase.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBUpperCase.Location = new System.Drawing.Point(4, 39);
            this.cBUpperCase.Margin = new System.Windows.Forms.Padding(2);
            this.cBUpperCase.Name = "cBUpperCase";
            this.cBUpperCase.Size = new System.Drawing.Size(84, 19);
            this.cBUpperCase.TabIndex = 1;
            this.cBUpperCase.Tag = "Upper";
            this.cBUpperCase.Text = "Majuscules";
            this.cBUpperCase.UseVisualStyleBackColor = true;
            this.cBUpperCase.CheckedChanged += new System.EventHandler(this.cBCaseChange_CheckedChanged);
            // 
            // cBLowerCase
            // 
            this.cBLowerCase.AutoSize = true;
            this.cBLowerCase.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBLowerCase.Location = new System.Drawing.Point(4, 18);
            this.cBLowerCase.Margin = new System.Windows.Forms.Padding(2);
            this.cBLowerCase.Name = "cBLowerCase";
            this.cBLowerCase.Size = new System.Drawing.Size(85, 19);
            this.cBLowerCase.TabIndex = 0;
            this.cBLowerCase.Tag = "Lower";
            this.cBLowerCase.Text = "Minuscules";
            this.cBLowerCase.UseVisualStyleBackColor = true;
            this.cBLowerCase.CheckedChanged += new System.EventHandler(this.cBCaseChange_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 232);
            this.Controls.Add(this.gBCase);
            this.Controls.Add(this.gBChar);
            this.Controls.Add(this.gBBackground);
            this.Controls.Add(this.txtBOutput);
            this.Controls.Add(this.gBChoices);
            this.Controls.Add(this.txtBInput);
            this.Controls.Add(this.lblTxt);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private RadioButton cBBlue;
        private RadioButton cBGreen;
        private RadioButton cBRed;
        private GroupBox gBChar;
        private RadioButton cBCharBlack;
        private RadioButton cBCharWhite;
        private RadioButton cbCharRed;
        private GroupBox gBCase;
        private RadioButton cBUpperCase;
        private RadioButton cBLowerCase;
    }
}