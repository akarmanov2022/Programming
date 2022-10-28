using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersComboBox = new System.Windows.Forms.ComboBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountValueLabel = new System.Windows.Forms.Label();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(0, 0);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(460, 37);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            this.ItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 40);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(457, 684);
            this.ItemsListBox.TabIndex = 1;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddToCartButton.Location = new System.Drawing.Point(3, 730);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(177, 73);
            this.AddToCartButton.TabIndex = 2;
            this.AddToCartButton.Text = "Add to Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(466, 40);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(105, 37);
            this.CustomersLabel.TabIndex = 3;
            this.CustomersLabel.Text = "Customers:";
            this.CustomersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomersComboBox
            // 
            this.CustomersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersComboBox.FormattingEnabled = true;
            this.CustomersComboBox.Location = new System.Drawing.Point(577, 45);
            this.CustomersComboBox.Name = "CustomersComboBox";
            this.CustomersComboBox.Size = new System.Drawing.Size(482, 28);
            this.CustomersComboBox.TabIndex = 4;
            this.CustomersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBox_SelectedIndexChanged);
            // 
            // CartLabel
            // 
            this.CartLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.CartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartLabel.Location = new System.Drawing.Point(466, 77);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(593, 37);
            this.CartLabel.TabIndex = 5;
            this.CartLabel.Text = "Cart:";
            this.CartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(466, 452);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(593, 37);
            this.AmountLabel.TabIndex = 7;
            this.AmountLabel.Text = "Amount:";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AmountValueLabel
            // 
            this.AmountValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountValueLabel.Location = new System.Drawing.Point(466, 489);
            this.AmountValueLabel.Name = "AmountValueLabel";
            this.AmountValueLabel.Size = new System.Drawing.Size(593, 69);
            this.AmountValueLabel.TabIndex = 8;
            this.AmountValueLabel.Text = "0";
            this.AmountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateOrderButton.Location = new System.Drawing.Point(516, 561);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(177, 73);
            this.CreateOrderButton.TabIndex = 9;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCartButton.Location = new System.Drawing.Point(882, 561);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(177, 73);
            this.ClearCartButton.TabIndex = 10;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveItemButton.Location = new System.Drawing.Point(699, 561);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(177, 73);
            this.RemoveItemButton.TabIndex = 11;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // CartListBox
            // 
            this.CartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.ItemHeight = 20;
            this.CartListBox.Location = new System.Drawing.Point(466, 117);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(593, 324);
            this.CartListBox.TabIndex = 12;
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.AmountValueLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.CustomersComboBox);
            this.Controls.Add(this.CustomersLabel);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ItemsLabel);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(1074, 814);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox CartListBox;

        private System.Windows.Forms.Button RemoveItemButton;

        private System.Windows.Forms.Button ClearCartButton;

        private System.Windows.Forms.Button CreateOrderButton;

        private System.Windows.Forms.Label AmountValueLabel;

        private System.Windows.Forms.Label AmountLabel;

        private System.Windows.Forms.Label CartLabel;

        private System.Windows.Forms.Label CustomersLabel;

        private System.Windows.Forms.ComboBox CustomersComboBox;

        private System.Windows.Forms.Button AddToCartButton;

        private System.Windows.Forms.ListBox ItemsListBox;

        private System.Windows.Forms.Label ItemsLabel;

        #endregion
    }
}