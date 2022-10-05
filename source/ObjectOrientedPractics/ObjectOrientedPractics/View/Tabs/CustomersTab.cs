using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// 
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Обновляет информацию внутри ListBox.
        /// </summary>
        void UpdateListBox()
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
        void ClearAllFields()
        {
            FullnameTextBox.Text = null;
            AddressTextBox.Text = null;
            IDTextBox.Text = null;
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
                    FullnameTextBox.BackColor = Color.White;
                    UpdateListBox();
                }
            }
            catch
            {
                FullnameTextBox.BackColor = Color.Red;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CustomersListBox.SelectedIndex >= 0)
                {
                    _currentCustomer.Address = AddressTextBox.Text;
                    AddressTextBox.BackColor = Color.White;
                    UpdateListBox();
                }
            }
            catch
            {
                AddressTextBox.BackColor = Color.Red;
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
