﻿namespace Programming.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPageEnums = new System.Windows.Forms.TabPage();
            this.gbWeekdayParsing = new System.Windows.Forms.GroupBox();
            this.LabelTextParse = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.TextBoxValueParse = new System.Windows.Forms.TextBox();
            this.lbTypeValueParsing = new System.Windows.Forms.Label();
            this.gbSeasonHandle = new System.Windows.Forms.GroupBox();
            this.ComboBoxSeasons = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbChooseSeason = new System.Windows.Forms.Label();
            this.gbEnumeration = new System.Windows.Forms.GroupBox();
            this.TextBoxIntValue = new System.Windows.Forms.TextBox();
            this.lbIntValue = new System.Windows.Forms.Label();
            this.ListBoxValues = new System.Windows.Forms.ListBox();
            this.lbChooseValue = new System.Windows.Forms.Label();
            this.ListBoxEnums = new System.Windows.Forms.ListBox();
            this.lbChooseEnumerations = new System.Windows.Forms.Label();
            this.TabPageClasses = new System.Windows.Forms.TabPage();
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
            this.GroupBoxClassesRectangles = new System.Windows.Forms.GroupBox();
            this.TextBoxClassesRectangleCenter = new System.Windows.Forms.TextBox();
            this.LabelClassesRectangleCenter = new System.Windows.Forms.Label();
            this.ButtonClassesRectangleFind = new System.Windows.Forms.Button();
            this.TextBoxClassesRectangleColor = new System.Windows.Forms.TextBox();
            this.LabelClassesRectangleColor = new System.Windows.Forms.Label();
            this.TextBoxClassesRectangleWidth = new System.Windows.Forms.TextBox();
            this.LabelClassesRectangleWidth = new System.Windows.Forms.Label();
            this.TextBoxClassesRectangleLength = new System.Windows.Forms.TextBox();
            this.LabelClassesRectangleLength = new System.Windows.Forms.Label();
            this.ListBoxClassesRectangles = new System.Windows.Forms.ListBox();
            this.mainTabControl.SuspendLayout();
            this.tabPageEnums.SuspendLayout();
            this.gbWeekdayParsing.SuspendLayout();
            this.gbSeasonHandle.SuspendLayout();
            this.gbEnumeration.SuspendLayout();
            this.TabPageClasses.SuspendLayout();
            this.GroupBoxClassesFilms.SuspendLayout();
            this.GroupBoxClassesRectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPageEnums);
            this.mainTabControl.Controls.Add(this.TabPageClasses);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(800, 619);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPageEnums
            // 
            this.tabPageEnums.Controls.Add(this.gbWeekdayParsing);
            this.tabPageEnums.Controls.Add(this.gbSeasonHandle);
            this.tabPageEnums.Controls.Add(this.gbEnumeration);
            this.tabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnums.Name = "tabPageEnums";
            this.tabPageEnums.Padding = new System.Windows.Forms.Padding(7);
            this.tabPageEnums.Size = new System.Drawing.Size(792, 593);
            this.tabPageEnums.TabIndex = 0;
            this.tabPageEnums.Text = "Enums";
            this.tabPageEnums.UseVisualStyleBackColor = true;
            // 
            // gbWeekdayParsing
            // 
            this.gbWeekdayParsing.AutoSize = true;
            this.gbWeekdayParsing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbWeekdayParsing.Controls.Add(this.LabelTextParse);
            this.gbWeekdayParsing.Controls.Add(this.btnParse);
            this.gbWeekdayParsing.Controls.Add(this.TextBoxValueParse);
            this.gbWeekdayParsing.Controls.Add(this.lbTypeValueParsing);
            this.gbWeekdayParsing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbWeekdayParsing.Location = new System.Drawing.Point(7, 400);
            this.gbWeekdayParsing.Name = "gbWeekdayParsing";
            this.gbWeekdayParsing.Size = new System.Drawing.Size(778, 104);
            this.gbWeekdayParsing.TabIndex = 10;
            this.gbWeekdayParsing.TabStop = false;
            this.gbWeekdayParsing.Text = "Weekday Parsing";
            // 
            // LabelTextParse
            // 
            this.LabelTextParse.Location = new System.Drawing.Point(6, 65);
            this.LabelTextParse.Name = "LabelTextParse";
            this.LabelTextParse.Size = new System.Drawing.Size(233, 23);
            this.LabelTextParse.TabIndex = 9;
            this.LabelTextParse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(161, 39);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 8;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // TextBoxValueParse
            // 
            this.TextBoxValueParse.Location = new System.Drawing.Point(6, 42);
            this.TextBoxValueParse.Name = "TextBoxValueParse";
            this.TextBoxValueParse.Size = new System.Drawing.Size(149, 20);
            this.TextBoxValueParse.TabIndex = 7;
            // 
            // lbTypeValueParsing
            // 
            this.lbTypeValueParsing.Location = new System.Drawing.Point(6, 16);
            this.lbTypeValueParsing.Name = "lbTypeValueParsing";
            this.lbTypeValueParsing.Size = new System.Drawing.Size(187, 23);
            this.lbTypeValueParsing.TabIndex = 6;
            this.lbTypeValueParsing.Text = "Type value of parsing:";
            this.lbTypeValueParsing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbSeasonHandle
            // 
            this.gbSeasonHandle.AutoSize = true;
            this.gbSeasonHandle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbSeasonHandle.Controls.Add(this.ComboBoxSeasons);
            this.gbSeasonHandle.Controls.Add(this.btnGo);
            this.gbSeasonHandle.Controls.Add(this.lbChooseSeason);
            this.gbSeasonHandle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbSeasonHandle.Location = new System.Drawing.Point(7, 504);
            this.gbSeasonHandle.Name = "gbSeasonHandle";
            this.gbSeasonHandle.Size = new System.Drawing.Size(778, 82);
            this.gbSeasonHandle.TabIndex = 1;
            this.gbSeasonHandle.TabStop = false;
            this.gbSeasonHandle.Text = "Season Handle";
            // 
            // ComboBoxSeasons
            // 
            this.ComboBoxSeasons.FormattingEnabled = true;
            this.ComboBoxSeasons.Location = new System.Drawing.Point(6, 42);
            this.ComboBoxSeasons.Name = "ComboBoxSeasons";
            this.ComboBoxSeasons.Size = new System.Drawing.Size(149, 21);
            this.ComboBoxSeasons.TabIndex = 10;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(161, 40);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lbChooseSeason
            // 
            this.lbChooseSeason.Location = new System.Drawing.Point(6, 16);
            this.lbChooseSeason.Name = "lbChooseSeason";
            this.lbChooseSeason.Size = new System.Drawing.Size(187, 23);
            this.lbChooseSeason.TabIndex = 6;
            this.lbChooseSeason.Text = "Choose season:";
            this.lbChooseSeason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbEnumeration
            // 
            this.gbEnumeration.AutoSize = true;
            this.gbEnumeration.Controls.Add(this.TextBoxIntValue);
            this.gbEnumeration.Controls.Add(this.lbIntValue);
            this.gbEnumeration.Controls.Add(this.ListBoxValues);
            this.gbEnumeration.Controls.Add(this.lbChooseValue);
            this.gbEnumeration.Controls.Add(this.ListBoxEnums);
            this.gbEnumeration.Controls.Add(this.lbChooseEnumerations);
            this.gbEnumeration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEnumeration.Location = new System.Drawing.Point(7, 7);
            this.gbEnumeration.Margin = new System.Windows.Forms.Padding(7);
            this.gbEnumeration.Name = "gbEnumeration";
            this.gbEnumeration.Size = new System.Drawing.Size(778, 260);
            this.gbEnumeration.TabIndex = 0;
            this.gbEnumeration.TabStop = false;
            this.gbEnumeration.Text = "Enumeration";
            // 
            // TextBoxIntValue
            // 
            this.TextBoxIntValue.Location = new System.Drawing.Point(392, 42);
            this.TextBoxIntValue.Name = "TextBoxIntValue";
            this.TextBoxIntValue.Size = new System.Drawing.Size(187, 20);
            this.TextBoxIntValue.TabIndex = 5;
            // 
            // lbIntValue
            // 
            this.lbIntValue.Location = new System.Drawing.Point(392, 16);
            this.lbIntValue.Name = "lbIntValue";
            this.lbIntValue.Size = new System.Drawing.Size(187, 23);
            this.lbIntValue.TabIndex = 4;
            this.lbIntValue.Text = "Int value:";
            this.lbIntValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListBoxValues
            // 
            this.ListBoxValues.FormattingEnabled = true;
            this.ListBoxValues.Location = new System.Drawing.Point(199, 42);
            this.ListBoxValues.Name = "ListBoxValues";
            this.ListBoxValues.Size = new System.Drawing.Size(187, 199);
            this.ListBoxValues.TabIndex = 3;
            this.ListBoxValues.SelectedIndexChanged += new System.EventHandler(this.valuesListBox_SelectedIndexChanged);
            // 
            // lbChooseValue
            // 
            this.lbChooseValue.Location = new System.Drawing.Point(199, 16);
            this.lbChooseValue.Name = "lbChooseValue";
            this.lbChooseValue.Size = new System.Drawing.Size(187, 23);
            this.lbChooseValue.TabIndex = 2;
            this.lbChooseValue.Text = "Choose value:";
            this.lbChooseValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListBoxEnums
            // 
            this.ListBoxEnums.FormattingEnabled = true;
            this.ListBoxEnums.Location = new System.Drawing.Point(6, 42);
            this.ListBoxEnums.Name = "ListBoxEnums";
            this.ListBoxEnums.Size = new System.Drawing.Size(187, 199);
            this.ListBoxEnums.TabIndex = 1;
            this.ListBoxEnums.SelectedIndexChanged += new System.EventHandler(this.enumsListBox_SelectedIndexChanged);
            // 
            // lbChooseEnumerations
            // 
            this.lbChooseEnumerations.Location = new System.Drawing.Point(6, 16);
            this.lbChooseEnumerations.Name = "lbChooseEnumerations";
            this.lbChooseEnumerations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbChooseEnumerations.Size = new System.Drawing.Size(187, 23);
            this.lbChooseEnumerations.TabIndex = 0;
            this.lbChooseEnumerations.Text = "Choose enumeration:";
            this.lbChooseEnumerations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TabPageClasses
            // 
            this.TabPageClasses.Controls.Add(this.GroupBoxClassesFilms);
            this.TabPageClasses.Controls.Add(this.GroupBoxClassesRectangles);
            this.TabPageClasses.Location = new System.Drawing.Point(4, 22);
            this.TabPageClasses.Name = "TabPageClasses";
            this.TabPageClasses.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageClasses.Size = new System.Drawing.Size(792, 593);
            this.TabPageClasses.TabIndex = 1;
            this.TabPageClasses.Text = "Classes";
            this.TabPageClasses.UseVisualStyleBackColor = true;
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
            this.GroupBoxClassesFilms.Location = new System.Drawing.Point(6, 232);
            this.GroupBoxClassesFilms.Name = "GroupBoxClassesFilms";
            this.GroupBoxClassesFilms.Size = new System.Drawing.Size(321, 293);
            this.GroupBoxClassesFilms.TabIndex = 8;
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
            this.ButtonClassesFilmsFind.Location = new System.Drawing.Point(240, 252);
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
            // GroupBoxClassesRectangles
            // 
            this.GroupBoxClassesRectangles.Controls.Add(this.TextBoxClassesRectangleCenter);
            this.GroupBoxClassesRectangles.Controls.Add(this.LabelClassesRectangleCenter);
            this.GroupBoxClassesRectangles.Controls.Add(this.ButtonClassesRectangleFind);
            this.GroupBoxClassesRectangles.Controls.Add(this.TextBoxClassesRectangleColor);
            this.GroupBoxClassesRectangles.Controls.Add(this.LabelClassesRectangleColor);
            this.GroupBoxClassesRectangles.Controls.Add(this.TextBoxClassesRectangleWidth);
            this.GroupBoxClassesRectangles.Controls.Add(this.LabelClassesRectangleWidth);
            this.GroupBoxClassesRectangles.Controls.Add(this.TextBoxClassesRectangleLength);
            this.GroupBoxClassesRectangles.Controls.Add(this.LabelClassesRectangleLength);
            this.GroupBoxClassesRectangles.Controls.Add(this.ListBoxClassesRectangles);
            this.GroupBoxClassesRectangles.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxClassesRectangles.Name = "GroupBoxClassesRectangles";
            this.GroupBoxClassesRectangles.Size = new System.Drawing.Size(324, 223);
            this.GroupBoxClassesRectangles.TabIndex = 0;
            this.GroupBoxClassesRectangles.TabStop = false;
            this.GroupBoxClassesRectangles.Text = "Rectangles";
            // 
            // TextBoxClassesRectangleCenter
            // 
            this.TextBoxClassesRectangleCenter.Location = new System.Drawing.Point(148, 149);
            this.TextBoxClassesRectangleCenter.Name = "TextBoxClassesRectangleCenter";
            this.TextBoxClassesRectangleCenter.Size = new System.Drawing.Size(170, 20);
            this.TextBoxClassesRectangleCenter.TabIndex = 9;
            this.TextBoxClassesRectangleCenter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxClassesRectangleCenter_KeyPress);
            // 
            // LabelClassesRectangleCenter
            // 
            this.LabelClassesRectangleCenter.Location = new System.Drawing.Point(148, 133);
            this.LabelClassesRectangleCenter.Name = "LabelClassesRectangleCenter";
            this.LabelClassesRectangleCenter.Size = new System.Drawing.Size(167, 13);
            this.LabelClassesRectangleCenter.TabIndex = 8;
            this.LabelClassesRectangleCenter.Text = "Center:";
            // 
            // ButtonClassesRectangleFind
            // 
            this.ButtonClassesRectangleFind.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClassesRectangleFind.Location = new System.Drawing.Point(243, 182);
            this.ButtonClassesRectangleFind.Name = "ButtonClassesRectangleFind";
            this.ButtonClassesRectangleFind.Size = new System.Drawing.Size(75, 23);
            this.ButtonClassesRectangleFind.TabIndex = 7;
            this.ButtonClassesRectangleFind.Text = "Find";
            this.ButtonClassesRectangleFind.UseVisualStyleBackColor = true;
            this.ButtonClassesRectangleFind.Click += new System.EventHandler(this.ButtonClassesRectangleFind_Click);
            // 
            // TextBoxClassesRectangleColor
            // 
            this.TextBoxClassesRectangleColor.Location = new System.Drawing.Point(148, 110);
            this.TextBoxClassesRectangleColor.Name = "TextBoxClassesRectangleColor";
            this.TextBoxClassesRectangleColor.Size = new System.Drawing.Size(170, 20);
            this.TextBoxClassesRectangleColor.TabIndex = 6;
            this.TextBoxClassesRectangleColor.TextChanged += new System.EventHandler(this.TextBoxClassesRectangleColor_TextChanged);
            // 
            // LabelClassesRectangleColor
            // 
            this.LabelClassesRectangleColor.Location = new System.Drawing.Point(148, 94);
            this.LabelClassesRectangleColor.Name = "LabelClassesRectangleColor";
            this.LabelClassesRectangleColor.Size = new System.Drawing.Size(167, 13);
            this.LabelClassesRectangleColor.TabIndex = 5;
            this.LabelClassesRectangleColor.Text = "Color:";
            // 
            // TextBoxClassesRectangleWidth
            // 
            this.TextBoxClassesRectangleWidth.Location = new System.Drawing.Point(148, 71);
            this.TextBoxClassesRectangleWidth.Name = "TextBoxClassesRectangleWidth";
            this.TextBoxClassesRectangleWidth.Size = new System.Drawing.Size(170, 20);
            this.TextBoxClassesRectangleWidth.TabIndex = 4;
            this.TextBoxClassesRectangleWidth.TextChanged += new System.EventHandler(this.TextBoxClassesRectangleWidth_TextChanged);
            // 
            // LabelClassesRectangleWidth
            // 
            this.LabelClassesRectangleWidth.Location = new System.Drawing.Point(148, 55);
            this.LabelClassesRectangleWidth.Name = "LabelClassesRectangleWidth";
            this.LabelClassesRectangleWidth.Size = new System.Drawing.Size(167, 13);
            this.LabelClassesRectangleWidth.TabIndex = 3;
            this.LabelClassesRectangleWidth.Text = "Width:";
            // 
            // TextBoxClassesRectangleLength
            // 
            this.TextBoxClassesRectangleLength.Location = new System.Drawing.Point(148, 32);
            this.TextBoxClassesRectangleLength.Name = "TextBoxClassesRectangleLength";
            this.TextBoxClassesRectangleLength.Size = new System.Drawing.Size(170, 20);
            this.TextBoxClassesRectangleLength.TabIndex = 2;
            this.TextBoxClassesRectangleLength.TextChanged += new System.EventHandler(this.TextBoxClassesRectangleLength_TextChanged);
            // 
            // LabelClassesRectangleLength
            // 
            this.LabelClassesRectangleLength.Location = new System.Drawing.Point(148, 16);
            this.LabelClassesRectangleLength.Name = "LabelClassesRectangleLength";
            this.LabelClassesRectangleLength.Size = new System.Drawing.Size(167, 13);
            this.LabelClassesRectangleLength.TabIndex = 1;
            this.LabelClassesRectangleLength.Text = "Length:";
            // 
            // ListBoxClassesRectangles
            // 
            this.ListBoxClassesRectangles.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBoxClassesRectangles.FormattingEnabled = true;
            this.ListBoxClassesRectangles.Location = new System.Drawing.Point(6, 19);
            this.ListBoxClassesRectangles.Name = "ListBoxClassesRectangles";
            this.ListBoxClassesRectangles.Size = new System.Drawing.Size(136, 186);
            this.ListBoxClassesRectangles.TabIndex = 0;
            this.ListBoxClassesRectangles.SelectedIndexChanged += new System.EventHandler(this.ListBoxClassesRectangles_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tabPageEnums.ResumeLayout(false);
            this.tabPageEnums.PerformLayout();
            this.gbWeekdayParsing.ResumeLayout(false);
            this.gbWeekdayParsing.PerformLayout();
            this.gbSeasonHandle.ResumeLayout(false);
            this.gbEnumeration.ResumeLayout(false);
            this.gbEnumeration.PerformLayout();
            this.TabPageClasses.ResumeLayout(false);
            this.GroupBoxClassesFilms.ResumeLayout(false);
            this.GroupBoxClassesFilms.PerformLayout();
            this.GroupBoxClassesRectangles.ResumeLayout(false);
            this.GroupBoxClassesRectangles.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox TextBoxClassesRectangleCenter;
        private System.Windows.Forms.Label LabelClassesRectangleCenter;

        private System.Windows.Forms.TextBox TextBoxClassesFilmsGenre;
        private System.Windows.Forms.Label LabelClassesFilmsGenre;

        private System.Windows.Forms.TextBox TextBoxClassesFilmsName;
        private System.Windows.Forms.Label LabelClassesFilmsName;

        private System.Windows.Forms.GroupBox GroupBoxClassesFilms;
        private System.Windows.Forms.Button ButtonClassesFilmsFind;
        private System.Windows.Forms.TextBox TextBoxClassesFilmsRating;
        private System.Windows.Forms.Label LabelClassesFilmsRating;
        private System.Windows.Forms.TextBox TextBoxClassesFilmsYear;
        private System.Windows.Forms.Label LabelClassesFilmsYear;
        private System.Windows.Forms.TextBox TextBoxClassesFilmsDuration;
        private System.Windows.Forms.Label LabelClassesFilmsDuration;
        private System.Windows.Forms.ListBox ListBoxClassesFilms;

        private System.Windows.Forms.Button ButtonClassesRectangleFind;

        private System.Windows.Forms.TextBox TextBoxClassesRectangleWidth;
        private System.Windows.Forms.Label LabelClassesRectangleWidth;
        private System.Windows.Forms.TextBox TextBoxClassesRectangleColor;
        private System.Windows.Forms.Label LabelClassesRectangleColor;

        private System.Windows.Forms.TextBox TextBoxClassesRectangleLength;

        private System.Windows.Forms.Label LabelClassesRectangleLength;

        private System.Windows.Forms.ListBox ListBoxClassesRectangles;

        private System.Windows.Forms.GroupBox GroupBoxClassesRectangles;

        private System.Windows.Forms.TabPage TabPageClasses;

        private System.Windows.Forms.ComboBox ComboBoxSeasons;

        private System.Windows.Forms.GroupBox gbWeekdayParsing;
        private System.Windows.Forms.Label LabelTextParse;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox TextBoxValueParse;
        private System.Windows.Forms.Label lbTypeValueParsing;


        private System.Windows.Forms.Button btnGo;

        private System.Windows.Forms.Label lbChooseSeason;

        private System.Windows.Forms.GroupBox gbSeasonHandle;

        private System.Windows.Forms.Label lbIntValue;
        private System.Windows.Forms.TextBox TextBoxIntValue;

        private System.Windows.Forms.ListBox ListBoxValues;
        private System.Windows.Forms.Label lbChooseValue;

        private System.Windows.Forms.ListBox ListBoxEnums;

        private System.Windows.Forms.Label lbChooseEnumerations;

        private System.Windows.Forms.GroupBox gbEnumeration;

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPageEnums;

        #endregion
    }
}