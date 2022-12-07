using System;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View;

public partial class AddDiscountForm : Form
{
    private static readonly Color BackColorSuccess = Color.White;

    private static readonly Color BackColorException = Color.LightPink;
    
    public PercentDiscount PercentDiscount { get; private set; }

    private Category _category;
    
    public AddDiscountForm()
    {
        InitializeComponent();
        foreach (var category in Enum.GetValues(typeof(Category)))
        {
            CategoryComboBox.Items.Add(category);
        }
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        PercentDiscount = new PercentDiscount(_category);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void CategoryComboBox_TextUpdate(object sender, EventArgs e)
    {
        try
        {
            CategoryComboBox.BackColor = BackColorSuccess;
            var text = CategoryComboBox.Text;
            if (string.IsNullOrWhiteSpace(text)) return;
            _category = (Category)Enum.Parse(typeof(Category), text);
            OkButton.Enabled = true;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            CategoryComboBox.BackColor = BackColorException;
            OkButton.Enabled = false;
        }
    }

    private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            CategoryComboBox.BackColor = BackColorSuccess;
            _category = (Category)CategoryComboBox.SelectedItem;
            OkButton.Enabled = true;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            CategoryComboBox.BackColor = BackColorException;
            OkButton.Enabled = false;
        }
    }
}