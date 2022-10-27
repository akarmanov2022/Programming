using System.ComponentModel;

namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.DeliveryAddressLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressPostIndexLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressCountryLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressStreetLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressBuildingLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressPostIndexTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryAddressCountryTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryAddressStreetTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryAddressBuildingTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryAddressApartmentLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressApartmentTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryAddressCityLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressCityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            this.DeliveryAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryAddressLabel.Location = new System.Drawing.Point(0, 0);
            this.DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            this.DeliveryAddressLabel.Size = new System.Drawing.Size(315, 37);
            this.DeliveryAddressLabel.TabIndex = 0;
            this.DeliveryAddressLabel.Text = "Delivery Address";
            this.DeliveryAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeliveryAddressPostIndexLabel
            // 
            this.DeliveryAddressPostIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryAddressPostIndexLabel.Location = new System.Drawing.Point(0, 37);
            this.DeliveryAddressPostIndexLabel.Name = "DeliveryAddressPostIndexLabel";
            this.DeliveryAddressPostIndexLabel.Size = new System.Drawing.Size(94, 37);
            this.DeliveryAddressPostIndexLabel.TabIndex = 1;
            this.DeliveryAddressPostIndexLabel.Text = "Post index:";
            this.DeliveryAddressPostIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeliveryAddressCountryLabel
            // 
            this.DeliveryAddressCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryAddressCountryLabel.Location = new System.Drawing.Point(0, 74);
            this.DeliveryAddressCountryLabel.Name = "DeliveryAddressCountryLabel";
            this.DeliveryAddressCountryLabel.Size = new System.Drawing.Size(94, 37);
            this.DeliveryAddressCountryLabel.TabIndex = 2;
            this.DeliveryAddressCountryLabel.Text = "Country:";
            this.DeliveryAddressCountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeliveryAddressStreetLabel
            // 
            this.DeliveryAddressStreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryAddressStreetLabel.Location = new System.Drawing.Point(0, 111);
            this.DeliveryAddressStreetLabel.Name = "DeliveryAddressStreetLabel";
            this.DeliveryAddressStreetLabel.Size = new System.Drawing.Size(94, 37);
            this.DeliveryAddressStreetLabel.TabIndex = 3;
            this.DeliveryAddressStreetLabel.Text = "Street:";
            this.DeliveryAddressStreetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeliveryAddressBuildingLabel
            // 
            this.DeliveryAddressBuildingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryAddressBuildingLabel.Location = new System.Drawing.Point(0, 148);
            this.DeliveryAddressBuildingLabel.Name = "DeliveryAddressBuildingLabel";
            this.DeliveryAddressBuildingLabel.Size = new System.Drawing.Size(94, 37);
            this.DeliveryAddressBuildingLabel.TabIndex = 4;
            this.DeliveryAddressBuildingLabel.Text = "Building:";
            this.DeliveryAddressBuildingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeliveryAddressPostIndexTextBox
            // 
            this.DeliveryAddressPostIndexTextBox.Location = new System.Drawing.Point(100, 42);
            this.DeliveryAddressPostIndexTextBox.Name = "DeliveryAddressPostIndexTextBox";
            this.DeliveryAddressPostIndexTextBox.Size = new System.Drawing.Size(215, 26);
            this.DeliveryAddressPostIndexTextBox.TabIndex = 5;
            this.DeliveryAddressPostIndexTextBox.TextChanged += new System.EventHandler(this.DeliveryAddressPostIndexTextBox_TextChanged);
            // 
            // DeliveryAddressCountryTextBox
            // 
            this.DeliveryAddressCountryTextBox.Location = new System.Drawing.Point(100, 79);
            this.DeliveryAddressCountryTextBox.Name = "DeliveryAddressCountryTextBox";
            this.DeliveryAddressCountryTextBox.Size = new System.Drawing.Size(315, 26);
            this.DeliveryAddressCountryTextBox.TabIndex = 6;
            this.DeliveryAddressCountryTextBox.TextChanged += new System.EventHandler(this.DeliveryAddressCountryTextBox_TextChanged);
            // 
            // DeliveryAddressStreetTextBox
            // 
            this.DeliveryAddressStreetTextBox.Location = new System.Drawing.Point(100, 116);
            this.DeliveryAddressStreetTextBox.Name = "DeliveryAddressStreetTextBox";
            this.DeliveryAddressStreetTextBox.Size = new System.Drawing.Size(569, 26);
            this.DeliveryAddressStreetTextBox.TabIndex = 7;
            this.DeliveryAddressStreetTextBox.TextChanged += new System.EventHandler(this.DeliveryAddressStreetTextBox_TextChanged);
            // 
            // DeliveryAddressBuildingTextBox
            // 
            this.DeliveryAddressBuildingTextBox.Location = new System.Drawing.Point(100, 153);
            this.DeliveryAddressBuildingTextBox.Name = "DeliveryAddressBuildingTextBox";
            this.DeliveryAddressBuildingTextBox.Size = new System.Drawing.Size(215, 26);
            this.DeliveryAddressBuildingTextBox.TabIndex = 8;
            this.DeliveryAddressBuildingTextBox.TextChanged += new System.EventHandler(this.DeliveryAddressBuildingTextBox_TextChanged);
            // 
            // DeliveryAddressApartmentLabel
            // 
            this.DeliveryAddressApartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryAddressApartmentLabel.Location = new System.Drawing.Point(321, 148);
            this.DeliveryAddressApartmentLabel.Name = "DeliveryAddressApartmentLabel";
            this.DeliveryAddressApartmentLabel.Size = new System.Drawing.Size(94, 37);
            this.DeliveryAddressApartmentLabel.TabIndex = 9;
            this.DeliveryAddressApartmentLabel.Text = "Apartment:";
            this.DeliveryAddressApartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeliveryAddressApartmentTextBox
            // 
            this.DeliveryAddressApartmentTextBox.Location = new System.Drawing.Point(421, 153);
            this.DeliveryAddressApartmentTextBox.Name = "DeliveryAddressApartmentTextBox";
            this.DeliveryAddressApartmentTextBox.Size = new System.Drawing.Size(248, 26);
            this.DeliveryAddressApartmentTextBox.TabIndex = 10;
            this.DeliveryAddressApartmentTextBox.TextChanged += new System.EventHandler(this.DeliveryAddressApartmentTextBox_TextChanged);
            // 
            // DeliveryAddressCityLabel
            // 
            this.DeliveryAddressCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryAddressCityLabel.Location = new System.Drawing.Point(421, 76);
            this.DeliveryAddressCityLabel.Name = "DeliveryAddressCityLabel";
            this.DeliveryAddressCityLabel.Size = new System.Drawing.Size(48, 37);
            this.DeliveryAddressCityLabel.TabIndex = 11;
            this.DeliveryAddressCityLabel.Text = "City:";
            this.DeliveryAddressCityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeliveryAddressCityTextBox
            // 
            this.DeliveryAddressCityTextBox.Location = new System.Drawing.Point(475, 79);
            this.DeliveryAddressCityTextBox.Name = "DeliveryAddressCityTextBox";
            this.DeliveryAddressCityTextBox.Size = new System.Drawing.Size(194, 26);
            this.DeliveryAddressCityTextBox.TabIndex = 12;
            this.DeliveryAddressCityTextBox.TextChanged += new System.EventHandler(this.DeliveryAddressCityTextBox_TextChanged);
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeliveryAddressCityTextBox);
            this.Controls.Add(this.DeliveryAddressCityLabel);
            this.Controls.Add(this.DeliveryAddressApartmentTextBox);
            this.Controls.Add(this.DeliveryAddressApartmentLabel);
            this.Controls.Add(this.DeliveryAddressBuildingTextBox);
            this.Controls.Add(this.DeliveryAddressStreetTextBox);
            this.Controls.Add(this.DeliveryAddressCountryTextBox);
            this.Controls.Add(this.DeliveryAddressPostIndexTextBox);
            this.Controls.Add(this.DeliveryAddressBuildingLabel);
            this.Controls.Add(this.DeliveryAddressStreetLabel);
            this.Controls.Add(this.DeliveryAddressCountryLabel);
            this.Controls.Add(this.DeliveryAddressPostIndexLabel);
            this.Controls.Add(this.DeliveryAddressLabel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(678, 191);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox DeliveryAddressCityTextBox;

        private System.Windows.Forms.Label DeliveryAddressCityLabel;

        private System.Windows.Forms.TextBox DeliveryAddressApartmentTextBox;

        private System.Windows.Forms.Label DeliveryAddressApartmentLabel;

        private System.Windows.Forms.TextBox DeliveryAddressCountryTextBox;

        private System.Windows.Forms.TextBox DeliveryAddressStreetTextBox;

        private System.Windows.Forms.TextBox DeliveryAddressBuildingTextBox;

        private System.Windows.Forms.TextBox DeliveryAddressPostIndexTextBox;

        private System.Windows.Forms.Label DeliveryAddressCountryLabel;

        private System.Windows.Forms.Label DeliveryAddressStreetLabel;

        private System.Windows.Forms.Label DeliveryAddressBuildingLabel;

        private System.Windows.Forms.Label DeliveryAddressPostIndexLabel;

        private System.Windows.Forms.Label DeliveryAddressLabel;

        #endregion
    }
}