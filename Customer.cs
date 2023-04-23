using System;

namespace OOP
{
	public class Customer
	{
		/// <summary>
		/// Хранит Id пользователя.
		/// </summary>
		private int _id;

		/// <summary>
		/// Хранит имя пользователя.
		/// </summary>
		private string _fullName;

		/// <summary>
		/// Хранит адрес пользователя.
		/// </summary>
		private string _address;

		/// <summary>
		/// Свойство поля _id.
		/// </summary>
		public int Id { get; private set; }

		/// <summary>
		/// Свойство поля _fullName.
		/// </summary>
		public string FullName
		{
			set
			{
				if (value.Length > 0 && value.Length <= 200)
				{
					_fullName = value;
				}
				else
				{
					throw new ArgumentException();
				}
			}
			get
			{
				return _fullName;
			}
		}

		/// <summary>
		/// Свойство поля _address.
		/// </summary>
		public string Address
		{
			set
			{
				if (value.Length > 0 && value.Length <= 500)
				{
					_address = value;
				}
				else
				{
					throw new ArgumentException();
				}
			}
			get
			{
				return _address;
			}
		}
		/// <summary>
		/// Конструктор без параметров.
		/// </summary>
		public Customer()
		{

		}

		/// <summary>
		/// Конструктор класса с параметрами.
		/// </summary>
		/// <param name="fullName"> Имя пользователя.</param>
		/// <param name="address">Адрес пользователя.</param>
		public Customer(string fullName, string address)
		{
			this.FullName = fullName;
			this.Address = address;
		}
	}
}
