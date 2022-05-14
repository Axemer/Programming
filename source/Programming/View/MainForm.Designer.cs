
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
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
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
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieFindButton = new System.Windows.Forms.Button();
            this.MovieRatingTextBox = new System.Windows.Forms.TextBox();
            this.MovieDurationTextBox = new System.Windows.Forms.TextBox();
            this.MovieYearTextBox = new System.Windows.Forms.TextBox();
            this.MovieGenreTextBox = new System.Windows.Forms.TextBox();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.MovieRatingLable = new System.Windows.Forms.Label();
            this.MovieDurationLabel = new System.Windows.Forms.Label();
            this.MovieYearLabel = new System.Windows.Forms.Label();
            this.MovieGenreLabel = new System.Windows.Forms.Label();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.RactanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectangleFindButton = new System.Windows.Forms.Button();
            this.RectangleColorLabel = new System.Windows.Forms.Label();
            this.RectangleWidthLabel = new System.Windows.Forms.Label();
            this.RectangleLengthLabel = new System.Windows.Forms.Label();
            this.RectangleColorTextBox = new System.Windows.Forms.TextBox();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.EnumTab.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.ParsingGroupBox.SuspendLayout();
            this.EnumGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RactanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumTab
            // 
            this.EnumTab.Controls.Add(this.EnumsTabPage);
            this.EnumTab.Controls.Add(this.ClassesTabPage);
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
            this.SeasonGroupBox.Location = new System.Drawing.Point(251, 231);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(226, 100);
            this.SeasonGroupBox.TabIndex = 8;
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
            // ParsingGroupBox
            // 
            this.ParsingGroupBox.Controls.Add(this.ParseButton);
            this.ParsingGroupBox.Controls.Add(this.ParseTextBox);
            this.ParsingGroupBox.Controls.Add(this.ParserLabel);
            this.ParsingGroupBox.Controls.Add(this.ParseLabel);
            this.ParsingGroupBox.Location = new System.Drawing.Point(15, 231);
            this.ParsingGroupBox.Name = "ParsingGroupBox";
            this.ParsingGroupBox.Size = new System.Drawing.Size(230, 100);
            this.ParsingGroupBox.TabIndex = 7;
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
            this.EnumGroupBox.Size = new System.Drawing.Size(462, 210);
            this.EnumGroupBox.TabIndex = 6;
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
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RactanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 24);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Size = new System.Drawing.Size(496, 348);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.MovieFindButton);
            this.MoviesGroupBox.Controls.Add(this.MovieRatingTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieDurationTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieYearTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieGenreTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieTitleTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieRatingLable);
            this.MoviesGroupBox.Controls.Add(this.MovieDurationLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieYearLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieGenreLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieTitleLabel);
            this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox.Location = new System.Drawing.Point(244, 8);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(230, 332);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // MovieFindButton
            // 
            this.MovieFindButton.Location = new System.Drawing.Point(141, 288);
            this.MovieFindButton.Name = "MovieFindButton";
            this.MovieFindButton.Size = new System.Drawing.Size(75, 23);
            this.MovieFindButton.TabIndex = 11;
            this.MovieFindButton.Text = "Find";
            this.MovieFindButton.UseVisualStyleBackColor = true;
            this.MovieFindButton.Click += new System.EventHandler(this.MovieFindButton_Click);
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Location = new System.Drawing.Point(141, 124);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(75, 23);
            this.MovieRatingTextBox.TabIndex = 10;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged_1);
            // 
            // MovieDurationTextBox
            // 
            this.MovieDurationTextBox.Location = new System.Drawing.Point(141, 212);
            this.MovieDurationTextBox.Name = "MovieDurationTextBox";
            this.MovieDurationTextBox.Size = new System.Drawing.Size(75, 23);
            this.MovieDurationTextBox.TabIndex = 9;
            this.MovieDurationTextBox.TextChanged += new System.EventHandler(this.MovieDurationTextBox_TextChanged_1);
            // 
            // MovieYearTextBox
            // 
            this.MovieYearTextBox.Location = new System.Drawing.Point(141, 80);
            this.MovieYearTextBox.Name = "MovieYearTextBox";
            this.MovieYearTextBox.Size = new System.Drawing.Size(75, 23);
            this.MovieYearTextBox.TabIndex = 8;
            this.MovieYearTextBox.TextChanged += new System.EventHandler(this.MovieYearTextBox_TextChanged_1);
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Location = new System.Drawing.Point(141, 168);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(75, 23);
            this.MovieGenreTextBox.TabIndex = 7;
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.MovieGenreTextBox_TextChanged_1);
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Location = new System.Drawing.Point(141, 36);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.Size = new System.Drawing.Size(75, 23);
            this.MovieTitleTextBox.TabIndex = 6;
            this.MovieTitleTextBox.TextChanged += new System.EventHandler(this.MovieTitleTextBox_TextChanged);
            // 
            // MovieRatingLable
            // 
            this.MovieRatingLable.AutoSize = true;
            this.MovieRatingLable.Location = new System.Drawing.Point(141, 106);
            this.MovieRatingLable.Name = "MovieRatingLable";
            this.MovieRatingLable.Size = new System.Drawing.Size(41, 15);
            this.MovieRatingLable.TabIndex = 5;
            this.MovieRatingLable.Text = "Rating";
            // 
            // MovieDurationLabel
            // 
            this.MovieDurationLabel.AutoSize = true;
            this.MovieDurationLabel.Location = new System.Drawing.Point(141, 194);
            this.MovieDurationLabel.Name = "MovieDurationLabel";
            this.MovieDurationLabel.Size = new System.Drawing.Size(53, 15);
            this.MovieDurationLabel.TabIndex = 4;
            this.MovieDurationLabel.Text = "Duration";
            // 
            // MovieYearLabel
            // 
            this.MovieYearLabel.AutoSize = true;
            this.MovieYearLabel.Location = new System.Drawing.Point(141, 62);
            this.MovieYearLabel.Name = "MovieYearLabel";
            this.MovieYearLabel.Size = new System.Drawing.Size(29, 15);
            this.MovieYearLabel.TabIndex = 3;
            this.MovieYearLabel.Text = "Year";
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Location = new System.Drawing.Point(141, 150);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(38, 15);
            this.MovieGenreLabel.TabIndex = 2;
            this.MovieGenreLabel.Text = "Genre";
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(141, 18);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(29, 15);
            this.MovieTitleLabel.TabIndex = 1;
            this.MovieTitleLabel.Text = "Title";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 15;
            this.MoviesListBox.Location = new System.Drawing.Point(15, 22);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(120, 289);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // RactanglesGroupBox
            // 
            this.RactanglesGroupBox.Controls.Add(this.RectangleFindButton);
            this.RactanglesGroupBox.Controls.Add(this.RectangleColorLabel);
            this.RactanglesGroupBox.Controls.Add(this.RectangleWidthLabel);
            this.RactanglesGroupBox.Controls.Add(this.RectangleLengthLabel);
            this.RactanglesGroupBox.Controls.Add(this.RectangleColorTextBox);
            this.RactanglesGroupBox.Controls.Add(this.RectangleWidthTextBox);
            this.RactanglesGroupBox.Controls.Add(this.RectangleLengthTextBox);
            this.RactanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RactanglesGroupBox.Location = new System.Drawing.Point(8, 8);
            this.RactanglesGroupBox.Name = "RactanglesGroupBox";
            this.RactanglesGroupBox.Size = new System.Drawing.Size(230, 332);
            this.RactanglesGroupBox.TabIndex = 0;
            this.RactanglesGroupBox.TabStop = false;
            this.RactanglesGroupBox.Text = "Ractangles";
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
            this.RectangleColorLabel.Location = new System.Drawing.Point(140, 110);
            this.RectangleColorLabel.Name = "RectangleColorLabel";
            this.RectangleColorLabel.Size = new System.Drawing.Size(36, 15);
            this.RectangleColorLabel.TabIndex = 6;
            this.RectangleColorLabel.Text = "Color";
            // 
            // RectangleWidthLabel
            // 
            this.RectangleWidthLabel.AutoSize = true;
            this.RectangleWidthLabel.Location = new System.Drawing.Point(140, 66);
            this.RectangleWidthLabel.Name = "RectangleWidthLabel";
            this.RectangleWidthLabel.Size = new System.Drawing.Size(39, 15);
            this.RectangleWidthLabel.TabIndex = 5;
            this.RectangleWidthLabel.Text = "Width";
            // 
            // RectangleLengthLabel
            // 
            this.RectangleLengthLabel.AutoSize = true;
            this.RectangleLengthLabel.Location = new System.Drawing.Point(140, 22);
            this.RectangleLengthLabel.Name = "RectangleLengthLabel";
            this.RectangleLengthLabel.Size = new System.Drawing.Size(44, 15);
            this.RectangleLengthLabel.TabIndex = 4;
            this.RectangleLengthLabel.Text = "Length";
            // 
            // RectangleColorTextBox
            // 
            this.RectangleColorTextBox.Location = new System.Drawing.Point(140, 128);
            this.RectangleColorTextBox.Name = "RectangleColorTextBox";
            this.RectangleColorTextBox.Size = new System.Drawing.Size(75, 23);
            this.RectangleColorTextBox.TabIndex = 3;
            this.RectangleColorTextBox.TextChanged += new System.EventHandler(this.RectangleColorTextBox_TextChanged);
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(140, 84);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(75, 23);
            this.RectangleWidthTextBox.TabIndex = 2;
            this.RectangleWidthTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
            // 
            // RectangleLengthTextBox
            // 
            this.RectangleLengthTextBox.Location = new System.Drawing.Point(140, 40);
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
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.RactanglesGroupBox.ResumeLayout(false);
            this.RactanglesGroupBox.PerformLayout();
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
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox RactanglesGroupBox;
        private System.Windows.Forms.Button RectangleFindButton;
        private System.Windows.Forms.Label RectangleColorLabel;
        private System.Windows.Forms.Label RectangleWidthLabel;
        private System.Windows.Forms.Label RectangleLengthLabel;
        private System.Windows.Forms.TextBox RectangleColorTextBox;
        private System.Windows.Forms.TextBox RectangleWidthTextBox;
        private System.Windows.Forms.TextBox RectangleLengthTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Button MovieFindButton;
        private System.Windows.Forms.TextBox MovieRatingTextBox;
        private System.Windows.Forms.TextBox MovieDurationTextBox;
        private System.Windows.Forms.TextBox MovieYearTextBox;
        private System.Windows.Forms.TextBox MovieGenreTextBox;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.Label MovieRatingLable;
        private System.Windows.Forms.Label MovieDurationLabel;
        private System.Windows.Forms.Label MovieYearLabel;
        private System.Windows.Forms.Label MovieGenreLabel;
        private System.Windows.Forms.Label MovieTitleLabel;
    }
}

