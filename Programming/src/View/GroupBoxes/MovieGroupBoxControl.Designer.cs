using System.ComponentModel;

namespace Programming.View.GroupBoxes
{
    partial class MovieGroupBoxControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBoxClassesFilms = new System.Windows.Forms.GroupBox();
            this.TextBoxClassesFilmsGenre = new System.Windows.Forms.TextBox();
            this.LabelClassesFilmsGenre = new System.Windows.Forms.Label();
            this.TextBoxClassesFilmsName = new System.Windows.Forms.TextBox();
            this.LabelClassesFilmsName = new System.Windows.Forms.Label();
            this.ButtonClassesFilmsFind = new System.Windows.Forms.Button();
            this.TextBoxClassesFilmsRating = new System.Windows.Forms.TextBox();
            this.LabelClassesFilmsRating = new System.Windows.Forms.Label();
            this.TextBoxClassesFilmsYear = new System.Windows.Forms.TextBox();
            this.LabelClassesFilmsYear = new System.Windows.Forms.Label();
            this.TextBoxClassesFilmsDuration = new System.Windows.Forms.TextBox();
            this.LabelClassesFilmsDuration = new System.Windows.Forms.Label();
            this.ListBoxClassesFilms = new System.Windows.Forms.ListBox();
            this.GroupBoxClassesFilms.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxClassesFilms
            // 
            this.GroupBoxClassesFilms.Controls.Add(this.TextBoxClassesFilmsGenre);
            this.GroupBoxClassesFilms.Controls.Add(this.LabelClassesFilmsGenre);
            this.GroupBoxClassesFilms.Controls.Add(this.TextBoxClassesFilmsName);
            this.GroupBoxClassesFilms.Controls.Add(this.LabelClassesFilmsName);
            this.GroupBoxClassesFilms.Controls.Add(this.ButtonClassesFilmsFind);
            this.GroupBoxClassesFilms.Controls.Add(this.TextBoxClassesFilmsRating);
            this.GroupBoxClassesFilms.Controls.Add(this.LabelClassesFilmsRating);
            this.GroupBoxClassesFilms.Controls.Add(this.TextBoxClassesFilmsYear);
            this.GroupBoxClassesFilms.Controls.Add(this.LabelClassesFilmsYear);
            this.GroupBoxClassesFilms.Controls.Add(this.TextBoxClassesFilmsDuration);
            this.GroupBoxClassesFilms.Controls.Add(this.LabelClassesFilmsDuration);
            this.GroupBoxClassesFilms.Controls.Add(this.ListBoxClassesFilms);
            this.GroupBoxClassesFilms.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxClassesFilms.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxClassesFilms.Name = "GroupBoxClassesFilms";
            this.GroupBoxClassesFilms.Size = new System.Drawing.Size(786, 293);
            this.GroupBoxClassesFilms.TabIndex = 9;
            this.GroupBoxClassesFilms.TabStop = false;
            this.GroupBoxClassesFilms.Text = "Films";
            // 
            // TextBoxClassesFilmsGenre
            // 
            this.TextBoxClassesFilmsGenre.Location = new System.Drawing.Point(148, 188);
            this.TextBoxClassesFilmsGenre.Name = "TextBoxClassesFilmsGenre";
            this.TextBoxClassesFilmsGenre.Size = new System.Drawing.Size(167, 20);
            this.TextBoxClassesFilmsGenre.TabIndex = 11;
            this.TextBoxClassesFilmsGenre.TextChanged += new System.EventHandler(this.TextBoxClassesFilmsGenre_TextChanged);
            this.TextBoxClassesFilmsGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPressCancel);
            // 
            // LabelClassesFilmsGenre
            // 
            this.LabelClassesFilmsGenre.Location = new System.Drawing.Point(148, 172);
            this.LabelClassesFilmsGenre.Name = "LabelClassesFilmsGenre";
            this.LabelClassesFilmsGenre.Size = new System.Drawing.Size(167, 13);
            this.LabelClassesFilmsGenre.TabIndex = 10;
            this.LabelClassesFilmsGenre.Text = "Genre:";
            // 
            // TextBoxClassesFilmsName
            // 
            this.TextBoxClassesFilmsName.Location = new System.Drawing.Point(148, 149);
            this.TextBoxClassesFilmsName.Name = "TextBoxClassesFilmsName";
            this.TextBoxClassesFilmsName.Size = new System.Drawing.Size(167, 20);
            this.TextBoxClassesFilmsName.TabIndex = 9;
            this.TextBoxClassesFilmsName.TextChanged += new System.EventHandler(this.TextBoxClassesFilmsName_TextChanged);
            this.TextBoxClassesFilmsName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPressCancel);
            // 
            // LabelClassesFilmsName
            // 
            this.LabelClassesFilmsName.Location = new System.Drawing.Point(148, 133);
            this.LabelClassesFilmsName.Name = "LabelClassesFilmsName";
            this.LabelClassesFilmsName.Size = new System.Drawing.Size(167, 13);
            this.LabelClassesFilmsName.TabIndex = 8;
            this.LabelClassesFilmsName.Text = "Name:";
            // 
            // ButtonClassesFilmsFind
            // 
            this.ButtonClassesFilmsFind.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClassesFilmsFind.Location = new System.Drawing.Point(705, 252);
            this.ButtonClassesFilmsFind.Name = "ButtonClassesFilmsFind";
            this.ButtonClassesFilmsFind.Size = new System.Drawing.Size(75, 23);
            this.ButtonClassesFilmsFind.TabIndex = 7;
            this.ButtonClassesFilmsFind.Text = "Find";
            this.ButtonClassesFilmsFind.UseVisualStyleBackColor = true;
            this.ButtonClassesFilmsFind.Click += new System.EventHandler(this.ButtonClassesFilmsFind_Click);
            // 
            // TextBoxClassesFilmsRating
            // 
            this.TextBoxClassesFilmsRating.Location = new System.Drawing.Point(148, 110);
            this.TextBoxClassesFilmsRating.Name = "TextBoxClassesFilmsRating";
            this.TextBoxClassesFilmsRating.Size = new System.Drawing.Size(167, 20);
            this.TextBoxClassesFilmsRating.TabIndex = 6;
            this.TextBoxClassesFilmsRating.TextChanged += new System.EventHandler(this.TextBoxClassesFilmsRating_TextChanged);
            this.TextBoxClassesFilmsRating.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPressCancel);
            // 
            // LabelClassesFilmsRating
            // 
            this.LabelClassesFilmsRating.Location = new System.Drawing.Point(148, 94);
            this.LabelClassesFilmsRating.Name = "LabelClassesFilmsRating";
            this.LabelClassesFilmsRating.Size = new System.Drawing.Size(167, 13);
            this.LabelClassesFilmsRating.TabIndex = 5;
            this.LabelClassesFilmsRating.Text = "Rating:";
            // 
            // TextBoxClassesFilmsYear
            // 
            this.TextBoxClassesFilmsYear.Location = new System.Drawing.Point(148, 71);
            this.TextBoxClassesFilmsYear.Name = "TextBoxClassesFilmsYear";
            this.TextBoxClassesFilmsYear.Size = new System.Drawing.Size(167, 20);
            this.TextBoxClassesFilmsYear.TabIndex = 4;
            this.TextBoxClassesFilmsYear.TextChanged += new System.EventHandler(this.TextBoxClassesFilmsYear_TextChanged);
            this.TextBoxClassesFilmsYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPressCancel);
            // 
            // LabelClassesFilmsYear
            // 
            this.LabelClassesFilmsYear.Location = new System.Drawing.Point(148, 55);
            this.LabelClassesFilmsYear.Name = "LabelClassesFilmsYear";
            this.LabelClassesFilmsYear.Size = new System.Drawing.Size(167, 13);
            this.LabelClassesFilmsYear.TabIndex = 3;
            this.LabelClassesFilmsYear.Text = "Year:";
            // 
            // TextBoxClassesFilmsDuration
            // 
            this.TextBoxClassesFilmsDuration.Location = new System.Drawing.Point(148, 32);
            this.TextBoxClassesFilmsDuration.Name = "TextBoxClassesFilmsDuration";
            this.TextBoxClassesFilmsDuration.Size = new System.Drawing.Size(167, 20);
            this.TextBoxClassesFilmsDuration.TabIndex = 2;
            this.TextBoxClassesFilmsDuration.TextChanged += new System.EventHandler(this.TextBoxClassesFilmsDuration_TextChanged);
            this.TextBoxClassesFilmsDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPressCancel);
            // 
            // LabelClassesFilmsDuration
            // 
            this.LabelClassesFilmsDuration.Location = new System.Drawing.Point(148, 16);
            this.LabelClassesFilmsDuration.Name = "LabelClassesFilmsDuration";
            this.LabelClassesFilmsDuration.Size = new System.Drawing.Size(167, 13);
            this.LabelClassesFilmsDuration.TabIndex = 1;
            this.LabelClassesFilmsDuration.Text = "Duration:";
            // 
            // ListBoxClassesFilms
            // 
            this.ListBoxClassesFilms.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBoxClassesFilms.FormattingEnabled = true;
            this.ListBoxClassesFilms.Location = new System.Drawing.Point(6, 19);
            this.ListBoxClassesFilms.Name = "ListBoxClassesFilms";
            this.ListBoxClassesFilms.Size = new System.Drawing.Size(136, 251);
            this.ListBoxClassesFilms.TabIndex = 0;
            this.ListBoxClassesFilms.SelectedIndexChanged += new System.EventHandler(this.ListBoxClassesFilms_SelectedIndexChanged);
            // 
            // MovieGroupBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxClassesFilms);
            this.Name = "MovieGroupBoxControl";
            this.Size = new System.Drawing.Size(786, 293);
            this.GroupBoxClassesFilms.ResumeLayout(false);
            this.GroupBoxClassesFilms.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox GroupBoxClassesFilms;

        private System.Windows.Forms.TextBox TextBoxClassesFilmsGenre;

        private System.Windows.Forms.Label LabelClassesFilmsGenre;

        private System.Windows.Forms.TextBox TextBoxClassesFilmsName;

        private System.Windows.Forms.Label LabelClassesFilmsName;

        private System.Windows.Forms.Button ButtonClassesFilmsFind;

        private System.Windows.Forms.TextBox TextBoxClassesFilmsRating;

        private System.Windows.Forms.Label LabelClassesFilmsRating;

        private System.Windows.Forms.TextBox TextBoxClassesFilmsYear;

        private System.Windows.Forms.Label LabelClassesFilmsYear;

        private System.Windows.Forms.TextBox TextBoxClassesFilmsDuration;

        private System.Windows.Forms.Label LabelClassesFilmsDuration;

        private System.Windows.Forms.ListBox ListBoxClassesFilms;

        #endregion
    }
}