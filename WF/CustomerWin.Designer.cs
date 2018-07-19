namespace WF
{
    partial class CustomerWin
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
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.GetCustomersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(12, 28);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(240, 21);
            this.CustomerComboBox.TabIndex = 0;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(12, 195);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.Size = new System.Drawing.Size(514, 243);
            this.CustomerGridView.TabIndex = 1;
            // 
            // GetCustomersButton
            // 
            this.GetCustomersButton.Location = new System.Drawing.Point(694, 28);
            this.GetCustomersButton.Name = "GetCustomersButton";
            this.GetCustomersButton.Size = new System.Drawing.Size(94, 33);
            this.GetCustomersButton.TabIndex = 2;
            this.GetCustomersButton.Text = "Get Customers";
            this.GetCustomersButton.UseVisualStyleBackColor = true;
            this.GetCustomersButton.Click += new System.EventHandler(this.GetCustomersButton_Click);
            // 
            // CustomerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetCustomersButton);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.CustomerComboBox);
            this.Name = "CustomerWin";
            this.Text = "CustomerWin";
            this.Load += new System.EventHandler(this.CustomerWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.Button GetCustomersButton;
    }
}