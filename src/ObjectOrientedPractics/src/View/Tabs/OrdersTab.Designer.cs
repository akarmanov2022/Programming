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
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastModifyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderControl = new ObjectOrientedPractics.View.Controls.OrderControl();
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
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.AllowUserToResizeColumns = false;
            this.OrdersDataGridView.AllowUserToResizeRows = false;
            this.OrdersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.OrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.IdColumn, this.CreatedColumn, this.LastModifyColumn, this.OrderStatusColumn, this.CustomerFullNameColumn, this.DeliveryAddressColumn, this.AmountColumn });
            this.OrdersDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrdersDataGridView.Location = new System.Drawing.Point(0, 53);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.OrdersDataGridView.RowTemplate.Height = 28;
            this.OrdersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDataGridView.Size = new System.Drawing.Size(628, 777);
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
            // LastModifyColumn
            // 
            this.LastModifyColumn.HeaderText = "Last Modify";
            this.LastModifyColumn.Name = "LastModifyColumn";
            this.LastModifyColumn.ReadOnly = true;
            this.LastModifyColumn.Width = 105;
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
            // orderControl1
            // 
            this.OrderControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderControl.Location = new System.Drawing.Point(634, 0);
            this.OrderControl.Name = "orderControl1";
            this.OrderControl.Size = new System.Drawing.Size(766, 833);
            this.OrderControl.TabIndex = 3;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.OrderControl);
            this.Controls.Add(this.OrdersDataGridView);
            this.Controls.Add(this.OrdersLabel);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(1400, 833);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);
        }
        
        private ObjectOrientedPractics.View.Controls.OrderControl OrderControl;

        private System.Windows.Forms.DataGridViewTextBoxColumn LastModifyColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryAddressColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFullNameColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatusColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;

        private System.Windows.Forms.DataGridView OrdersDataGridView;

        private System.Windows.Forms.Label OrdersLabel;

        #endregion
    }
}