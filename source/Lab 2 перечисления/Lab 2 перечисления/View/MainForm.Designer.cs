
namespace Programming.Model
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.Enum_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Season_groupBox = new System.Windows.Forms.GroupBox();
            this.Season_button = new System.Windows.Forms.Button();
            this.Season_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Parse_button = new System.Windows.Forms.Button();
            this.Parse_textBox = new System.Windows.Forms.TextBox();
            this.ParserLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IntValueBox = new System.Windows.Forms.TextBox();
            this.Enum_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Season_groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enum_tab
            // 
            this.Enum_tab.Controls.Add(this.tabPage1);
            this.Enum_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enum_tab.Location = new System.Drawing.Point(0, 0);
            this.Enum_tab.Name = "Enum_tab";
            this.Enum_tab.SelectedIndex = 0;
            this.Enum_tab.Size = new System.Drawing.Size(550, 426);
            this.Enum_tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.Season_groupBox);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            // 
            // Season_groupBox
            // 
            this.Season_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.Season_groupBox.Controls.Add(this.Season_button);
            this.Season_groupBox.Controls.Add(this.Season_comboBox);
            this.Season_groupBox.Controls.Add(this.label6);
            this.Season_groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Season_groupBox.Location = new System.Drawing.Point(291, 276);
            this.Season_groupBox.Name = "Season_groupBox";
            this.Season_groupBox.Size = new System.Drawing.Size(231, 100);
            this.Season_groupBox.TabIndex = 8;
            this.Season_groupBox.TabStop = false;
            this.Season_groupBox.Text = "Season Handle";
            // 
            // Season_button
            // 
            this.Season_button.Location = new System.Drawing.Point(139, 40);
            this.Season_button.Name = "Season_button";
            this.Season_button.Size = new System.Drawing.Size(75, 23);
            this.Season_button.TabIndex = 2;
            this.Season_button.Text = "Go";
            this.Season_button.UseVisualStyleBackColor = true;
            this.Season_button.Click += new System.EventHandler(this.Season_button_Click);
            // 
            // Season_comboBox
            // 
            this.Season_comboBox.FormattingEnabled = true;
            this.Season_comboBox.Items.AddRange(new object[] {
            "spring",
            "autum",
            "summer",
            "winter"});
            this.Season_comboBox.Location = new System.Drawing.Point(7, 41);
            this.Season_comboBox.Name = "Season_comboBox";
            this.Season_comboBox.Size = new System.Drawing.Size(121, 23);
            this.Season_comboBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Choose season:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Parse_button);
            this.groupBox2.Controls.Add(this.Parse_textBox);
            this.groupBox2.Controls.Add(this.ParserLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weekday Parsing";
            // 
            // Parse_button
            // 
            this.Parse_button.Location = new System.Drawing.Point(171, 41);
            this.Parse_button.Name = "Parse_button";
            this.Parse_button.Size = new System.Drawing.Size(75, 23);
            this.Parse_button.TabIndex = 3;
            this.Parse_button.Text = "Parse";
            this.Parse_button.UseVisualStyleBackColor = true;
            this.Parse_button.Click += new System.EventHandler(this.Parse_button_Click);
            // 
            // Parse_textBox
            // 
            this.Parse_textBox.Location = new System.Drawing.Point(9, 41);
            this.Parse_textBox.Name = "Parse_textBox";
            this.Parse_textBox.Size = new System.Drawing.Size(140, 23);
            this.Parse_textBox.TabIndex = 2;
            // 
            // ParserLabel
            // 
            this.ParserLabel.AutoSize = true;
            this.ParserLabel.Location = new System.Drawing.Point(9, 67);
            this.ParserLabel.Name = "ParserLabel";
            this.ParserLabel.Size = new System.Drawing.Size(0, 15);
            this.ParserLabel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type value for parsing:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ValuesListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EnumsListBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IntValueBox);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 254);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumerations";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 15;
            this.ValuesListBox.Location = new System.Drawing.Point(171, 52);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(136, 154);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose value:";
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
            this.EnumsListBox.Location = new System.Drawing.Point(9, 52);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(140, 154);
            this.EnumsListBox.TabIndex = 0;
            //this.EnumsListBox.Click += new System.EventHandler(this.EnumsListBox_Click);
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose enumeration:";
            // 
            // IntValueBox
            // 
            this.IntValueBox.Location = new System.Drawing.Point(346, 52);
            this.IntValueBox.Name = "IntValueBox";
            this.IntValueBox.Size = new System.Drawing.Size(100, 23);
            this.IntValueBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 426);
            this.Controls.Add(this.Enum_tab);
            this.Name = "MainForm";
            this.Text = "Programm";
            //this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.Enum_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Season_groupBox.ResumeLayout(false);
            this.Season_groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Enum_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox IntValueBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ParserLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Season_groupBox;
        private System.Windows.Forms.Button Season_button;
        private System.Windows.Forms.ComboBox Season_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Parse_button;
        private System.Windows.Forms.TextBox Parse_textBox;
    }
}

