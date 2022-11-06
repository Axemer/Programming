using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        public Address _address;

        public AddressControl()
        {
            InitializeComponent();
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = int.Parse(IndexTextBox.Text);
                IndexTextBox.BackColor = AppColors._defaultColor;
            }
            catch
            {
                IndexTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = AppColors._defaultColor;
            }
            catch
            {
                CountryTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;
                CityTextBox.BackColor = AppColors._defaultColor;
            }
            catch
            {
                CityTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = AppColors._defaultColor;
            }
            catch
            {
                StreetTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = AppColors._defaultColor;
            }
            catch
            {
                ApartmentTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = AppColors._defaultColor;
            }
            catch
            {
                BuildingTextBox.BackColor = AppColors._errorColor;
            }
        }
    }
}
