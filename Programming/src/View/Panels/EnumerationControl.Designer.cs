using System.ComponentModel;

namespace Programming.View.Panels
{
    partial class EnumerationControl
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
            this.gbEnumeration = new System.Windows.Forms.GroupBox();
            this.TextBoxIntValue = new System.Windows.Forms.TextBox();
            this.lbIntValue = new System.Windows.Forms.Label();
            this.ListBoxValues = new System.Windows.Forms.ListBox();
            this.lbChooseValue = new System.Windows.Forms.Label();
            this.ListBoxEnums = new System.Windows.Forms.ListBox();
            this.lbChooseEnumerations = new System.Windows.Forms.Label();
            this.gbEnumeration.SuspendLayout();
            this.SuspendLayout();
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
            this.gbEnumeration.Location = new System.Drawing.Point(0, 0);
            this.gbEnumeration.Margin = new System.Windows.Forms.Padding(7);
            this.gbEnumeration.Name = "gbEnumeration";
            this.gbEnumeration.Size = new System.Drawing.Size(778, 260);
            this.gbEnumeration.TabIndex = 1;
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
            this.ListBoxValues.SelectedIndexChanged += new System.EventHandler(this.ListBoxValues_SelectedIndexChanged);
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
            this.ListBoxEnums.SelectedIndexChanged += new System.EventHandler(this.ListBoxEnums_SelectedIndexChanged);
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
            // EnumerationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbEnumeration);
            this.Name = "EnumerationControl";
            this.Size = new System.Drawing.Size(778, 260);
            this.gbEnumeration.ResumeLayout(false);
            this.gbEnumeration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox gbEnumeration;

        private System.Windows.Forms.TextBox TextBoxIntValue;

        private System.Windows.Forms.Label lbIntValue;

        private System.Windows.Forms.ListBox ListBoxValues;

        private System.Windows.Forms.Label lbChooseValue;

        private System.Windows.Forms.ListBox ListBoxEnums;

        private System.Windows.Forms.Label lbChooseEnumerations;

        #endregion
    }
}