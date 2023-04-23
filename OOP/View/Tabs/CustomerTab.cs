using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.View.Tabs
{
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        List<Model.Customer> _customers = new List<Model.Customer>();

        /// <summary>
        /// Свойство для поля _customers.
        /// </summary>
        public List<Model.Customer> Customers
        {
            set 
            {
                _customers = value;
            }
            get
            {
                return _customers;
            }
        }

        public CustomerTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Заполняет поля по выбранному покупателю.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = customersListBox.SelectedIndex;
            FillTheFieldsOfCustomers(Customers[index]);
        }

        /// <summary>
        /// Заполняет поля из информации класса.
        /// </summary>
        /// <param name="current">Передаваемый класс с информацией.</param>
        private void FillTheFieldsOfCustomers(Model.Customer current)
        {
            addressTextBox.Text = current.Address;
            fullNameTextBox.Text = current.FullName;
            idCustomerTextBox.Text = current.Id.ToString();
        }
    }
}
