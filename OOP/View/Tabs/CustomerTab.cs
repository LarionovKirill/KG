using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.View
{
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Список пользователей.
        /// </summary>
        List<Model.Customer> _customers = new List<Model.Customer>();

        /// <summary>
        /// Свойство поля _customers.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Model.Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }
        public CustomerTab()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Обработка нажатия выбранного пользователя.
        /// </summary>
        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerListBox.SelectedIndex>=0)
            {
                var index = customerListBox.SelectedIndex;
                FillFieldsOfCustomer(Customers[index]);
            }
        }

        /// <summary>
        /// Заполняет поля данными из класса.
        /// </summary>
        /// <param name="current">Передаваемый класс с информацией о пользователе.</param>
        public void FillFieldsOfCustomer(Model.Customer current)
        {
            idCustomerTextBox.Text = current.Id.ToString();
            addressTextBox.Text = current.Address;
            fullNameTextBox.Text = current.FullName;
        }

        /// <summary>
        /// Добавляет пользователя в список.
        /// </summary>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                Customers.Add(new Model.Customer(
                    fullNameTextBox.Text,
                    addressTextBox.Text
                    ));
                customerListBox.Items.Add($"Пользователь : {Customers.Last().Id}");
            }
            catch
            {
                MessageBox.Show("Введите верные значения.");
            }
        }

        /// <summary>
        /// Удаляет пользователя из списка.
        /// </summary>
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (customerListBox.SelectedIndex >= 0)
            {
                var index = customerListBox.SelectedIndex;
                Customers.RemoveAt(index);
                customerListBox.Items.RemoveAt(index);
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OOP.Services.ValueValidator.AssertStringOnLength(
                    fullNameTextBox.Text,
                    200,
                    "Full Name должен быть меньше 200 символов.");
                fullNameTextBox.BackColor = Color.White;
            }
            catch
            {
                fullNameTextBox.BackColor = Color.Pink;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OOP.Services.ValueValidator.AssertStringOnLength(
                    addressTextBox.Text,
                    500,
                    "Address должен быть меньше 500 символов.");
                addressTextBox.BackColor = Color.White;
            }
            catch
            {
                addressTextBox.BackColor = Color.Pink;
            }
        }
    }
}
