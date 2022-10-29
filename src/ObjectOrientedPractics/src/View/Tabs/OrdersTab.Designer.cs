using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.DeliveryAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.AmountValueLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersLabel.Location = new System.Drawing.Point(0, 0);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(628, 37);
            this.OrdersLabel.TabIndex = 0;
            this.OrdersLabel.Text = "Orders";
            this.OrdersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOrderLabel.Location = new System.Drawing.Point(634, 0);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(691, 37);
            this.SelectedOrderLabel.TabIndex = 1;
            this.SelectedOrderLabel.Text = "Selected Order";
            this.SelectedOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.AllowUserToResizeColumns = false;
            this.OrdersDataGridView.AllowUserToResizeRows = false;
            this.OrdersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.OrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.IdColumn, this.CreatedColumn, this.OrderStatusColumn, this.CustomerFullNameColumn, this.DeliveryAddressColumn, this.AmountColumn });
            this.OrdersDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrdersDataGridView.Location = new System.Drawing.Point(0, 37);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.OrdersDataGridView.RowTemplate.Height = 28;
            this.OrdersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDataGridView.Size = new System.Drawing.Size(628, 796);
            this.OrdersDataGridView.TabIndex = 2;
            this.OrdersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGridView_CellClick);
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdColumn.Width = 29;
            // 
            // CreatedColumn
            // 
            this.CreatedColumn.HeaderText = "Created";
            this.CreatedColumn.Name = "CreatedColumn";
            this.CreatedColumn.ReadOnly = true;
            this.CreatedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CreatedColumn.Width = 72;
            // 
            // OrderStatusColumn
            // 
            this.OrderStatusColumn.HeaderText = "OrderStatus";
            this.OrderStatusColumn.Name = "OrderStatusColumn";
            this.OrderStatusColumn.ReadOnly = true;
            this.OrderStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrderStatusColumn.Width = 102;
            // 
            // CustomerFullNameColumn
            // 
            this.CustomerFullNameColumn.HeaderText = "Customer Full Name";
            this.CustomerFullNameColumn.Name = "CustomerFullNameColumn";
            this.CustomerFullNameColumn.ReadOnly = true;
            this.CustomerFullNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CustomerFullNameColumn.Width = 105;
            // 
            // DeliveryAddressColumn
            // 
            this.DeliveryAddressColumn.HeaderText = "Delivery Address";
            this.DeliveryAddressColumn.Name = "DeliveryAddressColumn";
            this.DeliveryAddressColumn.ReadOnly = true;
            this.DeliveryAddressColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DeliveryAddressColumn.Width = 120;
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Amount ";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AmountColumn.Width = 75;
            // 
            // IDLabel
            // 
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(634, 37);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(90, 37);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID:";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel.Location = new System.Drawing.Point(634, 74);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(90, 37);
            this.CreatedLabel.TabIndex = 4;
            this.CreatedLabel.Text = "Created:";
            this.CreatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(634, 111);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(90, 37);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Status:";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(730, 42);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(251, 26);
            this.IdTextBox.TabIndex = 6;
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Enabled = false;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(730, 77);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(251, 26);
            this.CreatedDateTimePicker.TabIndex = 7;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(730, 116);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(251, 28);
            this.StatusComboBox.TabIndex = 8;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
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
            this.DeliveryAddressControl.Location = new System.Drawing.Point(634, 150);
            this.DeliveryAddressControl.Name = "DeliveryAddressControl";
            this.DeliveryAddressControl.Size = new System.Drawing.Size(691, 192);
            this.DeliveryAddressControl.TabIndex = 9;
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 20;
            this.OrderItemsListBox.Location = new System.Drawing.Point(634, 377);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(691, 324);
            this.OrderItemsListBox.TabIndex = 16;
            // 
            // AmountValueLabel
            // 
            this.AmountValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountValueLabel.Location = new System.Drawing.Point(634, 749);
            this.AmountValueLabel.Name = "AmountValueLabel";
            this.AmountValueLabel.Size = new System.Drawing.Size(691, 84);
            this.AmountValueLabel.TabIndex = 15;
            this.AmountValueLabel.Text = "0";
            this.AmountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(634, 704);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(691, 45);
            this.AmountLabel.TabIndex = 14;
            this.AmountLabel.Text = "Amount:";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(634, 337);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(691, 37);
            this.OrderItemsLabel.TabIndex = 13;
            this.OrderItemsLabel.Text = "Order Items";
            this.OrderItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
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
            this.Controls.Add(this.OrdersDataGridView);
            this.Controls.Add(this.SelectedOrderLabel);
            this.Controls.Add(this.OrdersLabel);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(1325, 833);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox OrderItemsListBox;

        private System.Windows.Forms.Label AmountValueLabel;

        private System.Windows.Forms.Label AmountLabel;

        private System.Windows.Forms.Label OrderItemsLabel;

        private ObjectOrientedPractics.View.Controls.AddressControl DeliveryAddressControl;

        private System.Windows.Forms.TextBox IdTextBox;

        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;

        private System.Windows.Forms.ComboBox StatusComboBox;

        private System.Windows.Forms.Label StatusLabel;

        private System.Windows.Forms.Label CreatedLabel;

        private System.Windows.Forms.Label IDLabel;

        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryAddressColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFullNameColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatusColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;

        private System.Windows.Forms.DataGridView OrdersDataGridView;

        private System.Windows.Forms.Label SelectedOrderLabel;

        private System.Windows.Forms.Label OrdersLabel;

        #endregion
    }
}