using System.ComponentModel;

namespace ObjectOrientedPractics.View.Controls
{
    partial class OrderControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ObjectOrientedPractics.Model.Classes.Address address2 = new ObjectOrientedPractics.Model.Classes.Address();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.AmountValueLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.PriorityOptionLabel = new System.Windows.Forms.Label();
            this.priorityPanel = new System.Windows.Forms.Panel();
            this.priorityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.Location = new System.Drawing.Point(0, 251);
            this.OrderItemsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(333, 56);
            this.OrderItemsListBox.TabIndex = 28;
            // 
            // AmountValueLabel
            // 
            this.AmountValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountValueLabel.Location = new System.Drawing.Point(-2, 327);
            this.AmountValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountValueLabel.Name = "AmountValueLabel";
            this.AmountValueLabel.Size = new System.Drawing.Size(335, 36);
            this.AmountValueLabel.TabIndex = 27;
            this.AmountValueLabel.Text = "0";
            this.AmountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(-2, 309);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(335, 18);
            this.AmountLabel.TabIndex = 26;
            this.AmountLabel.Text = "Amount:";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(0, 225);
            this.OrderItemsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(335, 24);
            this.OrderItemsLabel.TabIndex = 25;
            this.OrderItemsLabel.Text = "Order Items";
            this.OrderItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(64, 75);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(169, 21);
            this.StatusComboBox.TabIndex = 23;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Enabled = false;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(64, 50);
            this.CreatedDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(169, 20);
            this.CreatedDateTimePicker.TabIndex = 22;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(64, 27);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(169, 20);
            this.IdTextBox.TabIndex = 21;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(0, 72);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(60, 24);
            this.StatusLabel.TabIndex = 20;
            this.StatusLabel.Text = "Status:";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedLabel.Location = new System.Drawing.Point(0, 48);
            this.CreatedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(60, 24);
            this.CreatedLabel.TabIndex = 19;
            this.CreatedLabel.Text = "Created:";
            this.CreatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IDLabel
            // 
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(0, 24);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(60, 24);
            this.IDLabel.TabIndex = 18;
            this.IDLabel.Text = "ID:";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOrderLabel.Location = new System.Drawing.Point(0, 0);
            this.SelectedOrderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(233, 24);
            this.SelectedOrderLabel.TabIndex = 17;
            this.SelectedOrderLabel.Text = "Selected Order";
            this.SelectedOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeliveryAddressControl
            // 
            address2.Apartment = "";
            address2.Building = "";
            address2.City = "";
            address2.Country = "";
            address2.Index = 0;
            address2.Street = "";
            this.DeliveryAddressControl.Address = address2;
            this.DeliveryAddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryAddressControl.Location = new System.Drawing.Point(0, 98);
            this.DeliveryAddressControl.Margin = new System.Windows.Forms.Padding(2);
            this.DeliveryAddressControl.Name = "DeliveryAddressControl";
            this.DeliveryAddressControl.Size = new System.Drawing.Size(399, 125);
            this.DeliveryAddressControl.TabIndex = 24;
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(5, 52);
            this.DeliveryTimeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(74, 21);
            this.DeliveryTimeComboBox.TabIndex = 46;
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(2, 23);
            this.DeliveryTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(77, 24);
            this.DeliveryTimeLabel.TabIndex = 45;
            this.DeliveryTimeLabel.Text = "Delivery Time:";
            this.DeliveryTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriorityOptionLabel
            // 
            this.PriorityOptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityOptionLabel.Location = new System.Drawing.Point(1, 0);
            this.PriorityOptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriorityOptionLabel.Name = "PriorityOptionLabel";
            this.PriorityOptionLabel.Size = new System.Drawing.Size(90, 24);
            this.PriorityOptionLabel.TabIndex = 44;
            this.PriorityOptionLabel.Text = "Priority Option";
            this.PriorityOptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priorityPanel
            // 
            this.priorityPanel.Controls.Add(this.DeliveryTimeLabel);
            this.priorityPanel.Controls.Add(this.DeliveryTimeComboBox);
            this.priorityPanel.Controls.Add(this.PriorityOptionLabel);
            this.priorityPanel.Enabled = false;
            this.priorityPanel.Location = new System.Drawing.Point(238, 24);
            this.priorityPanel.Name = "priorityPanel";
            this.priorityPanel.Size = new System.Drawing.Size(97, 93);
            this.priorityPanel.TabIndex = 47;
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priorityPanel);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.AmountValueLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.OrderItemsLabel);
            this.Controls.Add(this.DeliveryAddressControl);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.CreatedDateTimePicker);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SelectedOrderLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(335, 368);
            this.priorityPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox OrderItemsListBox;

        private System.Windows.Forms.Label AmountValueLabel;

        private System.Windows.Forms.Label AmountLabel;

        private System.Windows.Forms.Label OrderItemsLabel;

        private ObjectOrientedPractics.View.Controls.AddressControl DeliveryAddressControl;

        private System.Windows.Forms.ComboBox StatusComboBox;

        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;

        private System.Windows.Forms.TextBox IdTextBox;

        private System.Windows.Forms.Label StatusLabel;

        private System.Windows.Forms.Label CreatedLabel;

        private System.Windows.Forms.Label IDLabel;

        private System.Windows.Forms.Label SelectedOrderLabel;

        #endregion

        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.Label DeliveryTimeLabel;
        private System.Windows.Forms.Label PriorityOptionLabel;
        private System.Windows.Forms.Panel priorityPanel;
    }
}