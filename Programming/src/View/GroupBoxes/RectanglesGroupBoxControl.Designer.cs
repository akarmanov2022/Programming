using System.ComponentModel;

namespace Programming.View.GroupBoxes
{
    partial class RectanglesGroupBoxControl
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
            this.GroupBoxClassesRectangles = new System.Windows.Forms.GroupBox();
            this.TextBoxClassesRectangleId = new System.Windows.Forms.TextBox();
            this.LabelClassesRectangleId = new System.Windows.Forms.Label();
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
            this.GroupBoxClassesRectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxClassesRectangles
            // 
            this.GroupBoxClassesRectangles.Controls.Add(this.TextBoxClassesRectangleId);
            this.GroupBoxClassesRectangles.Controls.Add(this.LabelClassesRectangleId);
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
            this.GroupBoxClassesRectangles.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxClassesRectangles.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxClassesRectangles.Name = "GroupBoxClassesRectangles";
            this.GroupBoxClassesRectangles.Size = new System.Drawing.Size(786, 223);
            this.GroupBoxClassesRectangles.TabIndex = 1;
            this.GroupBoxClassesRectangles.TabStop = false;
            this.GroupBoxClassesRectangles.Text = "Rectangles";
            // 
            // TextBoxClassesRectangleId
            // 
            this.TextBoxClassesRectangleId.Location = new System.Drawing.Point(324, 32);
            this.TextBoxClassesRectangleId.Name = "TextBoxClassesRectangleId";
            this.TextBoxClassesRectangleId.Size = new System.Drawing.Size(170, 20);
            this.TextBoxClassesRectangleId.TabIndex = 11;
            // 
            // LabelClassesRectangleId
            // 
            this.LabelClassesRectangleId.Location = new System.Drawing.Point(324, 16);
            this.LabelClassesRectangleId.Name = "LabelClassesRectangleId";
            this.LabelClassesRectangleId.Size = new System.Drawing.Size(167, 13);
            this.LabelClassesRectangleId.TabIndex = 10;
            this.LabelClassesRectangleId.Text = "Id:";
            // 
            // TextBoxClassesRectangleCenter
            // 
            this.TextBoxClassesRectangleCenter.Location = new System.Drawing.Point(148, 149);
            this.TextBoxClassesRectangleCenter.Name = "TextBoxClassesRectangleCenter";
            this.TextBoxClassesRectangleCenter.Size = new System.Drawing.Size(170, 20);
            this.TextBoxClassesRectangleCenter.TabIndex = 9;
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
            this.ButtonClassesRectangleFind.Location = new System.Drawing.Point(705, 182);
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
            this.LabelClassesRectangleLength.Text = "Height:";
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
            // RectanglesGroupBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxClassesRectangles);
            this.Name = "RectanglesGroupBoxControl";
            this.Size = new System.Drawing.Size(786, 223);
            this.GroupBoxClassesRectangles.ResumeLayout(false);
            this.GroupBoxClassesRectangles.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox GroupBoxClassesRectangles;

        private System.Windows.Forms.TextBox TextBoxClassesRectangleId;

        private System.Windows.Forms.Label LabelClassesRectangleId;

        private System.Windows.Forms.TextBox TextBoxClassesRectangleCenter;

        private System.Windows.Forms.Label LabelClassesRectangleCenter;

        private System.Windows.Forms.Button ButtonClassesRectangleFind;

        private System.Windows.Forms.TextBox TextBoxClassesRectangleColor;

        private System.Windows.Forms.Label LabelClassesRectangleColor;

        private System.Windows.Forms.TextBox TextBoxClassesRectangleWidth;

        private System.Windows.Forms.Label LabelClassesRectangleWidth;

        private System.Windows.Forms.TextBox TextBoxClassesRectangleLength;

        private System.Windows.Forms.Label LabelClassesRectangleLength;

        private System.Windows.Forms.ListBox ListBoxClassesRectangles;

        #endregion
    }
}