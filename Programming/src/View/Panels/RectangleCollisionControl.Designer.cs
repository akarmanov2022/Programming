using System.ComponentModel;

namespace Programming.View.Panels
{
    partial class RectangleCollisionControl
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
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.CanvaPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(95, 454);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(124, 20);
            this.HeightTextBox.TabIndex = 30;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Location = new System.Drawing.Point(8, 454);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(81, 20);
            this.HeightLabel.TabIndex = 29;
            this.HeightLabel.Text = "Height:";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(95, 402);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(124, 20);
            this.YTextBox.TabIndex = 27;
            this.YTextBox.TextChanged += new System.EventHandler(this.YTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(95, 428);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(124, 20);
            this.WidthTextBox.TabIndex = 28;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // YLabel
            // 
            this.YLabel.Location = new System.Drawing.Point(8, 402);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(81, 20);
            this.YLabel.TabIndex = 25;
            this.YLabel.Text = "Y:";
            this.YLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WidthLabel
            // 
            this.WidthLabel.Location = new System.Drawing.Point(8, 428);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(81, 20);
            this.WidthLabel.TabIndex = 26;
            this.WidthLabel.Text = "Width:";
            this.WidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(95, 376);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(124, 20);
            this.XTextBox.TabIndex = 24;
            this.XTextBox.TextChanged += new System.EventHandler(this.XTextBox_TextChanged);
            // 
            // XLabel
            // 
            this.XLabel.Location = new System.Drawing.Point(8, 376);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(81, 20);
            this.XLabel.TabIndex = 23;
            this.XLabel.Text = "X:";
            this.XLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(95, 350);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(124, 20);
            this.IdTextBox.TabIndex = 22;
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(8, 350);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(81, 20);
            this.IdLabel.TabIndex = 21;
            this.IdLabel.Text = "Id:";
            this.IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(8, 327);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(211, 23);
            this.SelectedRectangleLabel.TabIndex = 20;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            this.SelectedRectangleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClearButton
            // 
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Image = global::Programming.Resources.rectangle_remove_24x24_uncolor;
            this.ClearButton.Location = new System.Drawing.Point(74, 264);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(60, 60);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.ClearButton.MouseEnter += new System.EventHandler(this.ClearButton_MouseEnter);
            this.ClearButton.MouseLeave += new System.EventHandler(this.ClearButton_MouseLeave);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Image = global::Programming.Resources.rectangle_add_24x24_uncolor;
            this.AddRectangleButton.Location = new System.Drawing.Point(8, 264);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(60, 60);
            this.AddRectangleButton.TabIndex = 18;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddRectangleButton_MouseEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(8, 33);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(211, 225);
            this.RectanglesListBox.TabIndex = 17;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.Location = new System.Drawing.Point(8, 7);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(211, 23);
            this.RectanglesLabel.TabIndex = 16;
            this.RectanglesLabel.Text = "Rectangles:";
            this.RectanglesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CanvaPanel
            // 
            this.CanvaPanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvaPanel.Location = new System.Drawing.Point(225, 7);
            this.CanvaPanel.Name = "CanvaPanel";
            this.CanvaPanel.Size = new System.Drawing.Size(559, 582);
            this.CanvaPanel.TabIndex = 15;
            // 
            // RectangleCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddRectangleButton);
            this.Controls.Add(this.RectanglesListBox);
            this.Controls.Add(this.RectanglesLabel);
            this.Controls.Add(this.CanvaPanel);
            this.Name = "RectangleCollisionControl";
            this.Size = new System.Drawing.Size(792, 596);
            this.Load += new System.EventHandler(this.RectangleCollisionControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox HeightTextBox;

        private System.Windows.Forms.Label HeightLabel;

        private System.Windows.Forms.TextBox YTextBox;

        private System.Windows.Forms.TextBox WidthTextBox;

        private System.Windows.Forms.Label YLabel;

        private System.Windows.Forms.Label WidthLabel;

        private System.Windows.Forms.TextBox XTextBox;

        private System.Windows.Forms.Label XLabel;

        private System.Windows.Forms.TextBox IdTextBox;

        private System.Windows.Forms.Label IdLabel;

        private System.Windows.Forms.Label SelectedRectangleLabel;

        private System.Windows.Forms.Button ClearButton;

        private System.Windows.Forms.Button AddRectangleButton;

        private System.Windows.Forms.ListBox RectanglesListBox;

        private System.Windows.Forms.Label RectanglesLabel;

        private System.Windows.Forms.Panel CanvaPanel;

        #endregion
    }
}