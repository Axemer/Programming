namespace Individual_Task.View.Controls
{
    partial class SelectedDataControl
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
            this.SelectedProductGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.ManyfacturerTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedProductGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedProductGroupBox
            // 
            this.SelectedProductGroupBox.Controls.Add(this.CategoryComboBox);
            this.SelectedProductGroupBox.Controls.Add(this.QuantityLabel);
            this.SelectedProductGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectedProductGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SelectedProductGroupBox.Controls.Add(this.NameLabel);
            this.SelectedProductGroupBox.Controls.Add(this.QuantityTextBox);
            this.SelectedProductGroupBox.Controls.Add(this.ManyfacturerTextBox);
            this.SelectedProductGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedProductGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SelectedProductGroupBox.Name = "SelectedProductGroupBox";
            this.SelectedProductGroupBox.Size = new System.Drawing.Size(400, 130);
            this.SelectedProductGroupBox.TabIndex = 5;
            this.SelectedProductGroupBox.TabStop = false;
            this.SelectedProductGroupBox.Text = "Выбранный Товар";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(96, 70);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(100, 21);
            this.CategoryComboBox.TabIndex = 8;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(21, 100);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(69, 13);
            this.QuantityLabel.TabIndex = 7;
            this.QuantityLabel.Text = "Количество:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(27, 74);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(63, 13);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Категория:";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 48);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(89, 13);
            this.ManufacturerLabel.TabIndex = 5;
            this.ManufacturerLabel.Text = "Производитель:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(30, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Название:";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(96, 97);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityTextBox.TabIndex = 3;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            // 
            // ManyfacturerTextBox
            // 
            this.ManyfacturerTextBox.Location = new System.Drawing.Point(96, 45);
            this.ManyfacturerTextBox.Name = "ManyfacturerTextBox";
            this.ManyfacturerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ManyfacturerTextBox.TabIndex = 1;
            this.ManyfacturerTextBox.TextChanged += new System.EventHandler(this.ManyfacturerTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(96, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // SelectedDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedProductGroupBox);
            this.Name = "SelectedDataControl";
            this.Size = new System.Drawing.Size(400, 130);
            this.SelectedProductGroupBox.ResumeLayout(false);
            this.SelectedProductGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectedProductGroupBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox ManyfacturerTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}
