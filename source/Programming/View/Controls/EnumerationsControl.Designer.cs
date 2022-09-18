namespace Programming.View.Controls
{
    partial class EnumerationsControl
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
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.ChooseValuelabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ChooseEnumlabel = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.EnumGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumGroupBox.Controls.Add(this.ChooseValuelabel);
            this.EnumGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumGroupBox.Controls.Add(this.ChooseEnumlabel);
            this.EnumGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumGroupBox.Location = new System.Drawing.Point(7, 7);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Size = new System.Drawing.Size(462, 210);
            this.EnumGroupBox.TabIndex = 7;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumerations";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(305, 32);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(55, 15);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 15;
            this.ValuesListBox.Location = new System.Drawing.Point(159, 50);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(140, 139);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // ChooseValuelabel
            // 
            this.ChooseValuelabel.AutoSize = true;
            this.ChooseValuelabel.Location = new System.Drawing.Point(159, 32);
            this.ChooseValuelabel.Name = "ChooseValuelabel";
            this.ChooseValuelabel.Size = new System.Drawing.Size(81, 15);
            this.ChooseValuelabel.TabIndex = 4;
            this.ChooseValuelabel.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 15;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Color",
            "Education type",
            "Genre",
            "Manufacture",
            "Seasons",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(13, 50);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(140, 139);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ChooseEnumlabel
            // 
            this.ChooseEnumlabel.AutoSize = true;
            this.ChooseEnumlabel.Location = new System.Drawing.Point(13, 32);
            this.ChooseEnumlabel.Name = "ChooseEnumlabel";
            this.ChooseEnumlabel.Size = new System.Drawing.Size(121, 15);
            this.ChooseEnumlabel.TabIndex = 3;
            this.ChooseEnumlabel.Text = "Choose enumeration:";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(305, 50);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(100, 23);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumGroupBox);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(477, 225);
            this.EnumGroupBox.ResumeLayout(false);
            this.EnumGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EnumGroupBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label ChooseValuelabel;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label ChooseEnumlabel;
        private System.Windows.Forms.TextBox IntValueTextBox;
    }
}
