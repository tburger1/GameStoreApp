namespace ProjectGUI
{
    partial class NewForm
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
            this.selectItemGroupBox = new System.Windows.Forms.GroupBox();
            this.gameRadioButton = new System.Windows.Forms.RadioButton();
            this.customerRadioButton = new System.Windows.Forms.RadioButton();
            this.orderRadioButton = new System.Windows.Forms.RadioButton();
            this.newItemlabel = new System.Windows.Forms.Label();
            this.newItemTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.selectItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectItemGroupBox
            // 
            this.selectItemGroupBox.Controls.Add(this.gameRadioButton);
            this.selectItemGroupBox.Controls.Add(this.customerRadioButton);
            this.selectItemGroupBox.Controls.Add(this.orderRadioButton);
            this.selectItemGroupBox.Location = new System.Drawing.Point(23, 23);
            this.selectItemGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectItemGroupBox.Name = "selectItemGroupBox";
            this.selectItemGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectItemGroupBox.Size = new System.Drawing.Size(263, 64);
            this.selectItemGroupBox.TabIndex = 0;
            this.selectItemGroupBox.TabStop = false;
            this.selectItemGroupBox.Text = "Select Item To Add";
            this.selectItemGroupBox.Enter += new System.EventHandler(this.selectItemGroupBox_Enter);
            // 
            // gameRadioButton
            // 
            this.gameRadioButton.AutoSize = true;
            this.gameRadioButton.Location = new System.Drawing.Point(187, 29);
            this.gameRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameRadioButton.Name = "gameRadioButton";
            this.gameRadioButton.Size = new System.Drawing.Size(71, 24);
            this.gameRadioButton.TabIndex = 2;
            this.gameRadioButton.TabStop = true;
            this.gameRadioButton.Text = "Game";
            this.gameRadioButton.UseVisualStyleBackColor = true;
            this.gameRadioButton.CheckedChanged += new System.EventHandler(this.gameRadioButton_CheckedChanged);
            // 
            // customerRadioButton
            // 
            this.customerRadioButton.AutoSize = true;
            this.customerRadioButton.Location = new System.Drawing.Point(83, 29);
            this.customerRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerRadioButton.Name = "customerRadioButton";
            this.customerRadioButton.Size = new System.Drawing.Size(96, 24);
            this.customerRadioButton.TabIndex = 1;
            this.customerRadioButton.TabStop = true;
            this.customerRadioButton.Text = "Customer";
            this.customerRadioButton.UseVisualStyleBackColor = true;
            this.customerRadioButton.CheckedChanged += new System.EventHandler(this.customerRadioButton_CheckedChanged);
            // 
            // orderRadioButton
            // 
            this.orderRadioButton.AutoSize = true;
            this.orderRadioButton.Location = new System.Drawing.Point(8, 29);
            this.orderRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderRadioButton.Name = "orderRadioButton";
            this.orderRadioButton.Size = new System.Drawing.Size(67, 24);
            this.orderRadioButton.TabIndex = 0;
            this.orderRadioButton.TabStop = true;
            this.orderRadioButton.Text = "Order";
            this.orderRadioButton.UseVisualStyleBackColor = true;
            this.orderRadioButton.CheckedChanged += new System.EventHandler(this.orderRadioButton_CheckedChanged);
            // 
            // newItemlabel
            // 
            this.newItemlabel.AutoSize = true;
            this.newItemlabel.Location = new System.Drawing.Point(19, 121);
            this.newItemlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newItemlabel.Name = "newItemlabel";
            this.newItemlabel.Size = new System.Drawing.Size(113, 20);
            this.newItemlabel.TabIndex = 1;
            this.newItemlabel.Text = "Order Number:";
            this.newItemlabel.Click += new System.EventHandler(this.newItemlabel_Click);
            // 
            // newItemTextBox
            // 
            this.newItemTextBox.Location = new System.Drawing.Point(169, 118);
            this.newItemTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newItemTextBox.Name = "newItemTextBox";
            this.newItemTextBox.Size = new System.Drawing.Size(146, 26);
            this.newItemTextBox.TabIndex = 2;
            this.newItemTextBox.TextChanged += new System.EventHandler(this.newItemTextBox_TextChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(358, 23);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(141, 53);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(358, 91);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(141, 53);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 20;
            this.itemListBox.Location = new System.Drawing.Point(23, 166);
            this.itemListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(476, 364);
            this.itemListBox.TabIndex = 6;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_SelectedIndexChanged);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 567);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.newItemTextBox);
            this.Controls.Add(this.newItemlabel);
            this.Controls.Add(this.selectItemGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewForm";
            this.Text = "New";
            this.Load += new System.EventHandler(this.NewForm_Load);
            this.selectItemGroupBox.ResumeLayout(false);
            this.selectItemGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox selectItemGroupBox;
        private System.Windows.Forms.Label newItemlabel;
        private System.Windows.Forms.TextBox newItemTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton gameRadioButton;
        private System.Windows.Forms.RadioButton customerRadioButton;
        private System.Windows.Forms.RadioButton orderRadioButton;
        private System.Windows.Forms.ListBox itemListBox;
    }
}