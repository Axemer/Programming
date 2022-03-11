
namespace Programming.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Enum_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.ParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.ParserLabel = new System.Windows.Forms.Label();
            this.parselabel = new System.Windows.Forms.Label();
            this.EnumGroupBox1 = new System.Windows.Forms.GroupBox();
            this.intvaluelabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.ChooseValuelabel2 = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ChooseEnumlabel1 = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.Enum_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.ParsingGroupBox.SuspendLayout();
            this.EnumGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enum_tab
            // 
            this.Enum_tab.Controls.Add(this.tabPage1);
            this.Enum_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enum_tab.Location = new System.Drawing.Point(0, 0);
            this.Enum_tab.Name = "Enum_tab";
            this.Enum_tab.SelectedIndex = 0;
            this.Enum_tab.Size = new System.Drawing.Size(504, 381);
            this.Enum_tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.SeasonGroupBox);
            this.tabPage1.Controls.Add(this.ParsingGroupBox);
            this.tabPage1.Controls.Add(this.EnumGroupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SeasonGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SeasonGroupBox.Location = new System.Drawing.Point(253, 237);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(226, 100);
            this.SeasonGroupBox.TabIndex = 8;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(133, 40);
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
            this.SeasonComboBox.Location = new System.Drawing.Point(7, 41);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(120, 23);
            this.SeasonComboBox.TabIndex = 1;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(7, 23);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(89, 15);
            this.SeasonLabel.TabIndex = 0;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // ParsingGroupBox
            // 
            this.ParsingGroupBox.Controls.Add(this.ParseButton);
            this.ParsingGroupBox.Controls.Add(this.ParseTextBox);
            this.ParsingGroupBox.Controls.Add(this.ParserLabel);
            this.ParsingGroupBox.Controls.Add(this.parselabel);
            this.ParsingGroupBox.Location = new System.Drawing.Point(17, 237);
            this.ParsingGroupBox.Name = "ParsingGroupBox";
            this.ParsingGroupBox.Size = new System.Drawing.Size(230, 100);
            this.ParsingGroupBox.TabIndex = 7;
            this.ParsingGroupBox.TabStop = false;
            this.ParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(135, 41);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 3;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Location = new System.Drawing.Point(9, 41);
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(120, 23);
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
            // parselabel
            // 
            this.parselabel.AutoSize = true;
            this.parselabel.Location = new System.Drawing.Point(6, 23);
            this.parselabel.Name = "parselabel";
            this.parselabel.Size = new System.Drawing.Size(125, 15);
            this.parselabel.TabIndex = 0;
            this.parselabel.Text = "Type value for parsing:";
            // 
            // EnumGroupBox1
            // 
            this.EnumGroupBox1.Controls.Add(this.intvaluelabel);
            this.EnumGroupBox1.Controls.Add(this.ValuesListBox);
            this.EnumGroupBox1.Controls.Add(this.ChooseValuelabel2);
            this.EnumGroupBox1.Controls.Add(this.EnumsListBox);
            this.EnumGroupBox1.Controls.Add(this.ChooseEnumlabel1);
            this.EnumGroupBox1.Controls.Add(this.IntValueTextBox);
            this.EnumGroupBox1.Location = new System.Drawing.Point(15, 15);
            this.EnumGroupBox1.Name = "EnumGroupBox1";
            this.EnumGroupBox1.Size = new System.Drawing.Size(465, 210);
            this.EnumGroupBox1.TabIndex = 6;
            this.EnumGroupBox1.TabStop = false;
            this.EnumGroupBox1.Text = "Enumerations";
            // 
            // intvaluelabel
            // 
            this.intvaluelabel.AutoSize = true;
            this.intvaluelabel.Location = new System.Drawing.Point(333, 31);
            this.intvaluelabel.Name = "intvaluelabel";
            this.intvaluelabel.Size = new System.Drawing.Size(55, 15);
            this.intvaluelabel.TabIndex = 5;
            this.intvaluelabel.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 15;
            this.ValuesListBox.Location = new System.Drawing.Point(173, 50);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(140, 139);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // ChooseValuelabel2
            // 
            this.ChooseValuelabel2.AutoSize = true;
            this.ChooseValuelabel2.Location = new System.Drawing.Point(173, 31);
            this.ChooseValuelabel2.Name = "ChooseValuelabel2";
            this.ChooseValuelabel2.Size = new System.Drawing.Size(81, 15);
            this.ChooseValuelabel2.TabIndex = 4;
            this.ChooseValuelabel2.Text = "Choose value:";
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
            // ChooseEnumlabel1
            // 
            this.ChooseEnumlabel1.AutoSize = true;
            this.ChooseEnumlabel1.Location = new System.Drawing.Point(13, 31);
            this.ChooseEnumlabel1.Name = "ChooseEnumlabel1";
            this.ChooseEnumlabel1.Size = new System.Drawing.Size(121, 15);
            this.ChooseEnumlabel1.TabIndex = 3;
            this.ChooseEnumlabel1.Text = "Choose enumeration:";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(333, 50);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(100, 23);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Controls.Add(this.Enum_tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(520, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 420);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Enum_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.ParsingGroupBox.ResumeLayout(false);
            this.ParsingGroupBox.PerformLayout();
            this.EnumGroupBox1.ResumeLayout(false);
            this.EnumGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Enum_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox EnumGroupBox1;
        private System.Windows.Forms.Label intvaluelabel;
        private System.Windows.Forms.Label ChooseValuelabel2;
        private System.Windows.Forms.Label ChooseEnumlabel1;
        private System.Windows.Forms.GroupBox ParsingGroupBox;
        private System.Windows.Forms.Label ParserLabel;
        private System.Windows.Forms.Label parselabel;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParseTextBox;
    }
}

