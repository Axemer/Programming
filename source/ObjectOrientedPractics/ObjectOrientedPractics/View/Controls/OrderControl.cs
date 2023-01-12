﻿using System;
using System.Globalization;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.View.Tabs;
using static System.String;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class OrderControl : UserControl
    {
        private Order _order;

        public Order Order
        {
            get 
            {
                return _order; 
            }
            set
            {
                _order = value;
                UpdateFields();
            }
        }

        public OrderControl()
        {
            InitializeComponent();
            
            foreach (var value in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(value);
            }
            foreach (var value in PriorityOrder.DeliveryTimeIntervals)
            {
                DeliveryTimeComboBox.Items.Add(value);
            }
        }

        /// <summary>
        /// Очищает поля в <see cref="OrderControl"/>.
        /// </summary>
        public void Clear()
        {
            Order = null;
            IdTextBox.Text = Empty;
            CreatedDateTimePicker.Value = DateTime.Now;
            StatusComboBox.SelectedIndex = -1;
            DeliveryAddressControl.Clear();
            OrderItemsListBox.Items.Clear();
            AmountValueLabel.Text = @"0";
        }

        /// <summary>
        /// Обновляет поля в <see cref="OrderControl"/>.
        /// </summary>
        private void UpdateFields()
        {
            if (_order == null) return;
            IdTextBox.Text = _order.Id.ToString();
            CreatedDateTimePicker.Value = _order.CreateDate;
            StatusComboBox.SelectedItem = _order.Status;
            DeliveryAddressControl.Address = _order.DeliveryAddress;
            AmountValueLabel.Text = _order.Amount.ToString(CultureInfo.CurrentCulture);
            OrderItemsListBox.Items.Clear();
            foreach (var item in _order.Items)
            {
                OrderItemsListBox.Items.Add(item);
            }

            switch (_order) //////////////////////////////////////////// Не понимаю как работает надо разобратся
            {
                case PriorityOrder priorityOrder:
                    priorityPanel.Visible = true;
                    DeliveryTimeComboBox.SelectedItem = priorityOrder.DeliveryInterval;
                    break;
                default:
                    priorityPanel.Visible = false;
                    DeliveryTimeComboBox.SelectedIndex = -1;
                    break;
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedIndex == -1 || Order == null) 
                return;
            var status = (OrderStatus) StatusComboBox.SelectedItem;
            if (status == Order.Status) 
                return;
            Order.Status = status;
            Order.History.Add(DateTime.Now, status);
            ((OrdersTab) Parent).UpdateOrders();
        }
    }
}