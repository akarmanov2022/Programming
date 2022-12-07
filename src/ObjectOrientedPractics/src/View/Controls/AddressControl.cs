using System;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using static System.String;

namespace ObjectOrientedPractics.View.Controls;

public partial class AddressControl : UserControl
{
    private static readonly Color BackColorSuccess = Color.White;

    private static readonly Color BackColorException = Color.LightPink;

    private Address _address;

    public Address Address
    {
        get => _address;
        set
        {
            _address = value;
            UpdateFields();
        }
    }

    public AddressControl()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Обновляет поля в <see cref="AddressControl"/>.
    /// </summary>
    private void UpdateFields()
    {
        if (_address == null)
        {
            Clear();
            return;
        }

        DeliveryAddressApartmentTextBox.Text = _address.Apartment;
        DeliveryAddressBuildingTextBox.Text = _address.Building;
        DeliveryAddressCityTextBox.Text = _address.City;
        DeliveryAddressCountryTextBox.Text = _address.Country;
        DeliveryAddressStreetTextBox.Text = _address.Street;
        DeliveryAddressPostIndexTextBox.Text = _address.Index.ToString();
    }

    /// <summary>
    /// Очищает поля в <see cref="AddressControl"/>.
    /// </summary>
    public void Clear()
    {
        DeliveryAddressApartmentTextBox.Text = Empty;
        DeliveryAddressBuildingTextBox.Text = Empty;
        DeliveryAddressCityTextBox.Text = Empty;
        DeliveryAddressCountryTextBox.Text = Empty;
        DeliveryAddressStreetTextBox.Text = Empty;
        DeliveryAddressPostIndexTextBox.Text = Empty;
    }

    private void DeliveryAddressPostIndexTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            var text = DeliveryAddressPostIndexTextBox.Text;
            if (IsNullOrWhiteSpace(text)) return;
            var index = int.Parse(text);
            _address.Index = index;
            DeliveryAddressPostIndexTextBox.BackColor = BackColorSuccess;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            DeliveryAddressPostIndexTextBox.BackColor = BackColorException;
            _address.Index = 0;
        }
    }

    private void DeliveryAddressCountryTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            var text = DeliveryAddressCountryTextBox.Text;
            if (IsNullOrWhiteSpace(text)) return;
            _address.Country = text;
            DeliveryAddressCountryTextBox.BackColor = BackColorSuccess;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            DeliveryAddressCountryTextBox.BackColor = BackColorException;
            _address.Country = Empty;
        }
    }

    private void DeliveryAddressCityTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            var text = DeliveryAddressCityTextBox.Text;
            if (IsNullOrWhiteSpace(text)) return;
            _address.City = text;
            DeliveryAddressCityTextBox.BackColor = BackColorSuccess;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            DeliveryAddressCityTextBox.BackColor = BackColorException;
            _address.City = Empty;
        }
    }

    private void DeliveryAddressStreetTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            var text = DeliveryAddressStreetTextBox.Text;
            if (IsNullOrWhiteSpace(text)) return;
            _address.Street = text;
            DeliveryAddressStreetTextBox.BackColor = BackColorSuccess;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            DeliveryAddressStreetTextBox.BackColor = BackColorException;
            _address.Street = Empty;
        }
    }

    private void DeliveryAddressBuildingTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            var text = DeliveryAddressBuildingTextBox.Text;
            if (IsNullOrWhiteSpace(text)) return;
            _address.Building = text;
            DeliveryAddressBuildingTextBox.BackColor = BackColorSuccess;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            DeliveryAddressBuildingTextBox.BackColor = BackColorException;
            _address.Building = Empty;
        }
    }

    private void DeliveryAddressApartmentTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            var text = DeliveryAddressApartmentTextBox.Text;
            if (IsNullOrWhiteSpace(text)) return;
            _address.Apartment = text;
            DeliveryAddressApartmentTextBox.BackColor = BackColorSuccess;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            DeliveryAddressApartmentTextBox.BackColor = BackColorException;
            _address.Apartment = Empty;
        }
    }
}