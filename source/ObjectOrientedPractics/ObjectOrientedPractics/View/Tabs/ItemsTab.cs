using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список всех предметов.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Выбранный предмет.
        /// </summary>
        private Item _currentItem;

        // Модификатор internal по тому что без него компилятор ругается.
        /// <summary>
        /// Возвращает и задаёт список предметов.
        /// </summary>
        internal List<Item> Items
        {
            get 
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

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
        /// Чистит все текст боксы и меняется цвет на цвет по умолчанию.
        /// </summary>
        private void ClearAllFields()
        {
            NameTextBox.Text = null;
            DescriptionTextBox.Text = null;
            IDTextBox.Text = null;
            CostTextBox.Text = null;
            CategoryComboBox.Text = null;
        }

        public ItemsTab()
        {
            InitializeComponent();

            //_items = new List<Item>();
            Array _category = Enum.GetValues(typeof(Category));
            foreach (var value in _category)
            {
                CategoryComboBox.Items.Add(value);
            }
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
                CategoryComboBox.Text = $"{_currentItem.Category}";
            }
            else
            {
                _currentItem = null;
                ClearAllFields();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item("No name", "No info", 0.0, 0);
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
            if (ItemsListBox.SelectedIndex >= 0)
            {
                int currentIndex = ItemsListBox.SelectedIndex;

                try
                {
                    _currentItem.Name = NameTextBox.Text;
                    NameTextBox.BackColor = AppColors._defaultColor;
                    UpdateListBox();
                    ItemsListBox.SelectedIndex = currentIndex;
                }
                catch
                {
                    NameTextBox.BackColor = AppColors._errorColor;
                }
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0) 
            {
                try
                {
                    _currentItem.Info = DescriptionTextBox.Text;
                    DescriptionTextBox.BackColor = AppColors._defaultColor;
                }
                catch
                {
                    DescriptionTextBox.BackColor = AppColors._errorColor;
                }
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0) 
            {
                try
                {
                    _currentItem.Cost = double.Parse(CostTextBox.Text);
                    CostTextBox.BackColor = AppColors._defaultColor;
                }
                catch
                {
                    CostTextBox.BackColor = AppColors._errorColor;
                }
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0) 
            {
                try
                {
                    _currentItem.Category = (Category)CategoryComboBox.SelectedIndex;
                    CostTextBox.BackColor = AppColors._defaultColor;
                }
                catch
                {
                    CostTextBox.BackColor = AppColors._errorColor;
                }
            }            
        }
    }
}
