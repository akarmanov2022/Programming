using System.ComponentModel;

namespace ObjectOrientedPractics.View;

partial class AddDiscountForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.PercentDiscountLabel = new System.Windows.Forms.Label();
        this.CategoryLabel = new System.Windows.Forms.Label();
        this.CategoryComboBox = new System.Windows.Forms.ComboBox();
        this.CancelButton = new System.Windows.Forms.Button();
        this.OkButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // PercentDiscountLabel
        // 
        this.PercentDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.PercentDiscountLabel.Location = new System.Drawing.Point(12, 59);
        this.PercentDiscountLabel.Name = "PercentDiscountLabel";
        this.PercentDiscountLabel.Size = new System.Drawing.Size(404, 45);
        this.PercentDiscountLabel.TabIndex = 0;
        this.PercentDiscountLabel.Text = "Percent Discount";
        this.PercentDiscountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // CategoryLabel
        // 
        this.CategoryLabel.Location = new System.Drawing.Point(12, 104);
        this.CategoryLabel.Name = "CategoryLabel";
        this.CategoryLabel.Size = new System.Drawing.Size(121, 23);
        this.CategoryLabel.TabIndex = 1;
        this.CategoryLabel.Text = "Category:";
        // 
        // CategoryComboBox
        // 
        this.CategoryComboBox.FormattingEnabled = true;
        this.CategoryComboBox.Location = new System.Drawing.Point(139, 101);
        this.CategoryComboBox.Name = "CategoryComboBox";
        this.CategoryComboBox.Size = new System.Drawing.Size(277, 28);
        this.CategoryComboBox.TabIndex = 2;
        this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
        this.CategoryComboBox.TextUpdate += new System.EventHandler(this.CategoryComboBox_TextUpdate);
        // 
        // CancelButton
        // 
        this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.CancelButton.Location = new System.Drawing.Point(272, 196);
        this.CancelButton.Name = "CancelButton";
        this.CancelButton.Size = new System.Drawing.Size(144, 51);
        this.CancelButton.TabIndex = 3;
        this.CancelButton.Text = "Cancel";
        this.CancelButton.UseVisualStyleBackColor = true;
        this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
        // 
        // OkButton
        // 
        this.OkButton.Enabled = false;
        this.OkButton.Location = new System.Drawing.Point(122, 196);
        this.OkButton.Name = "OkButton";
        this.OkButton.Size = new System.Drawing.Size(144, 51);
        this.OkButton.TabIndex = 4;
        this.OkButton.Text = "OK";
        this.OkButton.UseVisualStyleBackColor = true;
        this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
        // 
        // AddDiscountForm
        // 
        this.AcceptButton = this.OkButton;
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(428, 259);
        this.Controls.Add(this.OkButton);
        this.Controls.Add(this.CancelButton);
        this.Controls.Add(this.CategoryComboBox);
        this.Controls.Add(this.CategoryLabel);
        this.Controls.Add(this.PercentDiscountLabel);
        this.MaximumSize = new System.Drawing.Size(450, 315);
        this.MinimumSize = new System.Drawing.Size(450, 315);
        this.Name = "AddDiscountForm";
        this.ShowIcon = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Add Discount";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button OkButton;

    private System.Windows.Forms.Button CancelButton;

    private System.Windows.Forms.ComboBox CategoryComboBox;

    private System.Windows.Forms.Label CategoryLabel;

    private System.Windows.Forms.Label PercentDiscountLabel;

    #endregion
}