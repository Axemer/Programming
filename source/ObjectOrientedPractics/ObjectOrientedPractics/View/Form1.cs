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
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class Form1 : Form
    {
        private readonly Store _store;
        public Form1()
        {
            InitializeComponent();
            _store = new Store();

            itemsTab.Items = _store.Items;
            customersTab.Customers = _store.Customers;
            /// Крч тут надо сделать так чтоб списки передовались из стора но оно не работает
        }
        
    }
}
