namespace Programming.View.Controls
{
    partial class WeekdayParsingControl
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
            this.ParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.ParserLabel = new System.Windows.Forms.Label();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.ParsingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParsingGroupBox
            // 
            this.ParsingGroupBox.Controls.Add(this.ParseButton);
            this.ParsingGroupBox.Controls.Add(this.ParseTextBox);
            this.ParsingGroupBox.Controls.Add(this.ParserLabel);
            this.ParsingGroupBox.Controls.Add(this.ParseLabel);
            this.ParsingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ParsingGroupBox.Name = "ParsingGroupBox";
            this.ParsingGroupBox.Size = new System.Drawing.Size(230, 100);
            this.ParsingGroupBox.TabIndex = 8;
            this.ParsingGroupBox.TabStop = false;
            this.ParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(133, 40);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 3;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Location = new System.Drawing.Point(6, 40);
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(121, 23);
            this.ParseTextBox.TabIndex = 2;
            // 
            // ParserLabel
            // 
            this.ParserLabel.AutoSize = true;
            this.ParserLabel.Location = new System.Drawing.Point(9, 67);
            this.ParserLabel.Name = "ParserLabel";
            this.ParserLabel.Size = new System.Drawing.Size(0, 15);
            this.ParserLabel.TabIndex = 1;
            // 
            // ParseLabel
            // 
            this.ParseLabel.AutoSize = true;
            this.ParseLabel.Location = new System.Drawing.Point(6, 22);
            this.ParseLabel.Name = "ParseLabel";
            this.ParseLabel.Size = new System.Drawing.Size(125, 15);
            this.ParseLabel.TabIndex = 0;
            this.ParseLabel.Text = "Type value for parsing:";
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParsingGroupBox);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(230, 100);
            this.ParsingGroupBox.ResumeLayout(false);
            this.ParsingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ParsingGroupBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParseTextBox;
        private System.Windows.Forms.Label ParserLabel;
        private System.Windows.Forms.Label ParseLabel;
    }
}
