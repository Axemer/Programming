namespace Programming.View.Controls
{
    partial class RectangleCollisionControl
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
            this.RactangleCanvasPanel = new System.Windows.Forms.Panel();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.RactangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLable = new System.Windows.Forms.Label();
            this.IDLable = new System.Windows.Forms.Label();
            this.SelectedRactangleLabel = new System.Windows.Forms.Label();
            this.RactangleReduceButton = new System.Windows.Forms.Button();
            this.RactangleAddButton = new System.Windows.Forms.Button();
            this.RqctangleLabel = new System.Windows.Forms.Label();
            this.RactangleListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RactangleCanvasPanel
            // 
            this.RactangleCanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RactangleCanvasPanel.Location = new System.Drawing.Point(173, 29);
            this.RactangleCanvasPanel.Name = "RactangleCanvasPanel";
            this.RactangleCanvasPanel.Size = new System.Drawing.Size(309, 309);
            this.RactangleCanvasPanel.TabIndex = 31;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(67, 315);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 23);
            this.HeightTextBox.TabIndex = 30;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // RactangleWidthTextBox
            // 
            this.RactangleWidthTextBox.Location = new System.Drawing.Point(67, 286);
            this.RactangleWidthTextBox.Name = "RactangleWidthTextBox";
            this.RactangleWidthTextBox.Size = new System.Drawing.Size(100, 23);
            this.RactangleWidthTextBox.TabIndex = 29;
            this.RactangleWidthTextBox.TextChanged += new System.EventHandler(this.RactangleWidthTextBox_TextChanged);
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(67, 257);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(100, 23);
            this.YTextBox.TabIndex = 28;
            this.YTextBox.TextChanged += new System.EventHandler(this.YTextBox_TextChanged);
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(67, 228);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(100, 23);
            this.XTextBox.TabIndex = 27;
            this.XTextBox.TextChanged += new System.EventHandler(this.XTextBox_TextChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(67, 199);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 23);
            this.IDTextBox.TabIndex = 26;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(15, 318);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(46, 15);
            this.HeightLabel.TabIndex = 25;
            this.HeightLabel.Text = "Height:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(19, 289);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(42, 15);
            this.WidthLabel.TabIndex = 24;
            this.WidthLabel.Text = "Width:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(40, 260);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 15);
            this.YLabel.TabIndex = 23;
            this.YLabel.Text = "Y:";
            // 
            // XLable
            // 
            this.XLable.AutoSize = true;
            this.XLable.Location = new System.Drawing.Point(40, 231);
            this.XLable.Name = "XLable";
            this.XLable.Size = new System.Drawing.Size(17, 15);
            this.XLable.TabIndex = 22;
            this.XLable.Text = "X:";
            // 
            // IDLable
            // 
            this.IDLable.AutoSize = true;
            this.IDLable.Location = new System.Drawing.Point(40, 202);
            this.IDLable.Name = "IDLable";
            this.IDLable.Size = new System.Drawing.Size(21, 15);
            this.IDLable.TabIndex = 21;
            this.IDLable.Text = "ID:";
            // 
            // SelectedRactangleLabel
            // 
            this.SelectedRactangleLabel.AutoSize = true;
            this.SelectedRactangleLabel.Location = new System.Drawing.Point(6, 181);
            this.SelectedRactangleLabel.Name = "SelectedRactangleLabel";
            this.SelectedRactangleLabel.Size = new System.Drawing.Size(109, 15);
            this.SelectedRactangleLabel.TabIndex = 20;
            this.SelectedRactangleLabel.Text = "Selected Ractangle:";
            // 
            // RactangleReduceButton
            // 
            this.RactangleReduceButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RactangleReduceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RactangleReduceButton.FlatAppearance.BorderSize = 0;
            this.RactangleReduceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RactangleReduceButton.Location = new System.Drawing.Point(103, 144);
            this.RactangleReduceButton.Name = "RactangleReduceButton";
            this.RactangleReduceButton.Size = new System.Drawing.Size(30, 30);
            this.RactangleReduceButton.TabIndex = 19;
            this.RactangleReduceButton.UseVisualStyleBackColor = true;
            this.RactangleReduceButton.Click += new System.EventHandler(this.RactangleReduceButton_Click);
            // 
            // RactangleAddButton
            // 
            this.RactangleAddButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.RactangleAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RactangleAddButton.FlatAppearance.BorderSize = 0;
            this.RactangleAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RactangleAddButton.Location = new System.Drawing.Point(28, 144);
            this.RactangleAddButton.Name = "RactangleAddButton";
            this.RactangleAddButton.Size = new System.Drawing.Size(30, 30);
            this.RactangleAddButton.TabIndex = 18;
            this.RactangleAddButton.UseVisualStyleBackColor = true;
            this.RactangleAddButton.Click += new System.EventHandler(this.RactangleAddButton_Click);
            // 
            // RqctangleLabel
            // 
            this.RqctangleLabel.AutoSize = true;
            this.RqctangleLabel.Location = new System.Drawing.Point(11, 11);
            this.RqctangleLabel.Name = "RqctangleLabel";
            this.RqctangleLabel.Size = new System.Drawing.Size(62, 15);
            this.RqctangleLabel.TabIndex = 17;
            this.RqctangleLabel.Text = "Ractangle:";
            // 
            // RactangleListBox
            // 
            this.RactangleListBox.ColumnWidth = 2;
            this.RactangleListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.RactangleListBox.FormattingEnabled = true;
            this.RactangleListBox.HorizontalExtent = 100;
            this.RactangleListBox.HorizontalScrollbar = true;
            this.RactangleListBox.ItemHeight = 15;
            this.RactangleListBox.Location = new System.Drawing.Point(11, 29);
            this.RactangleListBox.Name = "RactangleListBox";
            this.RactangleListBox.Size = new System.Drawing.Size(156, 109);
            this.RactangleListBox.TabIndex = 16;
            this.RactangleListBox.SelectedIndexChanged += new System.EventHandler(this.RactangleListBox_SelectedIndexChanged);
            this.RactangleListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.RactangleListBox.MeasureItem += lst_MeasureItem;
            this.RactangleListBox.DrawItem += lst_DrawItem;
            // 
            // RectangleCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RactangleCanvasPanel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.RactangleWidthTextBox);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLable);
            this.Controls.Add(this.IDLable);
            this.Controls.Add(this.SelectedRactangleLabel);
            this.Controls.Add(this.RactangleReduceButton);
            this.Controls.Add(this.RactangleAddButton);
            this.Controls.Add(this.RqctangleLabel);
            this.Controls.Add(this.RactangleListBox);
            this.Name = "RectangleCollisionControl";
            this.Size = new System.Drawing.Size(496, 348);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RactangleCanvasPanel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox RactangleWidthTextBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLable;
        private System.Windows.Forms.Label IDLable;
        private System.Windows.Forms.Label SelectedRactangleLabel;
        private System.Windows.Forms.Button RactangleReduceButton;
        private System.Windows.Forms.Button RactangleAddButton;
        private System.Windows.Forms.Label RqctangleLabel;
        private System.Windows.Forms.ListBox RactangleListBox;
    }
}
