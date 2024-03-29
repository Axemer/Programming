﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Service;
using static System.String;

namespace ObjectOrientedPractics.View.Tabs;

public partial class CustomersTab : UserControl
{
    private static readonly Color BackColorSuccess = Color.White;

    private static readonly Color BackColorException = Color.LightPink;

    private Customer _currentCustomer;

    private List<Customer> _customers;

    internal List<Customer> Customers
    {
        get => _customers;
        set
        {
            _customers = value;
            UpdateCustomersListBox();
        }
    }

    public CustomersTab()
    {
        InitializeComponent();

        CustomersRemoveButton.Enabled = false;
    }


    private void SelectedCustomerFullnameTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            var text = SelectedCustomerFullnameTextBox.Text;
            if (IsNullOrWhiteSpace(text)) return;
            _currentCustomer.Fullname = text;
            SelectedCustomerFullnameTextBox.BackColor = BackColorSuccess;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            SelectedCustomerFullnameTextBox.BackColor = BackColorException;
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

    private void CustomersAddButton_Click(object sender, EventArgs e)
    {
        _currentCustomer = new Customer()
        {
            Discounts = { new PointsDiscount() }
        };
        _currentCustomer.Fullname = $"{nameof(Customer)} {_currentCustomer.Id}";
        Customers.Add(_currentCustomer);
        UpdateCustomersListBox();
        ClearTextBoxes();
    }

    private void CustomersRemoveButton_Click(object sender, EventArgs e)
    {
        Customers.Remove(_currentCustomer);
        UpdateCustomersListBox();
        ClearTextBoxes();
        CustomersRemoveButton.Enabled = false;
        _currentCustomer = new Customer();
    }

    private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        _currentCustomer = (Customer)CustomersListBox.SelectedItem;
        UpdateFields();
        CustomersRemoveButton.Enabled = true;
        DiscountsAddButton.Enabled = true;
    }

    private void UpdateFields()
    {
        SelectedCustomerIdTextBox.Text = _currentCustomer.Id.ToString();
        SelectedCustomerFullnameTextBox.Text = _currentCustomer.Fullname;
        DeliveryAddressControl.Address = _currentCustomer.Address;
        IsPriorityCheckBox.Checked = _currentCustomer.IsPriority;
        DiscountsListBox.Items.Clear();
        foreach (var discount in _currentCustomer.Discounts)
        {
            DiscountsListBox.Items.Add(discount);
        }
    }

    /// <summary>
    /// Удаляет текст из всех элементов формы
    /// типа <see cref="TextBox"/>
    /// </summary>
    private void ClearTextBoxes()
    {
        SelectedCustomerIdTextBox.Clear();
        SelectedCustomerFullnameTextBox.Clear();
        DeliveryAddressControl.Clear();
        IsPriorityCheckBox.Checked = false;
    }

    private void UpdateCustomersListBox()
    {
        CustomersListBox.Items.Clear();
        foreach (var customer in Customers)
        {
            CustomersListBox.Items.Add(customer);
        }
    }

    private void CustomersRandomButton_Click(object sender, EventArgs e)
    {
        var random = new Random();
        Customers.Clear();
        Customers.AddRange(CustomerFactory.RandomGenerate(random.Next(10, 100)));
        UpdateCustomersListBox();
    }

    private void DiscountsAddButton_Click(object sender, EventArgs e)
    {
        var form = new AddDiscountForm();
        if (form.ShowDialog() != DialogResult.OK) return;
        var discount = form.PercentDiscount;
        _currentCustomer.Discounts.Add(discount);
        DiscountsListBox.Items.Add(discount);
    }

    private void DiscountsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        DiscountsRemoveButton.Enabled = DiscountsListBox.SelectedItem is not PointsDiscount;
    }
}