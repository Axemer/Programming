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

namespace ObjectOrientedPractics.View
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список всех предметов.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Выбраный предмет.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Обновляет информацию внутри ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (Item product in _items)
            {
                ItemsListBox.Items.Add(product.Name);
            }
        }

        /// <summary>
        /// Чистит все ткстбоксы и меняется цвет на цвет по умолчанию.
        /// </summary>
        private void ClearAllFields()
        {
            NameTextBox.Text = null;
            DescriptionTextBox.Text = null;
            IDTextBox.Text = null;
            CostTextBox.Text = null;
        }

        public ItemsTab()
        {
            InitializeComponent();

            _items = new List<Item>();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0)
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];
                IDTextBox.Text = $"{_currentItem.ID}";
                NameTextBox.Text = _currentItem.Name;
                DescriptionTextBox.Text = _currentItem.Info;
                CostTextBox.Text = $"{_currentItem.Cost}";
            }
            else
                ClearAllFields();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item("No name", "No info", 0.0);
            _items.Add(_currentItem);
            UpdateListBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(ItemsListBox != null)
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex);
                ClearAllFields();
                UpdateListBox();
            }
            else
            {
                UpdateListBox();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(ItemsListBox.SelectedIndex >= 0)
                {
                    _currentItem.Name = NameTextBox.Text;
                    NameTextBox.BackColor = AppColors._defaultColor;
                    UpdateListBox();
                }
            }
            catch
            {
                NameTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _currentItem.Info = DescriptionTextBox.Text;
                    DescriptionTextBox.BackColor = AppColors._defaultColor;
                }
            }
            catch
            {
                DescriptionTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ItemsListBox.SelectedIndex >= 0)
                {
                    _currentItem.Cost = double.Parse(CostTextBox.Text);
                    CostTextBox.BackColor = AppColors._defaultColor;
                }
            }
            catch
            {
                CostTextBox.BackColor = AppColors._errorColor;
            }
        }
    }
}
