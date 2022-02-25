namespace Programming.view
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
            this.lbTextParse = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.tbValueParse = new System.Windows.Forms.TextBox();
            this.lbTypeValueParsing = new System.Windows.Forms.Label();
            this.gbSeasonHandle = new System.Windows.Forms.GroupBox();
            this.cbSeasons = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbChooseSeason = new System.Windows.Forms.Label();
            this.gbEnumirations = new System.Windows.Forms.GroupBox();
            this.tbIntValue = new System.Windows.Forms.TextBox();
            this.lbIntValue = new System.Windows.Forms.Label();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.lbChooseValue = new System.Windows.Forms.Label();
            this.enumsListBox = new System.Windows.Forms.ListBox();
            this.lbChooseEnymirations = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.tabPageEnums.SuspendLayout();
            this.gbWeekdayParsing.SuspendLayout();
            this.gbSeasonHandle.SuspendLayout();
            this.gbEnumirations.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPageEnums);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(800, 514);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPageEnums
            // 
            this.tabPageEnums.Controls.Add(this.gbWeekdayParsing);
            this.tabPageEnums.Controls.Add(this.gbSeasonHandle);
            this.tabPageEnums.Controls.Add(this.gbEnumirations);
            this.tabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnums.Name = "tabPageEnums";
            this.tabPageEnums.Padding = new System.Windows.Forms.Padding(7);
            this.tabPageEnums.Size = new System.Drawing.Size(792, 488);
            this.tabPageEnums.TabIndex = 0;
            this.tabPageEnums.Text = "Enums";
            this.tabPageEnums.UseVisualStyleBackColor = true;
            // 
            // gbWeekdayParsing
            // 
            this.gbWeekdayParsing.AutoSize = true;
            this.gbWeekdayParsing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbWeekdayParsing.Controls.Add(this.lbTextParse);
            this.gbWeekdayParsing.Controls.Add(this.btnParse);
            this.gbWeekdayParsing.Controls.Add(this.tbValueParse);
            this.gbWeekdayParsing.Controls.Add(this.lbTypeValueParsing);
            this.gbWeekdayParsing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbWeekdayParsing.Location = new System.Drawing.Point(7, 295);
            this.gbWeekdayParsing.Name = "gbWeekdayParsing";
            this.gbWeekdayParsing.Size = new System.Drawing.Size(778, 104);
            this.gbWeekdayParsing.TabIndex = 10;
            this.gbWeekdayParsing.TabStop = false;
            this.gbWeekdayParsing.Text = "Weekday parsing";
            // 
            // lbTextParse
            // 
            this.lbTextParse.Location = new System.Drawing.Point(6, 65);
            this.lbTextParse.Name = "lbTextParse";
            this.lbTextParse.Size = new System.Drawing.Size(233, 23);
            this.lbTextParse.TabIndex = 9;
            this.lbTextParse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // tbValueParse
            // 
            this.tbValueParse.Location = new System.Drawing.Point(6, 42);
            this.tbValueParse.Name = "tbValueParse";
            this.tbValueParse.Size = new System.Drawing.Size(149, 20);
            this.tbValueParse.TabIndex = 7;
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
            this.gbSeasonHandle.Controls.Add(this.cbSeasons);
            this.gbSeasonHandle.Controls.Add(this.btnGo);
            this.gbSeasonHandle.Controls.Add(this.lbChooseSeason);
            this.gbSeasonHandle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbSeasonHandle.Location = new System.Drawing.Point(7, 399);
            this.gbSeasonHandle.Name = "gbSeasonHandle";
            this.gbSeasonHandle.Size = new System.Drawing.Size(778, 82);
            this.gbSeasonHandle.TabIndex = 1;
            this.gbSeasonHandle.TabStop = false;
            this.gbSeasonHandle.Text = "Season Handle";
            // 
            // cbSeasons
            // 
            this.cbSeasons.FormattingEnabled = true;
            this.cbSeasons.Location = new System.Drawing.Point(6, 42);
            this.cbSeasons.Name = "cbSeasons";
            this.cbSeasons.Size = new System.Drawing.Size(149, 21);
            this.cbSeasons.TabIndex = 10;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(161, 39);
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
            // gbEnumirations
            // 
            this.gbEnumirations.AutoSize = true;
            this.gbEnumirations.Controls.Add(this.tbIntValue);
            this.gbEnumirations.Controls.Add(this.lbIntValue);
            this.gbEnumirations.Controls.Add(this.valuesListBox);
            this.gbEnumirations.Controls.Add(this.lbChooseValue);
            this.gbEnumirations.Controls.Add(this.enumsListBox);
            this.gbEnumirations.Controls.Add(this.lbChooseEnymirations);
            this.gbEnumirations.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEnumirations.Location = new System.Drawing.Point(7, 7);
            this.gbEnumirations.Margin = new System.Windows.Forms.Padding(7);
            this.gbEnumirations.Name = "gbEnumirations";
            this.gbEnumirations.Size = new System.Drawing.Size(778, 260);
            this.gbEnumirations.TabIndex = 0;
            this.gbEnumirations.TabStop = false;
            this.gbEnumirations.Text = "Enumirations";
            // 
            // tbIntValue
            // 
            this.tbIntValue.Location = new System.Drawing.Point(392, 42);
            this.tbIntValue.Name = "tbIntValue";
            this.tbIntValue.Size = new System.Drawing.Size(187, 20);
            this.tbIntValue.TabIndex = 5;
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
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.Location = new System.Drawing.Point(199, 42);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(187, 199);
            this.valuesListBox.TabIndex = 3;
            this.valuesListBox.SelectedIndexChanged += new System.EventHandler(this.valuesListBox_SelectedIndexChanged);
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
            // enumsListBox
            // 
            this.enumsListBox.FormattingEnabled = true;
            this.enumsListBox.Location = new System.Drawing.Point(6, 42);
            this.enumsListBox.Name = "enumsListBox";
            this.enumsListBox.Size = new System.Drawing.Size(187, 199);
            this.enumsListBox.TabIndex = 1;
            this.enumsListBox.SelectedIndexChanged += new System.EventHandler(this.enumsListBox_SelectedIndexChanged);
            // 
            // lbChooseEnymirations
            // 
            this.lbChooseEnymirations.Location = new System.Drawing.Point(6, 16);
            this.lbChooseEnymirations.Name = "lbChooseEnymirations";
            this.lbChooseEnymirations.Size = new System.Drawing.Size(187, 23);
            this.lbChooseEnymirations.TabIndex = 0;
            this.lbChooseEnymirations.Text = "Choose enymirations:";
            this.lbChooseEnymirations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 514);
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
            this.gbEnumirations.ResumeLayout(false);
            this.gbEnumirations.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cbSeasons;

        private System.Windows.Forms.GroupBox gbWeekdayParsing;
        private System.Windows.Forms.Label lbTextParse;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox tbValueParse;
        private System.Windows.Forms.Label lbTypeValueParsing;


        private System.Windows.Forms.Button btnGo;

        private System.Windows.Forms.Label lbChooseSeason;

        private System.Windows.Forms.GroupBox gbSeasonHandle;

        private System.Windows.Forms.Label lbIntValue;
        private System.Windows.Forms.TextBox tbIntValue;

        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.Label lbChooseValue;

        private System.Windows.Forms.ListBox enumsListBox;

        private System.Windows.Forms.Label lbChooseEnymirations;

        private System.Windows.Forms.GroupBox gbEnumirations;

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPageEnums;

        #endregion
    }
}