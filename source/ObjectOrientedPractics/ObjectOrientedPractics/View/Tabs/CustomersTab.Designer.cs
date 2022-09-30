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
            this.AdddressLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(3, 0);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 16);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(200, 342);
            this.CustomersListBox.TabIndex = 1;
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
            // AdddressLabel
            // 
            this.AdddressLabel.AutoSize = true;
            this.AdddressLabel.Location = new System.Drawing.Point(3, 71);
            this.AdddressLabel.Name = "AdddressLabel";
            this.AdddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AdddressLabel.TabIndex = 5;
            this.AdddressLabel.Text = "Address:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.FullNameLable);
            this.panel1.Controls.Add(this.SlectedLabel);
            this.panel1.Controls.Add(this.AdddressLabel);
            this.panel1.Controls.Add(this.IDLabel);
            this.panel1.Location = new System.Drawing.Point(209, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 137);
            this.panel1.TabIndex = 6;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel2.Location = new System.Drawing.Point(209, 146);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(358, 212);
            this.Panel2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(294, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 68);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(294, 69);
            this.textBox3.TabIndex = 8;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 364);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(84, 364);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.CustomersLabel);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(570, 427);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label SlectedLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label FullNameLable;
        private System.Windows.Forms.Label AdddressLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
    }
}
