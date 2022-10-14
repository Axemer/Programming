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
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLable = new System.Windows.Forms.Label();
            this.IDLable = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectangleReduceButton = new System.Windows.Forms.Button();
            this.RectangleAddButton = new System.Windows.Forms.Button();
            this.RectangleLabel = new System.Windows.Forms.Label();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RactangleCanvasPanel
            // 
            this.RactangleCanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RactangleCanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RactangleCanvasPanel.Location = new System.Drawing.Point(173, 29);
            this.RactangleCanvasPanel.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.RactangleCanvasPanel.MinimumSize = new System.Drawing.Size(309, 309);
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
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(67, 286);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(100, 23);
            this.RectangleWidthTextBox.TabIndex = 29;
            this.RectangleWidthTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
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
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(100, 23);
            this.IDTextBox.TabIndex = 26;
            this.IDTextBox.TabStop = false;
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
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(6, 181);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(109, 15);
            this.SelectedRectangleLabel.TabIndex = 20;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectangleReduceButton
            // 
            this.RectangleReduceButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RectangleReduceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RectangleReduceButton.FlatAppearance.BorderSize = 0;
            this.RectangleReduceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleReduceButton.Location = new System.Drawing.Point(103, 144);
            this.RectangleReduceButton.Name = "RectangleReduceButton";
            this.RectangleReduceButton.Size = new System.Drawing.Size(30, 30);
            this.RectangleReduceButton.TabIndex = 19;
            this.RectangleReduceButton.UseVisualStyleBackColor = true;
            this.RectangleReduceButton.Click += new System.EventHandler(this.RactangleReduceButton_Click);
            // 
            // RectangleAddButton
            // 
            this.RectangleAddButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.RectangleAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RectangleAddButton.FlatAppearance.BorderSize = 0;
            this.RectangleAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleAddButton.Location = new System.Drawing.Point(28, 144);
            this.RectangleAddButton.Name = "RectangleAddButton";
            this.RectangleAddButton.Size = new System.Drawing.Size(30, 30);
            this.RectangleAddButton.TabIndex = 18;
            this.RectangleAddButton.UseVisualStyleBackColor = true;
            this.RectangleAddButton.Click += new System.EventHandler(this.RactangleAddButton_Click);
            // 
            // RectangleLabel
            // 
            this.RectangleLabel.AutoSize = true;
            this.RectangleLabel.Location = new System.Drawing.Point(11, 11);
            this.RectangleLabel.Name = "RectangleLabel";
            this.RectangleLabel.Size = new System.Drawing.Size(62, 15);
            this.RectangleLabel.TabIndex = 17;
            this.RectangleLabel.Text = "Rectangle:";
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.ColumnWidth = 2;
            this.RectangleListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.HorizontalExtent = 100;
            this.RectangleListBox.HorizontalScrollbar = true;
            this.RectangleListBox.ItemHeight = 15;
            this.RectangleListBox.Location = new System.Drawing.Point(11, 29);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(156, 109);
            this.RectangleListBox.TabIndex = 16;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RactangleListBox_SelectedIndexChanged);
            this.RectangleListBox.MeasureItem += MeasureItem;
            this.RectangleListBox.DrawItem += DrawItem;
            // 
            // RectangleCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.RactangleCanvasPanel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.RectangleWidthTextBox);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLable);
            this.Controls.Add(this.IDLable);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.RectangleReduceButton);
            this.Controls.Add(this.RectangleAddButton);
            this.Controls.Add(this.RectangleLabel);
            this.Controls.Add(this.RectangleListBox);
            this.Name = "RectangleCollisionControl";
            this.Size = new System.Drawing.Size(496, 348);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RactangleCanvasPanel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox RectangleWidthTextBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLable;
        private System.Windows.Forms.Label IDLable;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.Button RectangleReduceButton;
        private System.Windows.Forms.Button RectangleAddButton;
        private System.Windows.Forms.Label RectangleLabel;
        private System.Windows.Forms.ListBox RectangleListBox;
    }
}
