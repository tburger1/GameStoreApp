namespace ProjectGUI
{
    partial class DisplayForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.selectItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectItemGroupBox
            // 
            this.selectItemGroupBox.Controls.Add(this.gameRadioButton);
            this.selectItemGroupBox.Controls.Add(this.customerRadioButton);
            this.selectItemGroupBox.Controls.Add(this.orderRadioButton);
            this.selectItemGroupBox.Location = new System.Drawing.Point(12, 12);
            this.selectItemGroupBox.Name = "selectItemGroupBox";
            this.selectItemGroupBox.Size = new System.Drawing.Size(263, 63);
            this.selectItemGroupBox.TabIndex = 0;
            this.selectItemGroupBox.TabStop = false;
            this.selectItemGroupBox.Text = "Select Item To Display";
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
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(290, 470);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 29);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Location = new System.Drawing.Point(12, 81);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.Size = new System.Drawing.Size(716, 369);
            this.itemDataGridView.TabIndex = 2;
            this.itemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataGridView_CellContentClick);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 521);
            this.Controls.Add(this.itemDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectItemGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayForm";
            this.Text = "Display All Records";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.selectItemGroupBox.ResumeLayout(false);
            this.selectItemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox selectItemGroupBox;
        private System.Windows.Forms.RadioButton gameRadioButton;
        private System.Windows.Forms.RadioButton customerRadioButton;
        private System.Windows.Forms.RadioButton orderRadioButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView itemDataGridView;
    }
}