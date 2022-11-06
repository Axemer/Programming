using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Содержит данные о выбранном покупателе.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Обновляет информацию внутри ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear();
            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add(customer.Fullname);
            }
        }

        /// <summary>
        /// Чистит все ткстбоксы и меняется цвет на цвет по умолчанию.
        /// </summary>
        private void ClearAllFields()
        {
            FullnameTextBox.Text = null;
            IDTextBox.Text = null;
            AddressControl._address = null;

            FullnameTextBox.BackColor = AppColors._defaultColor;
        }

        public CustomersTab()
        {
            InitializeComponent();

            _customers = new List<Customer>();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0)
            {
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];
                IDTextBox.Text = $"{_currentCustomer.ID}";
                FullnameTextBox.Text = _currentCustomer.Fullname;

                AddressControl._address = _currentCustomer.Address;
                AddressControl.IndexTextBox.Text = _currentCustomer.Address.Index.ToString();
                AddressControl.CountryTextBox.Text = _currentCustomer.Address.Country;
                AddressControl.CityTextBox.Text = _currentCustomer.Address.City;
                AddressControl.StreetTextBox.Text = _currentCustomer.Address.Street;
                AddressControl.BuildingTextBox.Text = _currentCustomer.Address.Building;
                AddressControl.ApartmentTextBox.Text = _currentCustomer.Address.Apartment;
            }
        }

        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Fullname = FullnameTextBox.Text;
                FullnameTextBox.BackColor = AppColors._defaultColor;
                UpdateListBox();
            }
            catch
            {
                FullnameTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer();
            _customers.Add(_currentCustomer);
            UpdateListBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0)
            {
                _customers.RemoveAt(CustomersListBox.SelectedIndex);
                ClearAllFields();
                UpdateListBox();
            }
            else
            {
                UpdateListBox();
            }
        }
    }
}
