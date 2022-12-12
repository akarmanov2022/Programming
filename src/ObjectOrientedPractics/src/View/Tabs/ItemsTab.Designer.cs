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
            this.ItemsRandomButton = new System.Windows.Forms.Button();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.SelectedItemIdLable = new System.Windows.Forms.Label();
            this.SelectedItemCostLabel = new System.Windows.Forms.Label();
            this.SelectedItemIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemCostTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemNameLabel = new System.Windows.Forms.Label();
            this.SelectedItemNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemDescriptionLabel = new System.Windows.Forms.Label();
            this.SelectedItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectedItemCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SelectedItemCategoryLabel = new System.Windows.Forms.Label();
            this.ItemsFindTextBox = new System.Windows.Forms.TextBox();
            this.ItemsFindlabel = new System.Windows.Forms.Label();
            this.ItemsOrderByLabel = new System.Windows.Forms.Label();
            this.ItemsOrderByComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.ItemsRandomButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1064);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 87);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ItemsAddButton
            // 
            this.ItemsAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsAddButton.Location = new System.Drawing.Point(3, 3);
            this.ItemsAddButton.Name = "ItemsAddButton";
            this.ItemsAddButton.Size = new System.Drawing.Size(137, 81);
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
            this.ItemsRemoveButton.Size = new System.Drawing.Size(137, 81);
            this.ItemsRemoveButton.TabIndex = 1;
            this.ItemsRemoveButton.Text = "Remove";
            this.ItemsRemoveButton.UseVisualStyleBackColor = true;
            this.ItemsRemoveButton.Click += new System.EventHandler(this.ItemsRemoveButton_Click);
            // 
            // ItemsRandomButton
            // 
            this.ItemsRandomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsRandomButton.Location = new System.Drawing.Point(289, 3);
            this.ItemsRandomButton.Name = "ItemsRandomButton";
            this.ItemsRandomButton.Size = new System.Drawing.Size(137, 81);
            this.ItemsRandomButton.TabIndex = 2;
            this.ItemsRandomButton.Text = "Random";
            this.ItemsRandomButton.UseVisualStyleBackColor = true;
            this.ItemsRandomButton.Click += new System.EventHandler(this.ItemsRandomButton_Click);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.ItemsListBox.Location = new System.Drawing.Point(0, 106);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(429, 884);
            this.ItemsListBox.TabIndex = 3;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(326, 43);
            this.SelectedItemLabel.TabIndex = 4;
            this.SelectedItemLabel.Text = "Selected Item";
            this.SelectedItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedItemIdLable
            // 
            this.SelectedItemIdLable.Location = new System.Drawing.Point(3, 67);
            this.SelectedItemIdLable.Name = "SelectedItemIdLable";
            this.SelectedItemIdLable.Size = new System.Drawing.Size(96, 26);
            this.SelectedItemIdLable.TabIndex = 0;
            this.SelectedItemIdLable.Text = "Id:";
            this.SelectedItemIdLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedItemCostLabel
            // 
            this.SelectedItemCostLabel.Location = new System.Drawing.Point(3, 99);
            this.SelectedItemCostLabel.Name = "SelectedItemCostLabel";
            this.SelectedItemCostLabel.Size = new System.Drawing.Size(96, 26);
            this.SelectedItemCostLabel.TabIndex = 1;
            this.SelectedItemCostLabel.Text = "Cost:";
            this.SelectedItemCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedItemIdTextBox
            // 
            this.SelectedItemIdTextBox.Location = new System.Drawing.Point(105, 67);
            this.SelectedItemIdTextBox.Name = "SelectedItemIdTextBox";
            this.SelectedItemIdTextBox.ReadOnly = true;
            this.SelectedItemIdTextBox.Size = new System.Drawing.Size(230, 26);
            this.SelectedItemIdTextBox.TabIndex = 2;
            // 
            // SelectedItemCostTextBox
            // 
            this.SelectedItemCostTextBox.Location = new System.Drawing.Point(105, 99);
            this.SelectedItemCostTextBox.Name = "SelectedItemCostTextBox";
            this.SelectedItemCostTextBox.Size = new System.Drawing.Size(230, 26);
            this.SelectedItemCostTextBox.TabIndex = 3;
            this.SelectedItemCostTextBox.TextChanged += new System.EventHandler(this.SelectedItemCostTextBox_TextChanged);
            // 
            // SelectedItemNameLabel
            // 
            this.SelectedItemNameLabel.Location = new System.Drawing.Point(0, 174);
            this.SelectedItemNameLabel.Name = "SelectedItemNameLabel";
            this.SelectedItemNameLabel.Size = new System.Drawing.Size(831, 23);
            this.SelectedItemNameLabel.TabIndex = 0;
            this.SelectedItemNameLabel.Text = "Name:";
            // 
            // SelectedItemNameTextBox
            // 
            this.SelectedItemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemNameTextBox.Location = new System.Drawing.Point(0, 200);
            this.SelectedItemNameTextBox.Multiline = true;
            this.SelectedItemNameTextBox.Name = "SelectedItemNameTextBox";
            this.SelectedItemNameTextBox.Size = new System.Drawing.Size(831, 230);
            this.SelectedItemNameTextBox.TabIndex = 1;
            this.SelectedItemNameTextBox.TextChanged += new System.EventHandler(this.SelectedItemNameTextBox_TextChanged);
            // 
            // SelectedItemDescriptionLabel
            // 
            this.SelectedItemDescriptionLabel.Location = new System.Drawing.Point(0, 436);
            this.SelectedItemDescriptionLabel.Name = "SelectedItemDescriptionLabel";
            this.SelectedItemDescriptionLabel.Size = new System.Drawing.Size(831, 27);
            this.SelectedItemDescriptionLabel.TabIndex = 0;
            this.SelectedItemDescriptionLabel.Text = "Description:";
            // 
            // SelectedItemDescriptionTextBox
            // 
            this.SelectedItemDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemDescriptionTextBox.Location = new System.Drawing.Point(0, 466);
            this.SelectedItemDescriptionTextBox.Multiline = true;
            this.SelectedItemDescriptionTextBox.Name = "SelectedItemDescriptionTextBox";
            this.SelectedItemDescriptionTextBox.Size = new System.Drawing.Size(831, 230);
            this.SelectedItemDescriptionTextBox.TabIndex = 1;
            this.SelectedItemDescriptionTextBox.TextChanged += new System.EventHandler(this.SelectedItemDescriptionTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.SelectedItemCategoryComboBox);
            this.panel1.Controls.Add(this.SelectedItemCategoryLabel);
            this.panel1.Controls.Add(this.SelectedItemIdTextBox);
            this.panel1.Controls.Add(this.SelectedItemDescriptionLabel);
            this.panel1.Controls.Add(this.SelectedItemDescriptionTextBox);
            this.panel1.Controls.Add(this.SelectedItemCostTextBox);
            this.panel1.Controls.Add(this.SelectedItemCostLabel);
            this.panel1.Controls.Add(this.SelectedItemNameLabel);
            this.panel1.Controls.Add(this.SelectedItemNameTextBox);
            this.panel1.Controls.Add(this.SelectedItemLabel);
            this.panel1.Controls.Add(this.SelectedItemIdLable);
            this.panel1.Location = new System.Drawing.Point(435, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 1151);
            this.panel1.TabIndex = 0;
            // 
            // SelectedItemCategoryComboBox
            // 
            this.SelectedItemCategoryComboBox.FormattingEnabled = true;
            this.SelectedItemCategoryComboBox.Location = new System.Drawing.Point(105, 131);
            this.SelectedItemCategoryComboBox.Name = "SelectedItemCategoryComboBox";
            this.SelectedItemCategoryComboBox.Size = new System.Drawing.Size(230, 28);
            this.SelectedItemCategoryComboBox.TabIndex = 6;
            this.SelectedItemCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedItemCategoryComboBox_SelectedIndexChanged);
            // 
            // SelectedItemCategoryLabel
            // 
            this.SelectedItemCategoryLabel.Location = new System.Drawing.Point(3, 131);
            this.SelectedItemCategoryLabel.Name = "SelectedItemCategoryLabel";
            this.SelectedItemCategoryLabel.Size = new System.Drawing.Size(96, 28);
            this.SelectedItemCategoryLabel.TabIndex = 5;
            this.SelectedItemCategoryLabel.Text = "Category:";
            this.SelectedItemCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemsFindTextBox
            // 
            this.ItemsFindTextBox.Location = new System.Drawing.Point(99, 67);
            this.ItemsFindTextBox.Name = "ItemsFindTextBox";
            this.ItemsFindTextBox.Size = new System.Drawing.Size(330, 26);
            this.ItemsFindTextBox.TabIndex = 8;
            this.ItemsFindTextBox.TextChanged += new System.EventHandler(this.ItemsFindTextBox_TextChanged);
            // 
            // ItemsFindlabel
            // 
            this.ItemsFindlabel.Location = new System.Drawing.Point(-3, 67);
            this.ItemsFindlabel.Name = "ItemsFindlabel";
            this.ItemsFindlabel.Size = new System.Drawing.Size(96, 26);
            this.ItemsFindlabel.TabIndex = 7;
            this.ItemsFindlabel.Text = "Find:";
            this.ItemsFindlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemsOrderByLabel
            // 
            this.ItemsOrderByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsOrderByLabel.Location = new System.Drawing.Point(3, 1013);
            this.ItemsOrderByLabel.Name = "ItemsOrderByLabel";
            this.ItemsOrderByLabel.Size = new System.Drawing.Size(96, 26);
            this.ItemsOrderByLabel.TabIndex = 9;
            this.ItemsOrderByLabel.Text = "Order by:";
            this.ItemsOrderByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemsOrderByComboBox
            // 
            this.ItemsOrderByComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsOrderByComboBox.FormattingEnabled = true;
            this.ItemsOrderByComboBox.Location = new System.Drawing.Point(99, 1013);
            this.ItemsOrderByComboBox.Name = "ItemsOrderByComboBox";
            this.ItemsOrderByComboBox.Size = new System.Drawing.Size(330, 28);
            this.ItemsOrderByComboBox.TabIndex = 10;
            this.ItemsOrderByComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemsOrderByComboBox_SelectedIndexChanged);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsOrderByComboBox);
            this.Controls.Add(this.ItemsOrderByLabel);
            this.Controls.Add(this.ItemsFindTextBox);
            this.Controls.Add(this.ItemsFindlabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(1275, 1151);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox ItemsOrderByComboBox;

        private System.Windows.Forms.Label ItemsOrderByLabel;

        private System.Windows.Forms.TextBox ItemsFindTextBox;

        private System.Windows.Forms.Label ItemsFindlabel;

        private System.Windows.Forms.Label SelectedItemCategoryLabel;

        private System.Windows.Forms.ComboBox SelectedItemCategoryComboBox;

        private System.Windows.Forms.Button ItemsRandomButton;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label SelectedItemDescriptionLabel;

        private System.Windows.Forms.TextBox SelectedItemDescriptionTextBox;

        private System.Windows.Forms.TextBox SelectedItemNameTextBox;

        private System.Windows.Forms.Label SelectedItemNameLabel;

        private System.Windows.Forms.TextBox SelectedItemCostTextBox;

        private System.Windows.Forms.TextBox SelectedItemIdTextBox;

        private System.Windows.Forms.Label SelectedItemCostLabel;

        private System.Windows.Forms.Label SelectedItemIdLable;

        private System.Windows.Forms.Label SelectedItemLabel;

        private System.Windows.Forms.Label ItemsLabel;

        private System.Windows.Forms.ListBox ItemsListBox;

        private System.Windows.Forms.Button ItemsAddButton;

        private System.Windows.Forms.Button ItemsRemoveButton;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}