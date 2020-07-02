namespace ProjectGUI
{
    partial class OpenForm
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
            this.openItemLabel = new System.Windows.Forms.Label();
            this.openItemComboBox = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.selectItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectItemGroupBox
            // 
            this.selectItemGroupBox.Controls.Add(this.gameRadioButton);
            this.selectItemGroupBox.Controls.Add(this.customerRadioButton);
            this.selectItemGroupBox.Controls.Add(this.orderRadioButton);
            this.selectItemGroupBox.Location = new System.Drawing.Point(29, 32);
            this.selectItemGroupBox.Name = "selectItemGroupBox";
            this.selectItemGroupBox.Size = new System.Drawing.Size(262, 63);
            this.selectItemGroupBox.TabIndex = 0;
            this.selectItemGroupBox.TabStop = false;
            this.selectItemGroupBox.Text = "Select Item To Open";
            this.selectItemGroupBox.Enter += new System.EventHandler(this.selectItemGroupBox_Enter);
            // 
            // gameRadioButton
            // 
            this.gameRadioButton.AutoSize = true;
            this.gameRadioButton.Location = new System.Drawing.Point(182, 25);
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
            this.customerRadioButton.Location = new System.Drawing.Point(80, 25);
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
            this.orderRadioButton.Location = new System.Drawing.Point(7, 26);
            this.orderRadioButton.Name = "orderRadioButton";
            this.orderRadioButton.Size = new System.Drawing.Size(67, 24);
            this.orderRadioButton.TabIndex = 0;
            this.orderRadioButton.TabStop = true;
            this.orderRadioButton.Text = "Order";
            this.orderRadioButton.UseVisualStyleBackColor = true;
            this.orderRadioButton.CheckedChanged += new System.EventHandler(this.orderRadioButton_CheckedChanged);
            // 
            // openItemLabel
            // 
            this.openItemLabel.AutoSize = true;
            this.openItemLabel.Location = new System.Drawing.Point(25, 184);
            this.openItemLabel.Name = "openItemLabel";
            this.openItemLabel.Size = new System.Drawing.Size(113, 20);
            this.openItemLabel.TabIndex = 1;
            this.openItemLabel.Text = "Order Number:";
            this.openItemLabel.Click += new System.EventHandler(this.openItemLabel_Click);
            // 
            // openItemComboBox
            // 
            this.openItemComboBox.FormattingEnabled = true;
            this.openItemComboBox.Location = new System.Drawing.Point(173, 181);
            this.openItemComboBox.Name = "openItemComboBox";
            this.openItemComboBox.Size = new System.Drawing.Size(328, 28);
            this.openItemComboBox.TabIndex = 2;
            this.openItemComboBox.SelectedIndexChanged += new System.EventHandler(this.openItemComboBox_SelectedIndexChanged);
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
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(366, 110);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(118, 48);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 245);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.openItemComboBox);
            this.Controls.Add(this.openItemLabel);
            this.Controls.Add(this.selectItemGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OpenForm";
            this.Text = "Open";
            this.Load += new System.EventHandler(this.OpenForm_Load);
            this.selectItemGroupBox.ResumeLayout(false);
            this.selectItemGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox selectItemGroupBox;
        private System.Windows.Forms.RadioButton orderRadioButton;
        private System.Windows.Forms.RadioButton gameRadioButton;
        private System.Windows.Forms.RadioButton customerRadioButton;
        private System.Windows.Forms.Label openItemLabel;
        private System.Windows.Forms.ComboBox openItemComboBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button CancelButton;
    }
}