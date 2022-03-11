
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
            this.EnumTab = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.ParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.ParserLabel = new System.Windows.Forms.Label();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.ChooseValuelabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ChooseEnumlabel = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.EnumTab.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.ParsingGroupBox.SuspendLayout();
            this.EnumGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumTab
            // 
            this.EnumTab.Controls.Add(this.EnumsTabPage);
            this.EnumTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumTab.Location = new System.Drawing.Point(0, 0);
            this.EnumTab.Name = "EnumTab";
            this.EnumTab.SelectedIndex = 0;
            this.EnumTab.Size = new System.Drawing.Size(504, 376);
            this.EnumTab.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.BackColor = System.Drawing.Color.Transparent;
            this.EnumsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnumsTabPage.Controls.Add(this.ParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 24);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(496, 348);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SeasonGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
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
            this.SeasonButton.Location = new System.Drawing.Point(139, 40);
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
            this.SeasonComboBox.Location = new System.Drawing.Point(13, 40);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(120, 23);
            this.SeasonComboBox.TabIndex = 1;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(13, 22);
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
            this.ParsingGroupBox.Controls.Add(this.ParseLabel);
            this.ParsingGroupBox.Location = new System.Drawing.Point(17, 237);
            this.ParsingGroupBox.Name = "ParsingGroupBox";
            this.ParsingGroupBox.Size = new System.Drawing.Size(230, 100);
            this.ParsingGroupBox.TabIndex = 7;
            this.ParsingGroupBox.TabStop = false;
            this.ParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(140, 40);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 3;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Location = new System.Drawing.Point(13, 40);
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
            this.ParseLabel.Location = new System.Drawing.Point(13, 22);
            this.ParseLabel.Name = "ParseLabel";
            this.ParseLabel.Size = new System.Drawing.Size(125, 15);
            this.ParseLabel.TabIndex = 0;
            this.ParseLabel.Text = "Type value for parsing:";
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumGroupBox.Controls.Add(this.ChooseValuelabel);
            this.EnumGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumGroupBox.Controls.Add(this.ChooseEnumlabel);
            this.EnumGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumGroupBox.Location = new System.Drawing.Point(15, 15);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Size = new System.Drawing.Size(465, 210);
            this.EnumGroupBox.TabIndex = 6;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumerations";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(333, 31);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(55, 15);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value:";
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
            // ChooseValuelabel
            // 
            this.ChooseValuelabel.AutoSize = true;
            this.ChooseValuelabel.Location = new System.Drawing.Point(173, 31);
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
            this.ChooseEnumlabel.Location = new System.Drawing.Point(13, 31);
            this.ChooseEnumlabel.Name = "ChooseEnumlabel";
            this.ChooseEnumlabel.Size = new System.Drawing.Size(121, 15);
            this.ChooseEnumlabel.TabIndex = 3;
            this.ChooseEnumlabel.Text = "Choose enumeration:";
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
            this.ClientSize = new System.Drawing.Size(504, 376);
            this.Controls.Add(this.EnumTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(520, 415);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 415);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumTab.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.ParsingGroupBox.ResumeLayout(false);
            this.ParsingGroupBox.PerformLayout();
            this.EnumGroupBox.ResumeLayout(false);
            this.EnumGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EnumTab;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox EnumGroupBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ChooseValuelabel;
        private System.Windows.Forms.Label ChooseEnumlabel;
        private System.Windows.Forms.GroupBox ParsingGroupBox;
        private System.Windows.Forms.Label ParserLabel;
        private System.Windows.Forms.Label ParseLabel;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParseTextBox;
    }
}

