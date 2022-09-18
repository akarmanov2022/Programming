using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsAddButton = new System.Windows.Forms.Button();
            this.ItemsRemoveButton = new System.Windows.Forms.Button();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedItemIdLable = new System.Windows.Forms.Label();
            this.SelectedItemCostLabel = new System.Windows.Forms.Label();
            this.SelectedItemIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemCostTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectedItemNameLabel = new System.Windows.Forms.Label();
            this.SelectedItemNameTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectedItemDescriptionLabel = new System.Windows.Forms.Label();
            this.SelectedItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ItemsAddButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemsRemoveButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 832);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ItemsAddButton
            // 
            this.ItemsAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsAddButton.Location = new System.Drawing.Point(3, 3);
            this.ItemsAddButton.Name = "ItemsAddButton";
            this.ItemsAddButton.Size = new System.Drawing.Size(137, 44);
            this.ItemsAddButton.TabIndex = 0;
            this.ItemsAddButton.Text = "Add";
            this.ItemsAddButton.UseVisualStyleBackColor = true;
            this.ItemsAddButton.Click += new System.EventHandler(this.ItemsAddButton_Click);
            // 
            // ItemsRemoveButton
            // 
            this.ItemsRemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsRemoveButton.Location = new System.Drawing.Point(146, 3);
            this.ItemsRemoveButton.Name = "ItemsRemoveButton";
            this.ItemsRemoveButton.Size = new System.Drawing.Size(137, 44);
            this.ItemsRemoveButton.TabIndex = 1;
            this.ItemsRemoveButton.Text = "Remove";
            this.ItemsRemoveButton.UseVisualStyleBackColor = true;
            this.ItemsRemoveButton.Click += new System.EventHandler(this.ItemsRemoveButton_Click);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.Location = new System.Drawing.Point(0, 0);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(429, 43);
            this.ItemsLabel.TabIndex = 2;
            this.ItemsLabel.Text = "Items";
            this.ItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(0, 46);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(429, 784);
            this.ItemsListBox.TabIndex = 3;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.Location = new System.Drawing.Point(441, 0);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(326, 43);
            this.SelectedItemLabel.TabIndex = 4;
            this.SelectedItemLabel.Text = "Selected Item";
            this.SelectedItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.SelectedItemIdLable, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SelectedItemCostLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.SelectedItemIdTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SelectedItemCostTextBox, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(441, 46);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(644, 99);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // SelectedItemIdLable
            // 
            this.SelectedItemIdLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemIdLable.Location = new System.Drawing.Point(3, 0);
            this.SelectedItemIdLable.Name = "SelectedItemIdLable";
            this.SelectedItemIdLable.Size = new System.Drawing.Size(59, 49);
            this.SelectedItemIdLable.TabIndex = 0;
            this.SelectedItemIdLable.Text = "Id:";
            this.SelectedItemIdLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedItemCostLabel
            // 
            this.SelectedItemCostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemCostLabel.Location = new System.Drawing.Point(3, 49);
            this.SelectedItemCostLabel.Name = "SelectedItemCostLabel";
            this.SelectedItemCostLabel.Size = new System.Drawing.Size(59, 50);
            this.SelectedItemCostLabel.TabIndex = 1;
            this.SelectedItemCostLabel.Text = "Cost:";
            this.SelectedItemCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedItemIdTextBox
            // 
            this.SelectedItemIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemIdTextBox.Location = new System.Drawing.Point(68, 11);
            this.SelectedItemIdTextBox.Name = "SelectedItemIdTextBox";
            this.SelectedItemIdTextBox.ReadOnly = true;
            this.SelectedItemIdTextBox.Size = new System.Drawing.Size(573, 26);
            this.SelectedItemIdTextBox.TabIndex = 2;
            // 
            // SelectedItemCostTextBox
            // 
            this.SelectedItemCostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemCostTextBox.Location = new System.Drawing.Point(68, 61);
            this.SelectedItemCostTextBox.Name = "SelectedItemCostTextBox";
            this.SelectedItemCostTextBox.Size = new System.Drawing.Size(573, 26);
            this.SelectedItemCostTextBox.TabIndex = 3;
            this.SelectedItemCostTextBox.TextChanged += new System.EventHandler(this.SelectedItemCostTextBox_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SelectedItemNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.SelectedItemNameTextBox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(441, 151);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(644, 272);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // SelectedItemNameLabel
            // 
            this.SelectedItemNameLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedItemNameLabel.Name = "SelectedItemNameLabel";
            this.SelectedItemNameLabel.Size = new System.Drawing.Size(623, 23);
            this.SelectedItemNameLabel.TabIndex = 0;
            this.SelectedItemNameLabel.Text = "Name:";
            // 
            // SelectedItemNameTextBox
            // 
            this.SelectedItemNameTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectedItemNameTextBox.Location = new System.Drawing.Point(3, 26);
            this.SelectedItemNameTextBox.Multiline = true;
            this.SelectedItemNameTextBox.Name = "SelectedItemNameTextBox";
            this.SelectedItemNameTextBox.Size = new System.Drawing.Size(635, 230);
            this.SelectedItemNameTextBox.TabIndex = 1;
            this.SelectedItemNameTextBox.TextChanged += new System.EventHandler(this.SelectedItemNameTextBox_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.SelectedItemDescriptionLabel);
            this.flowLayoutPanel2.Controls.Add(this.SelectedItemDescriptionTextBox);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(441, 429);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(644, 359);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // SelectedItemDescriptionLabel
            // 
            this.SelectedItemDescriptionLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedItemDescriptionLabel.Name = "SelectedItemDescriptionLabel";
            this.SelectedItemDescriptionLabel.Size = new System.Drawing.Size(638, 23);
            this.SelectedItemDescriptionLabel.TabIndex = 0;
            this.SelectedItemDescriptionLabel.Text = "Description:";
            // 
            // SelectedItemDescriptionTextBox
            // 
            this.SelectedItemDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectedItemDescriptionTextBox.Location = new System.Drawing.Point(3, 26);
            this.SelectedItemDescriptionTextBox.Multiline = true;
            this.SelectedItemDescriptionTextBox.Name = "SelectedItemDescriptionTextBox";
            this.SelectedItemDescriptionTextBox.Size = new System.Drawing.Size(635, 230);
            this.SelectedItemDescriptionTextBox.TabIndex = 1;
            this.SelectedItemDescriptionTextBox.TextChanged += new System.EventHandler(this.SelectedItemDescriptionTextBox_TextChanged);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.SelectedItemLabel);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(1085, 882);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;

        private System.Windows.Forms.Label SelectedItemDescriptionLabel;

        private System.Windows.Forms.TextBox SelectedItemDescriptionTextBox;

        private System.Windows.Forms.TextBox SelectedItemNameTextBox;

        private System.Windows.Forms.Label SelectedItemNameLabel;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private System.Windows.Forms.TextBox SelectedItemCostTextBox;

        private System.Windows.Forms.TextBox SelectedItemIdTextBox;

        private System.Windows.Forms.Label SelectedItemCostLabel;

        private System.Windows.Forms.Label SelectedItemIdLable;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private System.Windows.Forms.Label SelectedItemLabel;

        private System.Windows.Forms.Label ItemsLabel;

        private System.Windows.Forms.ListBox ItemsListBox;

        private System.Windows.Forms.Button ItemsAddButton;

        private System.Windows.Forms.Button ItemsRemoveButton;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}