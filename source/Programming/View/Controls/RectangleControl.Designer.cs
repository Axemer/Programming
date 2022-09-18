namespace Programming.View.Controls
{
    partial class RectangleControl
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
            this.RactanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RactangleIDTextBox = new System.Windows.Forms.TextBox();
            this.RactangleIDLable = new System.Windows.Forms.Label();
            this.CenterLable = new System.Windows.Forms.Label();
            this.RactabgleCenterTextBox = new System.Windows.Forms.TextBox();
            this.RectangleFindButton = new System.Windows.Forms.Button();
            this.RectangleColorLabel = new System.Windows.Forms.Label();
            this.RectangleWidthLabel = new System.Windows.Forms.Label();
            this.RectangleLengthLabel = new System.Windows.Forms.Label();
            this.RectangleColorTextBox = new System.Windows.Forms.TextBox();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RactanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RactanglesGroupBox
            // 
            this.RactanglesGroupBox.Controls.Add(this.RactangleIDTextBox);
            this.RactanglesGroupBox.Controls.Add(this.RactangleIDLable);
            this.RactanglesGroupBox.Controls.Add(this.CenterLable);
            this.RactanglesGroupBox.Controls.Add(this.RactabgleCenterTextBox);
            this.RactanglesGroupBox.Controls.Add(this.RectangleFindButton);
            this.RactanglesGroupBox.Controls.Add(this.RectangleColorLabel);
            this.RactanglesGroupBox.Controls.Add(this.RectangleWidthLabel);
            this.RactanglesGroupBox.Controls.Add(this.RectangleLengthLabel);
            this.RactanglesGroupBox.Controls.Add(this.RectangleColorTextBox);
            this.RactanglesGroupBox.Controls.Add(this.RectangleWidthTextBox);
            this.RactanglesGroupBox.Controls.Add(this.RectangleLengthTextBox);
            this.RactanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RactanglesGroupBox.Location = new System.Drawing.Point(0, 8);
            this.RactanglesGroupBox.Name = "RactanglesGroupBox";
            this.RactanglesGroupBox.Size = new System.Drawing.Size(230, 332);
            this.RactanglesGroupBox.TabIndex = 1;
            this.RactanglesGroupBox.TabStop = false;
            this.RactanglesGroupBox.Text = "Ractangles";
            // 
            // RactangleIDTextBox
            // 
            this.RactangleIDTextBox.Enabled = false;
            this.RactangleIDTextBox.Location = new System.Drawing.Point(141, 212);
            this.RactangleIDTextBox.Name = "RactangleIDTextBox";
            this.RactangleIDTextBox.Size = new System.Drawing.Size(75, 23);
            this.RactangleIDTextBox.TabIndex = 11;
            // 
            // RactangleIDLable
            // 
            this.RactangleIDLable.AutoSize = true;
            this.RactangleIDLable.Location = new System.Drawing.Point(144, 194);
            this.RactangleIDLable.Name = "RactangleIDLable";
            this.RactangleIDLable.Size = new System.Drawing.Size(18, 15);
            this.RactangleIDLable.TabIndex = 10;
            this.RactangleIDLable.Text = "ID";
            // 
            // CenterLable
            // 
            this.CenterLable.AutoSize = true;
            this.CenterLable.Location = new System.Drawing.Point(144, 150);
            this.CenterLable.Name = "CenterLable";
            this.CenterLable.Size = new System.Drawing.Size(42, 15);
            this.CenterLable.TabIndex = 9;
            this.CenterLable.Text = "Center";
            // 
            // RactabgleCenterTextBox
            // 
            this.RactabgleCenterTextBox.Enabled = false;
            this.RactabgleCenterTextBox.Location = new System.Drawing.Point(140, 168);
            this.RactabgleCenterTextBox.Name = "RactabgleCenterTextBox";
            this.RactabgleCenterTextBox.Size = new System.Drawing.Size(75, 23);
            this.RactabgleCenterTextBox.TabIndex = 8;
            // 
            // RectangleFindButton
            // 
            this.RectangleFindButton.Location = new System.Drawing.Point(141, 288);
            this.RectangleFindButton.Name = "RectangleFindButton";
            this.RectangleFindButton.Size = new System.Drawing.Size(75, 23);
            this.RectangleFindButton.TabIndex = 7;
            this.RectangleFindButton.Text = "Find";
            this.RectangleFindButton.UseVisualStyleBackColor = true;
            this.RectangleFindButton.Click += new System.EventHandler(this.RectangleFindButton_Click);
            // 
            // RectangleColorLabel
            // 
            this.RectangleColorLabel.AutoSize = true;
            this.RectangleColorLabel.Location = new System.Drawing.Point(144, 106);
            this.RectangleColorLabel.Name = "RectangleColorLabel";
            this.RectangleColorLabel.Size = new System.Drawing.Size(36, 15);
            this.RectangleColorLabel.TabIndex = 6;
            this.RectangleColorLabel.Text = "Color";
            // 
            // RectangleWidthLabel
            // 
            this.RectangleWidthLabel.AutoSize = true;
            this.RectangleWidthLabel.Location = new System.Drawing.Point(144, 62);
            this.RectangleWidthLabel.Name = "RectangleWidthLabel";
            this.RectangleWidthLabel.Size = new System.Drawing.Size(39, 15);
            this.RectangleWidthLabel.TabIndex = 5;
            this.RectangleWidthLabel.Text = "Width";
            // 
            // RectangleLengthLabel
            // 
            this.RectangleLengthLabel.AutoSize = true;
            this.RectangleLengthLabel.Location = new System.Drawing.Point(141, 18);
            this.RectangleLengthLabel.Name = "RectangleLengthLabel";
            this.RectangleLengthLabel.Size = new System.Drawing.Size(44, 15);
            this.RectangleLengthLabel.TabIndex = 4;
            this.RectangleLengthLabel.Text = "Length";
            // 
            // RectangleColorTextBox
            // 
            this.RectangleColorTextBox.Location = new System.Drawing.Point(140, 124);
            this.RectangleColorTextBox.Name = "RectangleColorTextBox";
            this.RectangleColorTextBox.Size = new System.Drawing.Size(75, 23);
            this.RectangleColorTextBox.TabIndex = 3;
            this.RectangleColorTextBox.TextChanged += new System.EventHandler(this.RectangleColorTextBox_TextChanged);
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(141, 80);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(75, 23);
            this.RectangleWidthTextBox.TabIndex = 2;
            this.RectangleWidthTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
            // 
            // RectangleLengthTextBox
            // 
            this.RectangleLengthTextBox.Location = new System.Drawing.Point(140, 36);
            this.RectangleLengthTextBox.Name = "RectangleLengthTextBox";
            this.RectangleLengthTextBox.Size = new System.Drawing.Size(75, 23);
            this.RectangleLengthTextBox.TabIndex = 1;
            this.RectangleLengthTextBox.TextChanged += new System.EventHandler(this.RectangleLengthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 15;
            this.RectanglesListBox.Location = new System.Drawing.Point(15, 22);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(120, 289);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectangleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RactanglesGroupBox);
            this.Name = "RectangleControl";
            this.Size = new System.Drawing.Size(230, 348);
            this.RactanglesGroupBox.ResumeLayout(false);
            this.RactanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RactanglesGroupBox;
        private System.Windows.Forms.TextBox RactangleIDTextBox;
        private System.Windows.Forms.Label RactangleIDLable;
        private System.Windows.Forms.Label CenterLable;
        private System.Windows.Forms.TextBox RactabgleCenterTextBox;
        private System.Windows.Forms.Button RectangleFindButton;
        private System.Windows.Forms.Label RectangleColorLabel;
        private System.Windows.Forms.Label RectangleWidthLabel;
        private System.Windows.Forms.Label RectangleLengthLabel;
        private System.Windows.Forms.TextBox RectangleColorTextBox;
        private System.Windows.Forms.TextBox RectangleWidthTextBox;
        private System.Windows.Forms.TextBox RectangleLengthTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
