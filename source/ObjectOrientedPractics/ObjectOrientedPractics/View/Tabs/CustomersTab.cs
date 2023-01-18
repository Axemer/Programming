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

        // Модификатор internal по тому что без него компилятор ругается.
        /// <summary>
        /// Возвращает и задаёт список Покупателей.
        /// </summary>
        internal List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

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
            IsPriorityCheckBox.Checked = false;
            IsPriorityCheckBox.Enabled = false;
            DiscountsRemoveButton.Enabled = false;
            DiscountsAddButton.Enabled = false;

            FullnameTextBox.BackColor = AppColors._defaultColor;
        }

        private void UpdateAllFields()
        {
            IDTextBox.Text = $"{_currentCustomer.ID}";
            FullnameTextBox.Text = _currentCustomer.Fullname;

            AddressControl._address = _currentCustomer.Address;
            AddressControl.IndexTextBox.Text = _currentCustomer.Address.Index.ToString();
            AddressControl.CountryTextBox.Text = _currentCustomer.Address.Country;
            AddressControl.CityTextBox.Text = _currentCustomer.Address.City;
            AddressControl.StreetTextBox.Text = _currentCustomer.Address.Street;
            AddressControl.BuildingTextBox.Text = _currentCustomer.Address.Building;
            AddressControl.ApartmentTextBox.Text = _currentCustomer.Address.Apartment;
            IsPriorityCheckBox.Enabled = true;
            IsPriorityCheckBox.Checked = _currentCustomer.IsPriority;
            DiscountsListBox.Items.Clear();
            DiscountsAddButton.Enabled = true;
            foreach (var discount in _currentCustomer.Discounts)
            {
                DiscountsListBox.Items.Add(discount);
            }
        }



        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0)
            {
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];
                
                UpdateAllFields();
            }
        }

        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0)
            {
                int currentIndex = CustomersListBox.SelectedIndex;
                try
                {
                    _currentCustomer.Fullname = FullnameTextBox.Text;
                    FullnameTextBox.BackColor = AppColors._defaultColor;
                    UpdateListBox();
                    CustomersListBox.SelectedIndex = currentIndex;
                }
                catch
                {
                    FullnameTextBox.BackColor = AppColors._errorColor;
                }
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

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.IsPriority = IsPriorityCheckBox.Checked;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void DiscountsAddButton_Click(object sender, EventArgs e)
        {
            var form = new AddDiscountForm();
            if (form.ShowDialog() != DialogResult.OK) return;
            var discount = form.PercentDiscount;
            _currentCustomer.Discounts.Add(discount);
            DiscountsListBox.Items.Add(discount);
        }

        private void DiscountsRemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0)
            {
                _currentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
                ClearAllFields();
            }
            else
                UpdateAllFields();
        }

        private void DiscountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiscountsRemoveButton.Enabled = !(DiscountsListBox.SelectedItem is PointsDiscount);
        }
    }
}
