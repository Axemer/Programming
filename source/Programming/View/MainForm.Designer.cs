
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
            this.weekdayParsingControl1 = new Programming.View.Controls.WeekdayParsingControl();
            this.seasonsControl1 = new Programming.View.Controls.SeasonsControl();
            this.enumerationsControl1 = new Programming.View.Controls.EnumerationsControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.rectangleControl1 = new Programming.View.Controls.RectangleControl();
            this.movieControl1 = new Programming.View.Controls.MovieControl();
            this.RactanglesTab = new System.Windows.Forms.TabPage();
            this.rectangleCollisionControl1 = new Programming.View.Controls.RectangleCollisionControl();
            this.EnumTab.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.RactanglesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumTab
            // 
            this.EnumTab.Controls.Add(this.EnumsTabPage);
            this.EnumTab.Controls.Add(this.ClassesTabPage);
            this.EnumTab.Controls.Add(this.RactanglesTab);
            this.EnumTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumTab.Location = new System.Drawing.Point(0, 0);
            this.EnumTab.Name = "EnumTab";
            this.EnumTab.SelectedIndex = 0;
            this.EnumTab.Size = new System.Drawing.Size(504, 376);
            this.EnumTab.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.BackColor = System.Drawing.Color.White;
            this.EnumsTabPage.Controls.Add(this.weekdayParsingControl1);
            this.EnumsTabPage.Controls.Add(this.seasonsControl1);
            this.EnumsTabPage.Controls.Add(this.enumerationsControl1);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 24);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(496, 348);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(15, 231);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(230, 100);
            this.weekdayParsingControl1.TabIndex = 11;
            // 
            // seasonsControl1
            // 
            this.seasonsControl1.Location = new System.Drawing.Point(251, 231);
            this.seasonsControl1.Name = "seasonsControl1";
            this.seasonsControl1.Size = new System.Drawing.Size(226, 100);
            this.seasonsControl1.TabIndex = 10;
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Location = new System.Drawing.Point(6, 0);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(477, 225);
            this.enumerationsControl1.TabIndex = 9;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.rectangleControl1);
            this.ClassesTabPage.Controls.Add(this.movieControl1);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 24);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Size = new System.Drawing.Size(496, 348);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectangleControl1
            // 
            this.rectangleControl1.Location = new System.Drawing.Point(8, 0);
            this.rectangleControl1.Name = "rectangleControl1";
            this.rectangleControl1.Size = new System.Drawing.Size(230, 348);
            this.rectangleControl1.TabIndex = 0;
            // 
            // movieControl1
            // 
            this.movieControl1.Location = new System.Drawing.Point(258, 8);
            this.movieControl1.Name = "movieControl1";
            this.movieControl1.Size = new System.Drawing.Size(230, 332);
            this.movieControl1.TabIndex = 1;
            // 
            // RactanglesTab
            // 
            this.RactanglesTab.Controls.Add(this.rectangleCollisionControl1);
            this.RactanglesTab.Location = new System.Drawing.Point(4, 24);
            this.RactanglesTab.Name = "RactanglesTab";
            this.RactanglesTab.Padding = new System.Windows.Forms.Padding(3);
            this.RactanglesTab.Size = new System.Drawing.Size(496, 348);
            this.RactanglesTab.TabIndex = 2;
            this.RactanglesTab.Text = "Rеctangles";
            this.RactanglesTab.UseVisualStyleBackColor = true;
            // 
            // rectangleCollisionControl1
            // 
            this.rectangleCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectangleCollisionControl1.Name = "rectangleCollisionControl1";
            this.rectangleCollisionControl1.Size = new System.Drawing.Size(496, 348);
            this.rectangleCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(504, 376);
            this.Controls.Add(this.EnumTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.MinimumSize = new System.Drawing.Size(520, 415);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumTab.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.RactanglesTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EnumTab;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.TabPage RactanglesTab;
        private Controls.RectangleCollisionControl rectangleCollisionControl1;
        private Controls.MovieControl movieControl1;
        private Controls.RectangleControl rectangleControl1;
        private Controls.EnumerationsControl enumerationsControl1;
        private Controls.SeasonsControl seasonsControl1;
        private Controls.WeekdayParsingControl weekdayParsingControl1;
    }
}

