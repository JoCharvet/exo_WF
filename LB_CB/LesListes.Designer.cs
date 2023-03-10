namespace LB_CB
{
    partial class LesListes
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
            this.lblSource = new System.Windows.Forms.Label();
            this.lblCible = new System.Windows.Forms.Label();
            this.comboSource = new System.Windows.Forms.ComboBox();
            this.lstBCible = new System.Windows.Forms.ListBox();
            this.btnSToT = new System.Windows.Forms.Button();
            this.btnSToTAll = new System.Windows.Forms.Button();
            this.btnTToS = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(72, 24);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(43, 15);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source";
            // 
            // lblCible
            // 
            this.lblCible.AutoSize = true;
            this.lblCible.Location = new System.Drawing.Point(255, 23);
            this.lblCible.Name = "lblCible";
            this.lblCible.Size = new System.Drawing.Size(34, 15);
            this.lblCible.TabIndex = 1;
            this.lblCible.Text = "Cible";
            // 
            // comboSource
            // 
            this.comboSource.FormattingEnabled = true;
            this.comboSource.Location = new System.Drawing.Point(31, 42);
            this.comboSource.Name = "comboSource";
            this.comboSource.Size = new System.Drawing.Size(121, 23);
            this.comboSource.TabIndex = 2;
            // 
            // lstBCible
            // 
            this.lstBCible.FormattingEnabled = true;
            this.lstBCible.ItemHeight = 15;
            this.lstBCible.Location = new System.Drawing.Point(217, 41);
            this.lstBCible.Name = "lstBCible";
            this.lstBCible.Size = new System.Drawing.Size(120, 154);
            this.lstBCible.TabIndex = 3;
            // 
            // btnSToT
            // 
            this.btnSToT.Location = new System.Drawing.Point(158, 41);
            this.btnSToT.Name = "btnSToT";
            this.btnSToT.Size = new System.Drawing.Size(53, 23);
            this.btnSToT.TabIndex = 4;
            this.btnSToT.Text = ">";
            this.btnSToT.UseVisualStyleBackColor = true;
            // 
            // btnSToTAll
            // 
            this.btnSToTAll.Location = new System.Drawing.Point(158, 70);
            this.btnSToTAll.Name = "btnSToTAll";
            this.btnSToTAll.Size = new System.Drawing.Size(53, 23);
            this.btnSToTAll.TabIndex = 5;
            this.btnSToTAll.Text = ">>";
            this.btnSToTAll.UseVisualStyleBackColor = true;
            // 
            // btnTToS
            // 
            this.btnTToS.Location = new System.Drawing.Point(158, 142);
            this.btnTToS.Name = "btnTToS";
            this.btnTToS.Size = new System.Drawing.Size(53, 23);
            this.btnTToS.TabIndex = 6;
            this.btnTToS.Text = "<";
            this.btnTToS.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUp.Location = new System.Drawing.Point(237, 201);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(33, 40);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDown.Location = new System.Drawing.Point(276, 201);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(33, 40);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // LesListes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 255);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTToS);
            this.Controls.Add(this.btnSToTAll);
            this.Controls.Add(this.btnSToT);
            this.Controls.Add(this.lstBCible);
            this.Controls.Add(this.comboSource);
            this.Controls.Add(this.lblCible);
            this.Controls.Add(this.lblSource);
            this.Name = "LesListes";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSource;
        private Label lblCible;
        private ComboBox comboSource;
        private ListBox lstBCible;
        private Button btnSToT;
        private Button btnSToTAll;
        private Button btnTToS;
        private Button button2;
        private Button btnUp;
        private Button btnDown;
    }
}