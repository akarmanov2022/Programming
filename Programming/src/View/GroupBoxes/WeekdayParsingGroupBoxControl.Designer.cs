using System.ComponentModel;

namespace Programming.View.GroupBoxes
{
    partial class WeekdayParsingGroupBoxControl
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
            this.gbWeekdayParsing = new System.Windows.Forms.GroupBox();
            this.LabelTextParse = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.TextBoxValueParse = new System.Windows.Forms.TextBox();
            this.lbTypeValueParsing = new System.Windows.Forms.Label();
            this.gbWeekdayParsing.SuspendLayout();
            this.SuspendLayout();
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
            this.gbWeekdayParsing.Location = new System.Drawing.Point(0, 0);
            this.gbWeekdayParsing.Name = "gbWeekdayParsing";
            this.gbWeekdayParsing.Size = new System.Drawing.Size(778, 104);
            this.gbWeekdayParsing.TabIndex = 11;
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
            // WeekdayParsingGroupBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbWeekdayParsing);
            this.Name = "WeekdayParsingGroupBoxControl";
            this.Size = new System.Drawing.Size(778, 104);
            this.gbWeekdayParsing.ResumeLayout(false);
            this.gbWeekdayParsing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox gbWeekdayParsing;

        private System.Windows.Forms.Label LabelTextParse;

        private System.Windows.Forms.Button btnParse;

        private System.Windows.Forms.TextBox TextBoxValueParse;

        private System.Windows.Forms.Label lbTypeValueParsing;

        #endregion
    }
}