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
using static System.String;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        public Address _address;

        /// <summary>
        /// Очищает поля в <see cref="AddressControl"/>.
        /// </summary>
        public void Clear()
        {
            IndexTextBox.Clear();
            IndexTextBox.BackColor= Color.White;
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            ApartmentTextBox.Clear();
            BuildingTextBox.Clear();
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

            ApartmentTextBox.Text = _address.Apartment;
            BuildingTextBox.Text = _address.Building;
            CityTextBox.Text = _address.City;
            CountryTextBox.Text = _address.Country;
            StreetTextBox.Text = _address.Street;
            IndexTextBox.Text = _address.Index.ToString();
        }

        public AddressControl()
        {
            InitializeComponent();
        }

        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                UpdateFields();
            }
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (IsNullOrWhiteSpace(BuildingTextBox.Text)) return;
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
                if (IsNullOrWhiteSpace(CountryTextBox.Text)) return;
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
                if (IsNullOrWhiteSpace(CityTextBox.Text)) return;
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
                if (IsNullOrWhiteSpace(StreetTextBox.Text)) return;
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
                if (IsNullOrWhiteSpace(CityTextBox.Text)) return;
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
                if (IsNullOrWhiteSpace(BuildingTextBox.Text)) return;
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
