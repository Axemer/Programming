namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.SlectedLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.FullNameLable = new System.Windows.Forms.Label();
            this.SelectedPanel = new System.Windows.Forms.Panel();
            this.DiscountsRemoveButton = new System.Windows.Forms.Button();
            this.DiscountsAddButton = new System.Windows.Forms.Button();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.FullnameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SelectedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(3, 3);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 16);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(200, 368);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // SlectedLabel
            // 
            this.SlectedLabel.AutoSize = true;
            this.SlectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlectedLabel.Location = new System.Drawing.Point(3, 0);
            this.SlectedLabel.Name = "SlectedLabel";
            this.SlectedLabel.Size = new System.Drawing.Size(113, 13);
            this.SlectedLabel.TabIndex = 2;
            this.SlectedLabel.Text = "Selected Customer";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(3, 19);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID:";
            // 
            // FullNameLable
            // 
            this.FullNameLable.AutoSize = true;
            this.FullNameLable.Location = new System.Drawing.Point(3, 45);
            this.FullNameLable.Name = "FullNameLable";
            this.FullNameLable.Size = new System.Drawing.Size(52, 13);
            this.FullNameLable.TabIndex = 4;
            this.FullNameLable.Text = "Fullname:";
            // 
            // SelectedPanel
            // 
            this.SelectedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectedPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectedPanel.Controls.Add(this.DiscountsRemoveButton);
            this.SelectedPanel.Controls.Add(this.DiscountsAddButton);
            this.SelectedPanel.Controls.Add(this.DiscountsListBox);
            this.SelectedPanel.Controls.Add(this.IsPriorityCheckBox);
            this.SelectedPanel.Controls.Add(this.AddressControl);
            this.SelectedPanel.Controls.Add(this.FullnameTextBox);
            this.SelectedPanel.Controls.Add(this.IDTextBox);
            this.SelectedPanel.Controls.Add(this.FullNameLable);
            this.SelectedPanel.Controls.Add(this.DiscountsLabel);
            this.SelectedPanel.Controls.Add(this.SlectedLabel);
            this.SelectedPanel.Controls.Add(this.IDLabel);
            this.SelectedPanel.Location = new System.Drawing.Point(209, 3);
            this.SelectedPanel.Name = "SelectedPanel";
            this.SelectedPanel.Size = new System.Drawing.Size(403, 381);
            this.SelectedPanel.TabIndex = 6;
            // 
            // DiscountsRemoveButton
            // 
            this.DiscountsRemoveButton.Enabled = false;
            this.DiscountsRemoveButton.Location = new System.Drawing.Point(291, 289);
            this.DiscountsRemoveButton.Name = "DiscountsRemoveButton";
            this.DiscountsRemoveButton.Size = new System.Drawing.Size(75, 35);
            this.DiscountsRemoveButton.TabIndex = 16;
            this.DiscountsRemoveButton.Text = "Remove";
            this.DiscountsRemoveButton.UseVisualStyleBackColor = true;
            this.DiscountsRemoveButton.Click += new System.EventHandler(this.DiscountsRemoveButton_Click);
            // 
            // DiscountsAddButton
            // 
            this.DiscountsAddButton.Enabled = false;
            this.DiscountsAddButton.Location = new System.Drawing.Point(291, 242);
            this.DiscountsAddButton.Name = "DiscountsAddButton";
            this.DiscountsAddButton.Size = new System.Drawing.Size(75, 35);
            this.DiscountsAddButton.TabIndex = 15;
            this.DiscountsAddButton.Text = "Add";
            this.DiscountsAddButton.UseVisualStyleBackColor = true;
            this.DiscountsAddButton.Click += new System.EventHandler(this.DiscountsAddButton_Click);
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.Location = new System.Drawing.Point(6, 242);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.DiscountsListBox.Size = new System.Drawing.Size(279, 82);
            this.DiscountsListBox.TabIndex = 14;
            this.DiscountsListBox.SelectedIndexChanged += new System.EventHandler(this.DiscountsListBox_SelectedIndexChanged);
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Enabled = false;
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(199, 18);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(68, 17);
            this.IsPriorityCheckBox.TabIndex = 9;
            this.IsPriorityCheckBox.Text = "Is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            this.IsPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // AddressControl
            // 
            this.AddressControl.Address = null;
            this.AddressControl.Location = new System.Drawing.Point(6, 68);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(397, 157);
            this.AddressControl.TabIndex = 8;
            // 
            // FullnameTextBox
            // 
            this.FullnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullnameTextBox.Location = new System.Drawing.Point(61, 42);
            this.FullnameTextBox.Name = "FullnameTextBox";
            this.FullnameTextBox.Size = new System.Drawing.Size(339, 20);
            this.FullnameTextBox.TabIndex = 7;
            this.FullnameTextBox.TextChanged += new System.EventHandler(this.FullnameTextBox_TextChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(61, 16);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 6;
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountsLabel.Location = new System.Drawing.Point(3, 226);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(113, 13);
            this.DiscountsLabel.TabIndex = 13;
            this.DiscountsLabel.Text = "Discounts";
            this.DiscountsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(3, 389);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 35);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Location = new System.Drawing.Point(84, 389);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 35);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SelectedPanel);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.CustomersLabel);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(615, 427);
            this.SelectedPanel.ResumeLayout(false);
            this.SelectedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label SlectedLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label FullNameLable;
        private System.Windows.Forms.Panel SelectedPanel;
        private System.Windows.Forms.TextBox FullnameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.CheckBox IsPriorityCheckBox;
        private System.Windows.Forms.Label DiscountsLabel;
        private System.Windows.Forms.Button DiscountsRemoveButton;
        private System.Windows.Forms.Button DiscountsAddButton;
        private System.Windows.Forms.ListBox DiscountsListBox;
    }
}
