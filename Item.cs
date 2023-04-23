using System;

namespace OOP
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
		/// Счетчик ID.
		/// </summary>
		private static int _counterId = 0;

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
				if (value.Length > 0 && value.Length <= 1000)
				{
					_info = value;
				}
				else
				{
					throw new ArgumentException();
				}
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
				if (value > 0 && value <= 100000)
				{
					_cost = value;
				}
				else
				{
					throw new ArgumentException();
				}
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
			_counterId += 1;
			this.Id = _counterId;
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
			_counterId += 1;
			this.Id = _counterId;
		}
	}
}