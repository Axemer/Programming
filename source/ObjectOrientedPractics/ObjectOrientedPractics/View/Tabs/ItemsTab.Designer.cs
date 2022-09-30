namespace ObjectOrientedPractics.View
{
    partial class ItemsTab
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
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 28);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(230, 355);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Items";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 385);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 38);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(87, 385);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 38);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(3, 9);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(85, 13);
            this.SelectedItemLabel.TabIndex = 4;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(3, 54);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(31, 13);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(3, 28);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 6;
            this.IDLabel.Text = "ID:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 87);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 227);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 8;
            this.DescriptionLabel.Text = "Description:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.DescriptionLabel);
            this.panel1.Controls.Add(this.SelectedItemLabel);
            this.panel1.Controls.Add(this.IDLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.CostLabel);
            this.panel1.Location = new System.Drawing.Point(239, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 420);
            this.panel1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 103);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(312, 111);
            this.textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 243);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(312, 137);
            this.textBox3.TabIndex = 13;
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsListBox);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(570, 427);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}
