using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Services
{
    /// <summary>
    /// Сервисный класс для генерации Id.
    /// </summary>
    static class IdGenerator
    {
        /// <summary>
        /// Id товара.
        /// </summary>
        static private int _idItem = 0;

        /// <summary>
        /// Id пользователя.
        /// </summary>
        static private int _idCustomer = 0;

        /// <summary>
        /// Метод Id товара.
        /// </summary>
        /// <returns> Возвращает Id товара.</returns>
        public static int GetNextItemID()
        {
            _idItem += 1;
            return _idItem; 
        }

        /// <summary>
        /// Метод Id пользователя.
        /// </summary>
        /// <returns> Возвращает Id пользователя.</returns>
        public static int GetNextCustomerID()
        {
            _idCustomer += 1;
            return _idCustomer;
        }
    }
}
