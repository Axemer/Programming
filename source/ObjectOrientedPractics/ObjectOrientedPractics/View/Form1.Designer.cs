﻿namespace ObjectOrientedPractics
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Items = new System.Windows.Forms.TabPage();
            this.Customers = new System.Windows.Forms.TabPage();
            this.Carts = new System.Windows.Forms.TabPage();
            this.itemsTab = new ObjectOrientedPractics.View.ItemsTab();
            this.customersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.TabControl.SuspendLayout();
            this.Items.SuspendLayout();
            this.Customers.SuspendLayout();
            this.Carts.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Items);
            this.TabControl.Controls.Add(this.Customers);
            this.TabControl.Controls.Add(this.Carts);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(579, 450);
            this.TabControl.TabIndex = 0;
            // 
            // Items
            // 
            this.Items.Controls.Add(this.itemsTab);
            this.Items.Location = new System.Drawing.Point(4, 22);
            this.Items.Name = "Items";
            this.Items.Padding = new System.Windows.Forms.Padding(3);
            this.Items.Size = new System.Drawing.Size(571, 424);
            this.Items.TabIndex = 0;
            this.Items.Text = "Items";
            this.Items.UseVisualStyleBackColor = true;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.customersTab);
            this.Customers.Location = new System.Drawing.Point(4, 22);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(571, 424);
            this.Customers.TabIndex = 1;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // Carts
            // 
            this.Carts.Controls.Add(this.cartsTab1);
            this.Carts.Location = new System.Drawing.Point(4, 22);
            this.Carts.Name = "Carts";
            this.Carts.Size = new System.Drawing.Size(571, 424);
            this.Carts.TabIndex = 2;
            this.Carts.Text = "Carts";
            this.Carts.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            this.itemsTab.AutoSize = true;
            this.itemsTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.itemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab.Location = new System.Drawing.Point(3, 3);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Size = new System.Drawing.Size(565, 418);
            this.itemsTab.TabIndex = 0;
            // 
            // customersTab
            // 
            this.customersTab.AutoSize = true;
            this.customersTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab.Location = new System.Drawing.Point(3, 3);
            this.customersTab.Name = "customersTab";
            this.customersTab.Size = new System.Drawing.Size(565, 418);
            this.customersTab.TabIndex = 0;
            // 
            // cartsTab1
            // 
            this.cartsTab1.Location = new System.Drawing.Point(2, 2);
            this.cartsTab1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cartsTab1.Name = "cartsTab1";
            this.cartsTab1.Size = new System.Drawing.Size(573, 424);
            this.cartsTab1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.Items.ResumeLayout(false);
            this.Items.PerformLayout();
            this.Customers.ResumeLayout(false);
            this.Customers.PerformLayout();
            this.Carts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Items;
        private System.Windows.Forms.TabPage Customers;
        private View.Tabs.CustomersTab customersTab;
        private View.ItemsTab itemsTab;
        private System.Windows.Forms.TabPage Carts;
        private View.Tabs.CartsTab cartsTab1;
    }
}

