namespace ProjectGUI
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.item2TextBox = new System.Windows.Forms.RichTextBox();
            this.item4TextBox = new System.Windows.Forms.RichTextBox();
            this.item5TextBox = new System.Windows.Forms.RichTextBox();
            this.customerIDComboBox = new System.Windows.Forms.ComboBox();
            this.gameIDComboBox = new System.Windows.Forms.ComboBox();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.item2Label = new System.Windows.Forms.Label();
            this.item4Label = new System.Windows.Forms.Label();
            this.item5Label = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.gameIDLabel = new System.Windows.Forms.Label();
            this.item3Label = new System.Windows.Forms.Label();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.item3TextBox = new System.Windows.Forms.RichTextBox();
            this.item1Label = new System.Windows.Forms.Label();
            this.item1TextBox = new System.Windows.Forms.RichTextBox();
            this.item6Label = new System.Windows.Forms.Label();
            this.item6TextBox = new System.Windows.Forms.RichTextBox();
            this.item7Label = new System.Windows.Forms.Label();
            this.item7TextBox = new System.Windows.Forms.RichTextBox();
            this.item8Label = new System.Windows.Forms.Label();
            this.item8TextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.displayAllToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.undeleteToolStripMenuItem,
            this.purgeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // undeleteToolStripMenuItem
            // 
            this.undeleteToolStripMenuItem.Name = "undeleteToolStripMenuItem";
            this.undeleteToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.undeleteToolStripMenuItem.Text = "Undelete";
            this.undeleteToolStripMenuItem.Click += new System.EventHandler(this.undeleteToolStripMenuItem_Click);
            // 
            // purgeToolStripMenuItem
            // 
            this.purgeToolStripMenuItem.Name = "purgeToolStripMenuItem";
            this.purgeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.purgeToolStripMenuItem.Text = "Purge";
            this.purgeToolStripMenuItem.Click += new System.EventHandler(this.purgeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // displayAllToolStripMenuItem
            // 
            this.displayAllToolStripMenuItem.Name = "displayAllToolStripMenuItem";
            this.displayAllToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.displayAllToolStripMenuItem.Text = "&Display All";
            this.displayAllToolStripMenuItem.Click += new System.EventHandler(this.displayAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumberTextBox.Location = new System.Drawing.Point(156, 53);
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.ReadOnly = true;
            this.idNumberTextBox.Size = new System.Drawing.Size(215, 27);
            this.idNumberTextBox.TabIndex = 1;
            this.idNumberTextBox.Text = "";
            this.idNumberTextBox.TextChanged += new System.EventHandler(this.idNumberTextBox_TextChanged);
            // 
            // item2TextBox
            // 
            this.item2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item2TextBox.Location = new System.Drawing.Point(129, 152);
            this.item2TextBox.Name = "item2TextBox";
            this.item2TextBox.Size = new System.Drawing.Size(215, 27);
            this.item2TextBox.TabIndex = 3;
            this.item2TextBox.Text = "";
            this.item2TextBox.TextChanged += new System.EventHandler(this.item2TextBox_TextChanged);
            // 
            // item4TextBox
            // 
            this.item4TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item4TextBox.Location = new System.Drawing.Point(129, 218);
            this.item4TextBox.Name = "item4TextBox";
            this.item4TextBox.Size = new System.Drawing.Size(215, 27);
            this.item4TextBox.TabIndex = 5;
            this.item4TextBox.Text = "";
            this.item4TextBox.TextChanged += new System.EventHandler(this.item4TextBox_TextChanged);
            // 
            // item5TextBox
            // 
            this.item5TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item5TextBox.Location = new System.Drawing.Point(129, 251);
            this.item5TextBox.Name = "item5TextBox";
            this.item5TextBox.Size = new System.Drawing.Size(215, 27);
            this.item5TextBox.TabIndex = 6;
            this.item5TextBox.Text = "";
            this.item5TextBox.TextChanged += new System.EventHandler(this.item5TextBox_TextChanged);
            // 
            // customerIDComboBox
            // 
            this.customerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDComboBox.FormattingEnabled = true;
            this.customerIDComboBox.Location = new System.Drawing.Point(481, 218);
            this.customerIDComboBox.Name = "customerIDComboBox";
            this.customerIDComboBox.Size = new System.Drawing.Size(215, 28);
            this.customerIDComboBox.TabIndex = 10;
            this.customerIDComboBox.SelectedIndexChanged += new System.EventHandler(this.customerIDComboBox_SelectedIndexChanged);
            // 
            // gameIDComboBox
            // 
            this.gameIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameIDComboBox.FormattingEnabled = true;
            this.gameIDComboBox.Location = new System.Drawing.Point(481, 252);
            this.gameIDComboBox.Name = "gameIDComboBox";
            this.gameIDComboBox.Size = new System.Drawing.Size(215, 28);
            this.gameIDComboBox.TabIndex = 11;
            this.gameIDComboBox.SelectedIndexChanged += new System.EventHandler(this.gameIDComboBox_SelectedIndexChanged);
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.AutoSize = true;
            this.idNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumberLabel.Location = new System.Drawing.Point(12, 56);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(138, 20);
            this.idNumberLabel.TabIndex = 11;
            this.idNumberLabel.Text = "Customer Number";
            // 
            // item2Label
            // 
            this.item2Label.AutoSize = true;
            this.item2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item2Label.Location = new System.Drawing.Point(11, 155);
            this.item2Label.Name = "item2Label";
            this.item2Label.Size = new System.Drawing.Size(86, 20);
            this.item2Label.TabIndex = 12;
            this.item2Label.Text = "Last Name";
            // 
            // item4Label
            // 
            this.item4Label.AutoSize = true;
            this.item4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item4Label.Location = new System.Drawing.Point(11, 221);
            this.item4Label.Name = "item4Label";
            this.item4Label.Size = new System.Drawing.Size(35, 20);
            this.item4Label.TabIndex = 13;
            this.item4Label.Text = "City";
            // 
            // item5Label
            // 
            this.item5Label.AutoSize = true;
            this.item5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item5Label.Location = new System.Drawing.Point(11, 255);
            this.item5Label.Name = "item5Label";
            this.item5Label.Size = new System.Drawing.Size(48, 20);
            this.item5Label.TabIndex = 14;
            this.item5Label.Text = "State";
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDLabel.Location = new System.Drawing.Point(363, 221);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(95, 20);
            this.customerIDLabel.TabIndex = 15;
            this.customerIDLabel.Text = "CustomerID";
            // 
            // gameIDLabel
            // 
            this.gameIDLabel.AutoSize = true;
            this.gameIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameIDLabel.Location = new System.Drawing.Point(363, 255);
            this.gameIDLabel.Name = "gameIDLabel";
            this.gameIDLabel.Size = new System.Drawing.Size(70, 20);
            this.gameIDLabel.TabIndex = 16;
            this.gameIDLabel.Text = "GameID";
            // 
            // item3Label
            // 
            this.item3Label.AutoSize = true;
            this.item3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item3Label.Location = new System.Drawing.Point(11, 188);
            this.item3Label.Name = "item3Label";
            this.item3Label.Size = new System.Drawing.Size(68, 20);
            this.item3Label.TabIndex = 17;
            this.item3Label.Text = "Address";
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionLabel.Location = new System.Drawing.Point(12, 320);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(207, 20);
            this.connectionLabel.TabIndex = 21;
            this.connectionLabel.Text = "Connection Status: Pending";
            this.connectionLabel.Click += new System.EventHandler(this.connectionLabel_Click);
            // 
            // item3TextBox
            // 
            this.item3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item3TextBox.Location = new System.Drawing.Point(129, 185);
            this.item3TextBox.Name = "item3TextBox";
            this.item3TextBox.Size = new System.Drawing.Size(215, 27);
            this.item3TextBox.TabIndex = 4;
            this.item3TextBox.Text = "";
            this.item3TextBox.TextChanged += new System.EventHandler(this.item3TextBox_TextChanged);
            // 
            // item1Label
            // 
            this.item1Label.AutoSize = true;
            this.item1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1Label.Location = new System.Drawing.Point(11, 122);
            this.item1Label.Name = "item1Label";
            this.item1Label.Size = new System.Drawing.Size(86, 20);
            this.item1Label.TabIndex = 24;
            this.item1Label.Text = "First Name";
            // 
            // item1TextBox
            // 
            this.item1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1TextBox.Location = new System.Drawing.Point(129, 119);
            this.item1TextBox.Name = "item1TextBox";
            this.item1TextBox.Size = new System.Drawing.Size(215, 27);
            this.item1TextBox.TabIndex = 2;
            this.item1TextBox.Text = "";
            // 
            // item6Label
            // 
            this.item6Label.AutoSize = true;
            this.item6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item6Label.Location = new System.Drawing.Point(363, 122);
            this.item6Label.Name = "item6Label";
            this.item6Label.Size = new System.Drawing.Size(31, 20);
            this.item6Label.TabIndex = 26;
            this.item6Label.Text = "Zip";
            // 
            // item6TextBox
            // 
            this.item6TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item6TextBox.Location = new System.Drawing.Point(481, 119);
            this.item6TextBox.Name = "item6TextBox";
            this.item6TextBox.Size = new System.Drawing.Size(215, 27);
            this.item6TextBox.TabIndex = 7;
            this.item6TextBox.Text = "";
            // 
            // item7Label
            // 
            this.item7Label.AutoSize = true;
            this.item7Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item7Label.Location = new System.Drawing.Point(363, 155);
            this.item7Label.Name = "item7Label";
            this.item7Label.Size = new System.Drawing.Size(55, 20);
            this.item7Label.TabIndex = 28;
            this.item7Label.Text = "Phone";
            // 
            // item7TextBox
            // 
            this.item7TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item7TextBox.Location = new System.Drawing.Point(481, 152);
            this.item7TextBox.Name = "item7TextBox";
            this.item7TextBox.Size = new System.Drawing.Size(215, 27);
            this.item7TextBox.TabIndex = 8;
            this.item7TextBox.Text = "";
            // 
            // item8Label
            // 
            this.item8Label.AutoSize = true;
            this.item8Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item8Label.Location = new System.Drawing.Point(363, 188);
            this.item8Label.Name = "item8Label";
            this.item8Label.Size = new System.Drawing.Size(48, 20);
            this.item8Label.TabIndex = 30;
            this.item8Label.Text = "Email";
            // 
            // item8TextBox
            // 
            this.item8TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item8TextBox.Location = new System.Drawing.Point(481, 185);
            this.item8TextBox.Name = "item8TextBox";
            this.item8TextBox.Size = new System.Drawing.Size(215, 27);
            this.item8TextBox.TabIndex = 9;
            this.item8TextBox.Text = "";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 349);
            this.Controls.Add(this.item8Label);
            this.Controls.Add(this.item8TextBox);
            this.Controls.Add(this.item7Label);
            this.Controls.Add(this.item7TextBox);
            this.Controls.Add(this.item6Label);
            this.Controls.Add(this.item6TextBox);
            this.Controls.Add(this.item1Label);
            this.Controls.Add(this.item1TextBox);
            this.Controls.Add(this.item3TextBox);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.item3Label);
            this.Controls.Add(this.gameIDLabel);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.item5Label);
            this.Controls.Add(this.item4Label);
            this.Controls.Add(this.item2Label);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.gameIDComboBox);
            this.Controls.Add(this.customerIDComboBox);
            this.Controls.Add(this.item5TextBox);
            this.Controls.Add(this.item4TextBox);
            this.Controls.Add(this.item2TextBox);
            this.Controls.Add(this.idNumberTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "Game Order Data";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Label connectionLabel;
        public System.Windows.Forms.RichTextBox idNumberTextBox;
        public System.Windows.Forms.RichTextBox item2TextBox;
        public System.Windows.Forms.RichTextBox item4TextBox;
        public System.Windows.Forms.RichTextBox item5TextBox;
        public System.Windows.Forms.ComboBox customerIDComboBox;
        public System.Windows.Forms.ComboBox gameIDComboBox;
        public System.Windows.Forms.RichTextBox item3TextBox;
        public System.Windows.Forms.RichTextBox item1TextBox;
        public System.Windows.Forms.RichTextBox item6TextBox;
        public System.Windows.Forms.RichTextBox item7TextBox;
        public System.Windows.Forms.RichTextBox item8TextBox;
        public System.Windows.Forms.Label idNumberLabel;
        public System.Windows.Forms.Label item2Label;
        public System.Windows.Forms.Label item4Label;
        public System.Windows.Forms.Label item5Label;
        public System.Windows.Forms.Label customerIDLabel;
        public System.Windows.Forms.Label gameIDLabel;
        public System.Windows.Forms.Label item3Label;
        public System.Windows.Forms.Label item1Label;
        public System.Windows.Forms.Label item6Label;
        public System.Windows.Forms.Label item7Label;
        public System.Windows.Forms.Label item8Label;
    }
}

