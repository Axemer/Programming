using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Содержит данные о выбраном покупателе.
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
            AddressTextBox.Text = null;
            IDTextBox.Text = null;

            FullnameTextBox.BackColor = AppColors._defaultColor;
            AddressTextBox.BackColor = AppColors._defaultColor;
            IDTextBox.BackColor = AppColors._defaultColor;

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
                AddressTextBox.Text = _currentCustomer.Address;
            }
        }

        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CustomersListBox.SelectedIndex >= 0)
                {
                    _currentCustomer.Fullname = FullnameTextBox.Text;
                    FullnameTextBox.BackColor = AppColors._defaultColor;
                    UpdateListBox();
                }
            }
            catch
            {
                FullnameTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CustomersListBox.SelectedIndex >= 0)
                {
                    _currentCustomer.Address = AddressTextBox.Text;
                    AddressTextBox.BackColor = AppColors._defaultColor;
                    UpdateListBox();
                }
            }
            catch
            {
                AddressTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer("No Name", "No Address");
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
