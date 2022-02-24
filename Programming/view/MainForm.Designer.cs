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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTextParse = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.tbValueParse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSeasons = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIntValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enumsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.tabPageEnums.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // tabPage1
            // 
            this.tabPageEnums.Controls.Add(this.groupBox3);
            this.tabPageEnums.Controls.Add(this.groupBox2);
            this.tabPageEnums.Controls.Add(this.groupBox1);
            this.tabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnums.Name = "tabPageEnums";
            this.tabPageEnums.Padding = new System.Windows.Forms.Padding(7);
            this.tabPageEnums.Size = new System.Drawing.Size(792, 488);
            this.tabPageEnums.TabIndex = 0;
            this.tabPageEnums.Text = "Enums";
            this.tabPageEnums.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.lbTextParse);
            this.groupBox3.Controls.Add(this.btnParse);
            this.groupBox3.Controls.Add(this.tbValueParse);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(7, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(778, 104);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Weekday parsing";
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
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Type value of parsing:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.cbSeasons);
            this.groupBox2.Controls.Add(this.btnGo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(7, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Season Handle";
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
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Choose season:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tbIntValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.valuesListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.enumsListBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumirations";
            // 
            // tbIntValue
            // 
            this.tbIntValue.Location = new System.Drawing.Point(392, 42);
            this.tbIntValue.Name = "tbIntValue";
            this.tbIntValue.Size = new System.Drawing.Size(187, 20);
            this.tbIntValue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(392, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Int value:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(199, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose value:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose enymirations:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cbSeasons;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbTextParse;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox tbValueParse;
        private System.Windows.Forms.Label label6;


        private System.Windows.Forms.Button btnGo;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIntValue;

        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ListBox enumsListBox;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPageEnums;

        #endregion
    }
}