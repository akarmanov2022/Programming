using System.ComponentModel;
using ObjectOrientedPractics.View.Controls;

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
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CustomersAddButton = new System.Windows.Forms.Button();
            this.CustomersRemoveButton = new System.Windows.Forms.Button();
            this.CustomersRandomButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.SelectedCustomerIdLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectedCustomerFullnameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DiscountsRemoveButton = new System.Windows.Forms.Button();
            this.DiscountsAddButton = new System.Windows.Forms.Button();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(363, 882);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 64);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CustomersAddButton
            // 
            this.CustomersAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersAddButton.Location = new System.Drawing.Point(3, 3);
            this.CustomersAddButton.Name = "CustomersAddButton";
            this.CustomersAddButton.Size = new System.Drawing.Size(111, 58);
            this.CustomersAddButton.TabIndex = 0;
            this.CustomersAddButton.Text = "Add";
            this.CustomersAddButton.UseVisualStyleBackColor = true;
            this.CustomersAddButton.Click += new System.EventHandler(this.CustomersAddButton_Click);
            // 
            // CustomersRemoveButton
            // 
            this.CustomersRemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersRemoveButton.Location = new System.Drawing.Point(120, 3);
            this.CustomersRemoveButton.Name = "CustomersRemoveButton";
            this.CustomersRemoveButton.Size = new System.Drawing.Size(111, 58);
            this.CustomersRemoveButton.TabIndex = 1;
            this.CustomersRemoveButton.Text = "Remove";
            this.CustomersRemoveButton.UseVisualStyleBackColor = true;
            this.CustomersRemoveButton.Click += new System.EventHandler(this.CustomersRemoveButton_Click);
            // 
            // CustomersRandomButton
            // 
            this.CustomersRandomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersRandomButton.Location = new System.Drawing.Point(237, 3);
            this.CustomersRandomButton.Name = "CustomersRandomButton";
            this.CustomersRandomButton.Size = new System.Drawing.Size(111, 58);
            this.CustomersRandomButton.TabIndex = 2;
            this.CustomersRandomButton.Text = "Random";
            this.CustomersRandomButton.UseVisualStyleBackColor = true;
            this.CustomersRandomButton.Click += new System.EventHandler(this.CustomersRandomButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 20;
            this.CustomersListBox.Location = new System.Drawing.Point(6, 49);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(351, 827);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(6, 6);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(351, 43);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            this.CustomersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(363, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(722, 882);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.DeliveryAddressControl);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(710, 870);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.IsPriorityCheckBox);
            this.panel3.Controls.Add(this.SelectedCustomerIdLabel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.SelectedCustomerFullnameTextBox);
            this.panel3.Controls.Add(this.SelectedCustomerIdTextBox);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 180);
            this.panel3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(704, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Customer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(101, 120);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(104, 24);
            this.IsPriorityCheckBox.TabIndex = 8;
            this.IsPriorityCheckBox.Text = "Is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            this.IsPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // SelectedCustomerIdLabel
            // 
            this.SelectedCustomerIdLabel.Location = new System.Drawing.Point(3, 40);
            this.SelectedCustomerIdLabel.Name = "SelectedCustomerIdLabel";
            this.SelectedCustomerIdLabel.Size = new System.Drawing.Size(92, 40);
            this.SelectedCustomerIdLabel.TabIndex = 1;
            this.SelectedCustomerIdLabel.Text = "ID:";
            this.SelectedCustomerIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "Full Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedCustomerFullnameTextBox
            // 
            this.SelectedCustomerFullnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerFullnameTextBox.Location = new System.Drawing.Point(101, 88);
            this.SelectedCustomerFullnameTextBox.Name = "SelectedCustomerFullnameTextBox";
            this.SelectedCustomerFullnameTextBox.Size = new System.Drawing.Size(600, 26);
            this.SelectedCustomerFullnameTextBox.TabIndex = 5;
            this.SelectedCustomerFullnameTextBox.TextChanged += new System.EventHandler(this.SelectedCustomerFullnameTextBox_TextChanged);
            // 
            // SelectedCustomerIdTextBox
            // 
            this.SelectedCustomerIdTextBox.Location = new System.Drawing.Point(101, 47);
            this.SelectedCustomerIdTextBox.Name = "SelectedCustomerIdTextBox";
            this.SelectedCustomerIdTextBox.ReadOnly = true;
            this.SelectedCustomerIdTextBox.Size = new System.Drawing.Size(182, 26);
            this.SelectedCustomerIdTextBox.TabIndex = 4;
            // 
            // DeliveryAddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 0;
            address1.Street = "";
            this.DeliveryAddressControl.Address = address1;
            this.DeliveryAddressControl.Location = new System.Drawing.Point(3, 189);
            this.DeliveryAddressControl.Name = "DeliveryAddressControl";
            this.DeliveryAddressControl.Size = new System.Drawing.Size(704, 191);
            this.DeliveryAddressControl.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DiscountsRemoveButton);
            this.panel4.Controls.Add(this.DiscountsAddButton);
            this.panel4.Controls.Add(this.DiscountsListBox);
            this.panel4.Controls.Add(this.DiscountsLabel);
            this.panel4.Location = new System.Drawing.Point(3, 386);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(707, 216);
            this.panel4.TabIndex = 10;
            // 
            // DiscountsRemoveButton
            // 
            this.DiscountsRemoveButton.Enabled = false;
            this.DiscountsRemoveButton.Location = new System.Drawing.Point(502, 110);
            this.DiscountsRemoveButton.Name = "DiscountsRemoveButton";
            this.DiscountsRemoveButton.Size = new System.Drawing.Size(111, 58);
            this.DiscountsRemoveButton.TabIndex = 12;
            this.DiscountsRemoveButton.Text = "Remove";
            this.DiscountsRemoveButton.UseVisualStyleBackColor = true;
            // 
            // DiscountsAddButton
            // 
            this.DiscountsAddButton.Enabled = false;
            this.DiscountsAddButton.Location = new System.Drawing.Point(502, 46);
            this.DiscountsAddButton.Name = "DiscountsAddButton";
            this.DiscountsAddButton.Size = new System.Drawing.Size(111, 58);
            this.DiscountsAddButton.TabIndex = 11;
            this.DiscountsAddButton.Text = "Add";
            this.DiscountsAddButton.UseVisualStyleBackColor = true;
            this.DiscountsAddButton.Click += new System.EventHandler(this.DiscountsAddButton_Click);
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.ItemHeight = 20;
            this.DiscountsListBox.Location = new System.Drawing.Point(3, 46);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.DiscountsListBox.Size = new System.Drawing.Size(493, 164);
            this.DiscountsListBox.TabIndex = 10;
            this.DiscountsListBox.SelectedIndexChanged += new System.EventHandler(this.DiscountsListBox_SelectedIndexChanged);
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountsLabel.Location = new System.Drawing.Point(0, 0);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(704, 43);
            this.DiscountsLabel.TabIndex = 9;
            this.DiscountsLabel.Text = "Discounts";
            this.DiscountsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button DiscountsRemoveButton;

        private System.Windows.Forms.Button DiscountsAddButton;

        private System.Windows.Forms.ListBox DiscountsListBox;

        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Label DiscountsLabel;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.CheckBox IsPriorityCheckBox;

        private ObjectOrientedPractics.View.Controls.AddressControl DeliveryAddressControl;

        private System.Windows.Forms.Button CustomersRandomButton;

        private System.Windows.Forms.TextBox SelectedCustomerFullnameTextBox;

        private System.Windows.Forms.Label label4;

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