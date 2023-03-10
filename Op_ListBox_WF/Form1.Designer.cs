namespace Op_ListBox_WF
{
    partial class Exo_3_2ListBox
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
            this.lblNewElem = new System.Windows.Forms.Label();
            this.txtBNewElem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLst = new System.Windows.Forms.Label();
            this.lstBList = new System.Windows.Forms.ListBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.lblProp = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.txtBItems = new System.Windows.Forms.TextBox();
            this.txtBSelected = new System.Windows.Forms.TextBox();
            this.txtBText = new System.Windows.Forms.TextBox();
            this.txtBSelect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNewElem
            // 
            this.lblNewElem.AutoSize = true;
            this.lblNewElem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewElem.Location = new System.Drawing.Point(12, 9);
            this.lblNewElem.Name = "lblNewElem";
            this.lblNewElem.Size = new System.Drawing.Size(99, 15);
            this.lblNewElem.TabIndex = 0;
            this.lblNewElem.Text = "Nouvel  Élement";
            // 
            // txtBNewElem
            // 
            this.txtBNewElem.Location = new System.Drawing.Point(12, 37);
            this.txtBNewElem.Name = "txtBNewElem";
            this.txtBNewElem.Size = new System.Drawing.Size(143, 23);
            this.txtBNewElem.TabIndex = 1;
            this.txtBNewElem.TextChanged += new System.EventHandler(this.txtBNewElem_TextChanged);
            this.txtBNewElem.Enter += new System.EventHandler(this.txtB_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(12, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ajout Liste";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblLst
            // 
            this.lblLst.AutoSize = true;
            this.lblLst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLst.Location = new System.Drawing.Point(12, 124);
            this.lblLst.Name = "lblLst";
            this.lblLst.Size = new System.Drawing.Size(49, 15);
            this.lblLst.TabIndex = 3;
            this.lblLst.Text = "LstListe";
            // 
            // lstBList
            // 
            this.lstBList.FormattingEnabled = true;
            this.lstBList.ItemHeight = 15;
            this.lstBList.Items.AddRange(new object[] {
            "Denis",
            "Jean-Pierre",
            "Jean-Paul",
            "Arnaud"});
            this.lstBList.Location = new System.Drawing.Point(12, 158);
            this.lstBList.Name = "lstBList";
            this.lstBList.Size = new System.Drawing.Size(120, 109);
            this.lstBList.TabIndex = 4;
            this.lstBList.SelectedIndexChanged += new System.EventHandler(this.lstBList_SelectedIndexChanged);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIndex.Location = new System.Drawing.Point(194, 9);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(88, 15);
            this.lblIndex.TabIndex = 5;
            this.lblIndex.Text = "Index Elément";
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(251, 37);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(130, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Sélectionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(251, 80);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(130, 23);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Vider la Liste";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lblProp
            // 
            this.lblProp.AutoSize = true;
            this.lblProp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProp.Location = new System.Drawing.Point(194, 124);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(65, 15);
            this.lblProp.TabIndex = 9;
            this.lblProp.Text = "Propriétés";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(194, 171);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(72, 15);
            this.lblItems.TabIndex = 10;
            this.lblItems.Text = "Items.Count";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(194, 209);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(80, 15);
            this.lblSelect.TabIndex = 11;
            this.lblSelect.Text = "SelectedIndex";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(194, 243);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 15);
            this.lblText.TabIndex = 12;
            this.lblText.Text = "Text";
            // 
            // txtBItems
            // 
            this.txtBItems.Enabled = false;
            this.txtBItems.Location = new System.Drawing.Point(280, 168);
            this.txtBItems.Name = "txtBItems";
            this.txtBItems.Size = new System.Drawing.Size(38, 23);
            this.txtBItems.TabIndex = 13;
            // 
            // txtBSelected
            // 
            this.txtBSelected.Enabled = false;
            this.txtBSelected.Location = new System.Drawing.Point(280, 206);
            this.txtBSelected.Name = "txtBSelected";
            this.txtBSelected.Size = new System.Drawing.Size(38, 23);
            this.txtBSelected.TabIndex = 14;
            // 
            // txtBText
            // 
            this.txtBText.Enabled = false;
            this.txtBText.Location = new System.Drawing.Point(280, 240);
            this.txtBText.Name = "txtBText";
            this.txtBText.Size = new System.Drawing.Size(88, 23);
            this.txtBText.TabIndex = 15;
            // 
            // txtBSelect
            // 
            this.txtBSelect.Location = new System.Drawing.Point(194, 38);
            this.txtBSelect.Name = "txtBSelect";
            this.txtBSelect.Size = new System.Drawing.Size(39, 23);
            this.txtBSelect.TabIndex = 17;
            this.txtBSelect.TextChanged += new System.EventHandler(this.txtBSelect_TextChanged);
            this.txtBSelect.Enter += new System.EventHandler(this.txtB_Enter);
            // 
            // Exo_3_2ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 274);
            this.Controls.Add(this.txtBSelect);
            this.Controls.Add(this.txtBText);
            this.Controls.Add(this.txtBSelected);
            this.Controls.Add(this.txtBItems);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblProp);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lstBList);
            this.Controls.Add(this.lblLst);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBNewElem);
            this.Controls.Add(this.lblNewElem);
            this.Name = "Exo_3_2ListBox";
            this.Text = "Les listes et leurs propriétés";
            this.Load += new System.EventHandler(this.Exo_3_2ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNewElem;
        private TextBox txtBNewElem;
        private Button btnAdd;
        private Label lblLst;
        private ListBox lstBList;
        private Label lblIndex;
        private Button btnSelect;
        private Button btnClean;
        private Label lblProp;
        private Label lblItems;
        private Label lblSelect;
        private Label lblText;
        private TextBox txtBItems;
        private TextBox txtBSelected;
        private TextBox txtBText;
        private TextBox txtBSelect;
    }
}