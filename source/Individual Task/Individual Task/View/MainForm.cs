using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Individual_Task.Model.Classes;

namespace Individual_Task
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список всех продуктов.
        /// </summary>
        private List<Product> _products = new List<Product>();

        /// <summary>
        /// Выбранный продукт.
        /// </summary>
        private Product _currentProduct;

        /// <summary>
        /// Стандартный цвет полей ввода.
        /// </summary>
        private Color _defaultColor = AppColors._defaultColor;

        /// <summary>
        /// Цвет полей ввода содержащих некорректную информацию.
        /// </summary>
        private Color _errorColor = AppColors._errorColor;

        public MainForm()
        {
            InitializeComponent();
            _currentProduct = new Product();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            ProjectSerializer.DeserializeListBoxJSON(_products);
            CategoryComboBox.SelectedIndex = -1;
            LockAllFields();
            UpdateListBox();
        }

        private void ProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductsListBox.SelectedIndex >= 0)
            {
                SetToDefaultAllFields();
                _currentProduct = _products[ProductsListBox.SelectedIndex];
                NameTextBox.Text = _currentProduct.Name;
                ManufacturerTextBox.Text = _currentProduct.Manufacturer;
                QuantityTextBox.Text = _currentProduct.Quantity.ToString();
                CategoryComboBox.Text = _currentProduct.Category;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentProduct.Name = NameTextBox.Text;
                NameTextBox.BackColor = _defaultColor;
                _products.Sort((a, b) => a.Name.CompareTo(b.Name));
                ToolTip.Hide(NameTextBox);
                UpdateListBox();
            }
            catch
            {
                NameTextBox.BackColor = _errorColor;
                ToolTip.Show("Название должно быть не более 100 символов!", NameTextBox);
            }
        }

        private void ManufacturerTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentProduct.Manufacturer = ManufacturerTextBox.Text;
                ManufacturerTextBox.BackColor = _defaultColor;
                ToolTip.Hide(ManufacturerTextBox);
            }
            catch
            {
                ManufacturerTextBox.BackColor = _errorColor;
                ToolTip.Show("Имя производителя должно быть не более 100 символов!", ManufacturerTextBox);
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentProduct.Category = CategoryComboBox.Text;
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentProduct.Quantity = int.Parse(QuantityTextBox.Text);
                QuantityTextBox.BackColor = _defaultColor;
            }
            catch
            {
                QuantityTextBox.BackColor = _errorColor;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentProduct = new Product(
                "Без имени",
                null,
                0,
                null);
            _products.Add(_currentProduct);
            SetToDefaultAllFields();
            _products.Sort((a, b) => a.Name.CompareTo(b.Name));
            UpdateListBox();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProductsListBox.SelectedIndex >= 0)
            {
                _products.RemoveAt(ProductsListBox.SelectedIndex);
                ClearAllFields();
                UpdateListBox();
            }
            if(ProductsListBox.SelectedIndex == 0)
            {
                ClearAllFields();
                LockAllFields();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectSerializer.SerializeListJSON(_products);
        }

        /// <summary>
        /// Обновляет информацию внутри ListBox.
        /// </summary>
        void UpdateListBox()
        {
            ProductsListBox.Items.Clear();
            foreach (Product product in _products)
            {
                ProductsListBox.Items.Add(product.Name);
            }
        }

        /// <summary>
        /// Делает все поля ввода данных неактивными.
        /// </summary>
        void LockAllFields()
        {
            NameTextBox.Enabled = false;
            ManufacturerTextBox.Enabled = false;
            QuantityTextBox.Enabled = false;
            CategoryComboBox.Enabled = false;
        }

        /// <summary>
        /// Чистит все ткстбоксы и меняется цвет на цвет по умолчанию.
        /// </summary>
        void ClearAllFields()
        {
            NameTextBox.Text = null;
            ManufacturerTextBox.Text = null;
            QuantityTextBox.Text = null;
            CategoryComboBox.Text = null;

            NameTextBox.BackColor = AppColors._defaultColor;
            ManufacturerTextBox.BackColor = AppColors._defaultColor;
            QuantityTextBox.BackColor = AppColors._defaultColor;
        }

        /// <summary>
        /// задаёт textbox'ам стандартные цвета.
        /// Делает все поля ввода данных активными.
        /// </summary>
        private void SetToDefaultAllFields()
        {
            NameTextBox.BackColor = AppColors._defaultColor;
            ManufacturerTextBox.BackColor = AppColors._defaultColor;

            NameTextBox.Enabled = true;
            ManufacturerTextBox.Enabled = true;
            QuantityTextBox.Enabled = true;
            CategoryComboBox.Enabled = true;
        }
    }
}
