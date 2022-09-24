using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CustomersAddButton = new System.Windows.Forms.Button();
            this.CustomersRemoveButton = new System.Windows.Forms.Button();
            this.CustomersRandomButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SelectedCustomerAddressTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerFullnameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectedCustomerIdLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.CustomersListBox);
            this.panel1.Controls.Add(this.CustomersLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(476, 882);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.CustomersAddButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomersRemoveButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomersRandomButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 812);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 64);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CustomersAddButton
            // 
            this.CustomersAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersAddButton.Location = new System.Drawing.Point(3, 3);
            this.CustomersAddButton.Name = "CustomersAddButton";
            this.CustomersAddButton.Size = new System.Drawing.Size(148, 58);
            this.CustomersAddButton.TabIndex = 0;
            this.CustomersAddButton.Text = "Add";
            this.CustomersAddButton.UseVisualStyleBackColor = true;
            this.CustomersAddButton.Click += new System.EventHandler(this.CustomersAddButton_Click);
            // 
            // CustomersRemoveButton
            // 
            this.CustomersRemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersRemoveButton.Location = new System.Drawing.Point(157, 3);
            this.CustomersRemoveButton.Name = "CustomersRemoveButton";
            this.CustomersRemoveButton.Size = new System.Drawing.Size(148, 58);
            this.CustomersRemoveButton.TabIndex = 1;
            this.CustomersRemoveButton.Text = "Remove";
            this.CustomersRemoveButton.UseVisualStyleBackColor = true;
            this.CustomersRemoveButton.Click += new System.EventHandler(this.CustomersRemoveButton_Click);
            // 
            // CustomersRandomButton
            // 
            this.CustomersRandomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersRandomButton.Location = new System.Drawing.Point(311, 3);
            this.CustomersRandomButton.Name = "CustomersRandomButton";
            this.CustomersRandomButton.Size = new System.Drawing.Size(150, 58);
            this.CustomersRandomButton.TabIndex = 2;
            this.CustomersRandomButton.Text = "Random";
            this.CustomersRandomButton.UseVisualStyleBackColor = true;
            this.CustomersRandomButton.Click += new System.EventHandler(this.CustomersRandomButton_Click_1);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 20;
            this.CustomersListBox.Location = new System.Drawing.Point(6, 49);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(464, 827);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(6, 6);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(464, 43);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            this.CustomersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.SelectedCustomerAddressTextBox);
            this.panel2.Controls.Add(this.SelectedCustomerFullnameTextBox);
            this.panel2.Controls.Add(this.SelectedCustomerIdTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.SelectedCustomerIdLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(482, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(603, 453);
            this.panel2.TabIndex = 1;
            // 
            // SelectedCustomerAddressTextBox
            // 
            this.SelectedCustomerAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerAddressTextBox.Location = new System.Drawing.Point(160, 168);
            this.SelectedCustomerAddressTextBox.Multiline = true;
            this.SelectedCustomerAddressTextBox.Name = "SelectedCustomerAddressTextBox";
            this.SelectedCustomerAddressTextBox.Size = new System.Drawing.Size(434, 276);
            this.SelectedCustomerAddressTextBox.TabIndex = 6;
            this.SelectedCustomerAddressTextBox.TextChanged += new System.EventHandler(this.SelectedCustomerAddressTextBox_TextChanged);
            // 
            // SelectedCustomerFullnameTextBox
            // 
            this.SelectedCustomerFullnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerFullnameTextBox.Location = new System.Drawing.Point(160, 115);
            this.SelectedCustomerFullnameTextBox.Name = "SelectedCustomerFullnameTextBox";
            this.SelectedCustomerFullnameTextBox.Size = new System.Drawing.Size(434, 26);
            this.SelectedCustomerFullnameTextBox.TabIndex = 5;
            this.SelectedCustomerFullnameTextBox.TextChanged += new System.EventHandler(this.SelectedCustomerFullnameTextBox_TextChanged);
            // 
            // SelectedCustomerIdTextBox
            // 
            this.SelectedCustomerIdTextBox.Location = new System.Drawing.Point(157, 59);
            this.SelectedCustomerIdTextBox.Name = "SelectedCustomerIdTextBox";
            this.SelectedCustomerIdTextBox.ReadOnly = true;
            this.SelectedCustomerIdTextBox.Size = new System.Drawing.Size(132, 26);
            this.SelectedCustomerIdTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 53);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 53);
            this.label4.TabIndex = 2;
            this.label4.Text = "Full Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedCustomerIdLabel
            // 
            this.SelectedCustomerIdLabel.Location = new System.Drawing.Point(6, 46);
            this.SelectedCustomerIdLabel.Name = "SelectedCustomerIdLabel";
            this.SelectedCustomerIdLabel.Size = new System.Drawing.Size(145, 53);
            this.SelectedCustomerIdLabel.TabIndex = 1;
            this.SelectedCustomerIdLabel.Text = "ID:";
            this.SelectedCustomerIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(591, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Customer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomersTab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(1085, 882);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button CustomersRandomButton;

        private System.Windows.Forms.TextBox SelectedCustomerAddressTextBox;

        private System.Windows.Forms.TextBox SelectedCustomerFullnameTextBox;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox SelectedCustomerIdTextBox;

        private System.Windows.Forms.Label SelectedCustomerIdLabel;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Button CustomersRemoveButton;

        private System.Windows.Forms.Button CustomersAddButton;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.ListBox CustomersListBox;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label CustomersLabel;

        #endregion
    }
}