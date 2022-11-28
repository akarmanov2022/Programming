using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrderTab
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
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.AmountValueLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.PriorityOptionLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 20;
            this.OrderItemsListBox.Location = new System.Drawing.Point(0, 386);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(1052, 324);
            this.OrderItemsListBox.TabIndex = 40;
            // 
            // AmountValueLabel
            // 
            this.AmountValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountValueLabel.Location = new System.Drawing.Point(0, 758);
            this.AmountValueLabel.Name = "AmountValueLabel";
            this.AmountValueLabel.Size = new System.Drawing.Size(1052, 84);
            this.AmountValueLabel.TabIndex = 39;
            this.AmountValueLabel.Text = "0";
            this.AmountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(0, 713);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(1052, 45);
            this.AmountLabel.TabIndex = 38;
            this.AmountLabel.Text = "Amount:";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(0, 346);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(1052, 37);
            this.OrderItemsLabel.TabIndex = 37;
            this.OrderItemsLabel.Text = "Order Items";
            this.OrderItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.DeliveryAddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryAddressControl.Location = new System.Drawing.Point(0, 151);
            this.DeliveryAddressControl.Name = "DeliveryAddressControl";
            this.DeliveryAddressControl.Size = new System.Drawing.Size(1052, 192);
            this.DeliveryAddressControl.TabIndex = 36;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(96, 116);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(185, 28);
            this.StatusComboBox.TabIndex = 35;
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Enabled = false;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(96, 77);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(185, 26);
            this.CreatedDateTimePicker.TabIndex = 34;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(96, 42);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(185, 26);
            this.IdTextBox.TabIndex = 33;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(0, 111);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(90, 37);
            this.StatusLabel.TabIndex = 32;
            this.StatusLabel.Text = "Status:";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel.Location = new System.Drawing.Point(0, 74);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(90, 37);
            this.CreatedLabel.TabIndex = 31;
            this.CreatedLabel.Text = "Created:";
            this.CreatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IDLabel
            // 
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(0, 37);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(90, 37);
            this.IDLabel.TabIndex = 30;
            this.IDLabel.Text = "ID:";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOrderLabel.Location = new System.Drawing.Point(0, 0);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(485, 37);
            this.SelectedOrderLabel.TabIndex = 29;
            this.SelectedOrderLabel.Text = "Selected Order";
            this.SelectedOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriorityOptionLabel
            // 
            this.PriorityOptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.PriorityOptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityOptionLabel.Location = new System.Drawing.Point(491, 0);
            this.PriorityOptionLabel.Name = "PriorityOptionLabel";
            this.PriorityOptionLabel.Size = new System.Drawing.Size(561, 37);
            this.PriorityOptionLabel.TabIndex = 41;
            this.PriorityOptionLabel.Text = "Priority Option";
            this.PriorityOptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(633, 42);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(185, 28);
            this.DeliveryTimeComboBox.TabIndex = 43;
            this.DeliveryTimeComboBox.TextChanged += new System.EventHandler(this.DeliveryTimeComboBox_TextChanged);
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(491, 37);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(136, 37);
            this.DeliveryTimeLabel.TabIndex = 42;
            this.DeliveryTimeLabel.Text = "Delivery Time:";
            this.DeliveryTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddItemButton.Location = new System.Drawing.Point(3, 845);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(192, 98);
            this.AddItemButton.TabIndex = 44;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveItemButton.Location = new System.Drawing.Point(201, 845);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(192, 98);
            this.RemoveItemButton.TabIndex = 45;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearOrderButton.Location = new System.Drawing.Point(857, 848);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(192, 98);
            this.ClearOrderButton.TabIndex = 46;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            this.ClearOrderButton.Click += new System.EventHandler(this.ClearOrderButton_Click);
            // 
            // PriorityOrderTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClearOrderButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.DeliveryTimeComboBox);
            this.Controls.Add(this.DeliveryTimeLabel);
            this.Controls.Add(this.PriorityOptionLabel);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.AmountValueLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.OrderItemsLabel);
            this.Controls.Add(this.DeliveryAddressControl);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.CreatedDateTimePicker);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SelectedOrderLabel);
            this.Name = "PriorityOrderTab";
            this.Size = new System.Drawing.Size(1052, 946);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button AddItemButton;

        private System.Windows.Forms.Button RemoveItemButton;

        private System.Windows.Forms.Button ClearOrderButton;

        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;

        private System.Windows.Forms.Label DeliveryTimeLabel;

        private System.Windows.Forms.Label PriorityOptionLabel;

        private System.Windows.Forms.ListBox OrderItemsListBox;

        private System.Windows.Forms.Label AmountValueLabel;

        private System.Windows.Forms.Label AmountLabel;

        private System.Windows.Forms.Label OrderItemsLabel;

        private ObjectOrientedPractics.View.Controls.AddressControl DeliveryAddressControl;

        private System.Windows.Forms.ComboBox StatusComboBox;

        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;

        private System.Windows.Forms.TextBox IdTextBox;

        private System.Windows.Forms.Label StatusLabel;

        private System.Windows.Forms.Label CreatedLabel;

        private System.Windows.Forms.Label IDLabel;

        private System.Windows.Forms.Label SelectedOrderLabel;

        #endregion
    }
}