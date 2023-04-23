using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Services
{
    public static class ValueValidator
    {
        /// <summary>
        /// Проверка, что строка не превышает лимит кол-ва символов.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимальная длина.</param>
        /// <param name="propertyName">Текст ошибки.</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(propertyName);
            }
        }


        /// <summary>
        /// Проверка, что значение не превышает диапазон значений.
        /// </summary>
        /// <param name="value">Передаваемое значение.</param>
        /// <param name="minValue">Минимальное значение.</param>
        /// <param name="maxValue">Максимальное значение.</param>
        /// <param name="propertyName">Текст ошибки.</param>
        public static void AssertValueInRange(double value,
            double minValue, 
            double maxValue, 
            string propertyName)
        {
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentException(propertyName);
            }
        }
    }
}
