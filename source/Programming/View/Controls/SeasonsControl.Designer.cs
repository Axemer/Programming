namespace Programming.View.Controls
{
    partial class SeasonsControl
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
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SeasonGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SeasonGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(226, 100);
            this.SeasonGroupBox.TabIndex = 9;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(6, 22);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(89, 15);
            this.SeasonLabel.TabIndex = 0;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(132, 40);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 23);
            this.SeasonButton.TabIndex = 2;
            this.SeasonButton.Text = "Go";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(6, 40);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(120, 23);
            this.SeasonComboBox.TabIndex = 1;
            // 
            // SeasonsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonGroupBox);
            this.Name = "SeasonsControl";
            this.Size = new System.Drawing.Size(226, 100);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.ComboBox SeasonComboBox;
    }
}
