namespace vert_proto
{
    partial class MainForm
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
            this.LstShopping = new System.Windows.Forms.ListBox();
            this.TxtShopping = new System.Windows.Forms.TextBox();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdRemove = new System.Windows.Forms.Button();
            this.CmdUp = new System.Windows.Forms.Button();
            this.CmdDown = new System.Windows.Forms.Button();
            this.CmbBoxList = new System.Windows.Forms.ComboBox();
            this.CmdAddList = new System.Windows.Forms.Button();
            this.CmdRemoveList = new System.Windows.Forms.Button();
            this.CmdHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstShopping
            // 
            this.LstShopping.FormattingEnabled = true;
            this.LstShopping.ItemHeight = 15;
            this.LstShopping.Location = new System.Drawing.Point(12, 160);
            this.LstShopping.Name = "LstShopping";
            this.LstShopping.Size = new System.Drawing.Size(392, 379);
            this.LstShopping.TabIndex = 0;
            // 
            // TxtShopping
            // 
            this.TxtShopping.Location = new System.Drawing.Point(12, 121);
            this.TxtShopping.Name = "TxtShopping";
            this.TxtShopping.Size = new System.Drawing.Size(392, 23);
            this.TxtShopping.TabIndex = 1;
            // 
            // CmdAdd
            // 
            this.CmdAdd.Location = new System.Drawing.Point(410, 121);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(183, 23);
            this.CmdAdd.TabIndex = 2;
            this.CmdAdd.Text = "Add";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.Enabled = false;
            this.CmdEdit.Location = new System.Drawing.Point(410, 160);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(183, 23);
            this.CmdEdit.TabIndex = 3;
            this.CmdEdit.Text = "Edit";
            this.CmdEdit.UseVisualStyleBackColor = true;
            // 
            // CmdRemove
            // 
            this.CmdRemove.Enabled = false;
            this.CmdRemove.Location = new System.Drawing.Point(411, 189);
            this.CmdRemove.Name = "CmdRemove";
            this.CmdRemove.Size = new System.Drawing.Size(183, 23);
            this.CmdRemove.TabIndex = 4;
            this.CmdRemove.Text = "Remove";
            this.CmdRemove.UseVisualStyleBackColor = true;
            // 
            // CmdUp
            // 
            this.CmdUp.Enabled = false;
            this.CmdUp.Location = new System.Drawing.Point(410, 321);
            this.CmdUp.Name = "CmdUp";
            this.CmdUp.Size = new System.Drawing.Size(183, 23);
            this.CmdUp.TabIndex = 5;
            this.CmdUp.Text = "Up";
            this.CmdUp.UseVisualStyleBackColor = true;
            // 
            // CmdDown
            // 
            this.CmdDown.Enabled = false;
            this.CmdDown.Location = new System.Drawing.Point(410, 350);
            this.CmdDown.Name = "CmdDown";
            this.CmdDown.Size = new System.Drawing.Size(183, 23);
            this.CmdDown.TabIndex = 6;
            this.CmdDown.Text = "Down";
            this.CmdDown.UseVisualStyleBackColor = true;
            // 
            // CmbBoxList
            // 
            this.CmbBoxList.Enabled = false;
            this.CmbBoxList.FormattingEnabled = true;
            this.CmbBoxList.Items.AddRange(new object[] {
            "Default"});
            this.CmbBoxList.Location = new System.Drawing.Point(12, 12);
            this.CmbBoxList.Name = "CmbBoxList";
            this.CmbBoxList.Size = new System.Drawing.Size(392, 23);
            this.CmbBoxList.TabIndex = 7;
            // 
            // CmdAddList
            // 
            this.CmdAddList.Enabled = false;
            this.CmdAddList.Location = new System.Drawing.Point(410, 12);
            this.CmdAddList.Name = "CmdAddList";
            this.CmdAddList.Size = new System.Drawing.Size(183, 23);
            this.CmdAddList.TabIndex = 8;
            this.CmdAddList.Text = "Add List";
            this.CmdAddList.UseVisualStyleBackColor = true;
            // 
            // CmdRemoveList
            // 
            this.CmdRemoveList.Enabled = false;
            this.CmdRemoveList.Location = new System.Drawing.Point(410, 41);
            this.CmdRemoveList.Name = "CmdRemoveList";
            this.CmdRemoveList.Size = new System.Drawing.Size(183, 23);
            this.CmdRemoveList.TabIndex = 9;
            this.CmdRemoveList.Text = "Remove list";
            this.CmdRemoveList.UseVisualStyleBackColor = true;
            // 
            // CmdHistory
            // 
            this.CmdHistory.Enabled = false;
            this.CmdHistory.Location = new System.Drawing.Point(411, 516);
            this.CmdHistory.Name = "CmdHistory";
            this.CmdHistory.Size = new System.Drawing.Size(183, 23);
            this.CmdHistory.TabIndex = 10;
            this.CmdHistory.Text = "Done items";
            this.CmdHistory.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 551);
            this.Controls.Add(this.CmdHistory);
            this.Controls.Add(this.CmdRemoveList);
            this.Controls.Add(this.CmdAddList);
            this.Controls.Add(this.CmbBoxList);
            this.Controls.Add(this.CmdDown);
            this.Controls.Add(this.CmdUp);
            this.Controls.Add(this.CmdRemove);
            this.Controls.Add(this.CmdEdit);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.TxtShopping);
            this.Controls.Add(this.LstShopping);
            this.Name = "MainForm";
            this.Text = "Einkaufshilfe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LstShopping;
        private TextBox TxtShopping;
        private Button CmdAdd;
        private Button CmdEdit;
        private Button CmdRemove;
        private Button CmdUp;
        private Button CmdDown;
        private ComboBox CmbBoxList;
        private Button CmdAddList;
        private Button CmdRemoveList;
        private Button CmdHistory;
    }
}