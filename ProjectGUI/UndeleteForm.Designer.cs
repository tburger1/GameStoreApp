namespace ProjectGUI
{
    partial class UndeleteForm
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
            this.itemGroupBox = new System.Windows.Forms.GroupBox();
            this.gameRadioButton = new System.Windows.Forms.RadioButton();
            this.customerRadioButton = new System.Windows.Forms.RadioButton();
            this.orderRadioButton = new System.Windows.Forms.RadioButton();
            this.undeleteItemLabel = new System.Windows.Forms.Label();
            this.undeleteComboBox = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.itemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemGroupBox
            // 
            this.itemGroupBox.Controls.Add(this.gameRadioButton);
            this.itemGroupBox.Controls.Add(this.customerRadioButton);
            this.itemGroupBox.Controls.Add(this.orderRadioButton);
            this.itemGroupBox.Location = new System.Drawing.Point(29, 32);
            this.itemGroupBox.Name = "itemGroupBox";
            this.itemGroupBox.Size = new System.Drawing.Size(262, 63);
            this.itemGroupBox.TabIndex = 0;
            this.itemGroupBox.TabStop = false;
            this.itemGroupBox.Text = "Select Item To Undelete";
            this.itemGroupBox.Enter += new System.EventHandler(this.itemGroupBox_Enter);
            // 
            // gameRadioButton
            // 
            this.gameRadioButton.AutoSize = true;
            this.gameRadioButton.Location = new System.Drawing.Point(181, 25);
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
            this.customerRadioButton.Location = new System.Drawing.Point(79, 25);
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
            this.orderRadioButton.Location = new System.Drawing.Point(6, 25);
            this.orderRadioButton.Name = "orderRadioButton";
            this.orderRadioButton.Size = new System.Drawing.Size(67, 24);
            this.orderRadioButton.TabIndex = 0;
            this.orderRadioButton.TabStop = true;
            this.orderRadioButton.Text = "Order";
            this.orderRadioButton.UseVisualStyleBackColor = true;
            this.orderRadioButton.CheckedChanged += new System.EventHandler(this.orderRadioButton_CheckedChanged);
            // 
            // undeleteItemLabel
            // 
            this.undeleteItemLabel.AutoSize = true;
            this.undeleteItemLabel.Location = new System.Drawing.Point(25, 184);
            this.undeleteItemLabel.Name = "undeleteItemLabel";
            this.undeleteItemLabel.Size = new System.Drawing.Size(113, 20);
            this.undeleteItemLabel.TabIndex = 1;
            this.undeleteItemLabel.Text = "Order Number:";
            this.undeleteItemLabel.Click += new System.EventHandler(this.undeleteItemLabel_Click);
            // 
            // undeleteComboBox
            // 
            this.undeleteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.undeleteComboBox.FormattingEnabled = true;
            this.undeleteComboBox.Location = new System.Drawing.Point(173, 181);
            this.undeleteComboBox.Name = "undeleteComboBox";
            this.undeleteComboBox.Size = new System.Drawing.Size(328, 28);
            this.undeleteComboBox.TabIndex = 2;
            this.undeleteComboBox.SelectedIndexChanged += new System.EventHandler(this.undeleteComboBox_SelectedIndexChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(366, 45);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(118, 48);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(366, 110);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(118, 48);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UndeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 245);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.undeleteComboBox);
            this.Controls.Add(this.undeleteItemLabel);
            this.Controls.Add(this.itemGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UndeleteForm";
            this.Text = "Undelete";
            this.Load += new System.EventHandler(this.UndeleteForm_Load);
            this.itemGroupBox.ResumeLayout(false);
            this.itemGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox itemGroupBox;
        private System.Windows.Forms.RadioButton orderRadioButton;
        private System.Windows.Forms.RadioButton gameRadioButton;
        private System.Windows.Forms.RadioButton customerRadioButton;
        private System.Windows.Forms.Label undeleteItemLabel;
        private System.Windows.Forms.ComboBox undeleteComboBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
    }
}