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
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        List<Model.Item> _items = new List<Model.Item>();

        /// <summary>
        /// Свойство поля _items.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Model.Item> Items
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
        /// Метод создающий компоненты формы.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод добавлет товар в список.
        /// </summary>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                Items.Add(new Model.Item(
                    nameItemTextBox.Text,
                    descriptionItemTextBox.Text,
                    double.Parse(costItemTextBox.Text)
                    ));
                itemListBox.Items.Add($"Товар : {Items.Last().Id}");
            }
            catch
            {
                MessageBox.Show("Введите верные значения.");
            }
        }

        /// <summary>
        /// Удаляет товар из списка.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (itemListBox.SelectedIndex >= 0)
            {
                var index = itemListBox.SelectedIndex;
                Items.RemoveAt(index);
                itemListBox.Items.RemoveAt(index);
            }
        }

        /// <summary>
        /// Проверяет изменения поля цены.
        /// </summary>
        private void СostItemTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OOP.Services.ValueValidator.AssertValueInRange(
                    double.Parse(costItemTextBox.Text),
                    0,
                    100000,
                    "Цена не может иметь данное значение. Ёе диапазон от 0 до 100000"
                    );
                costItemTextBox.BackColor = Color.White;
            }
            catch
            {
                costItemTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Проверяет изменения поля имени.
        /// </summary>
        private void NameItemTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OOP.Services.ValueValidator.AssertStringOnLength(
                    nameItemTextBox.Text,
                    200,
                    "Name должен быть меньше 200 символов.");
                nameItemTextBox.BackColor = Color.White;
            }
            catch
            {
                nameItemTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Проверяет изменения поля описания.
        /// </summary>
        private void DescriptionItemTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OOP.Services.ValueValidator.AssertStringOnLength(
                    descriptionItemTextBox.Text,
                    1000,
                    "Name должен быть меньше 200 символов.");
                descriptionItemTextBox.BackColor = Color.White;
            }
            catch
            {
                descriptionItemTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Срабатывает при выборе товара из списка.
        /// </summary>
        private void ItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemListBox.SelectedIndex >= 0)
            {
                var index = itemListBox.SelectedIndex;
                FillingInTheProductField(Items[index]);
            }
        }

        /// <summary>
        /// Заполянет поля из значений класса.
        /// </summary>
        private void FillingInTheProductField(Model.Item current)
        {
            idItemTextBox.Text = current.Id.ToString();
            nameItemTextBox.Text = current.Name;
            descriptionItemTextBox.Text = current.Info;
            costItemTextBox.Text = current.Cost.ToString();
        }
    }
}
