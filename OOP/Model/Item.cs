using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
	/// <summary>
	/// Класс товар.
	/// </summary>
	public class Item
	{
		/// <summary>
		/// Id товара.
		/// </summary>
		static private int _id;

		/// <summary>
		/// Название товара.
		/// </summary>
		private string _name;

		/// <summary>
		/// Описание товара.
		/// </summary>
		private string _info;

		/// <summary>
		/// Цена товара.
		/// </summary>
		private double _cost;

		/// <summary>
		/// Свойство для поля _id.
		/// </summary>
		public int Id { get; private set; }

		/// <summary>
		/// Свойство для поля _name.
		/// </summary>
		public string Name
		{
			set
			{
				OOP.Services.ValueValidator.AssertStringOnLength(
					value,
					200,
					"Name должен быть меньше 200 символов.");
				_name = value;
			}
			get
			{
				return _name;
			}
		}

		/// <summary>
		/// Свойство для поля _info.
		/// </summary>
		public string Info
		{
			set
			{
				OOP.Services.ValueValidator.AssertStringOnLength(
						value,
						1000,
						"Info должен быть меньше 1000 символов.");
				_info = value;
			}
			get
			{
				return _info;
			}
		}

		/// <summary>
		/// Свойство для поля _cost.
		/// </summary>
		public double Cost
		{
			set
			{
				OOP.Services.ValueValidator.AssertValueInRange(
					value,
					0,
					100000,
					"Цена не может иметь данное значение. Ёе диапазон от 0 до 100000"
					);
				_cost = value;
			}
			get
			{
				return _cost;
			}
		}

		/// <summary>
		/// Конструктор без параметров.
		/// </summary>
		public Item()
		{
			this.Id = OOP.Services.IdGenerator.GetNextItemID();
		}

		/// <summary>
		/// Конструктор с параметрами.
		/// </summary>
		/// <param name="name">Имя товара.</param>
		/// <param name="info">Информация о товаре.</param>
		/// <param name="cost">Цена товара.</param>
		public Item(string name, string info, double cost)
		{
			this.Info = info;
			this.Name = name;
			this.Cost = cost;
			this.Id = OOP.Services.IdGenerator.GetNextItemID();
		}
	}
}
