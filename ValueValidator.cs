using System;

namespace OOP
{
    public static class ValueValidator
    {
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(propertyName);
            }
        }
    }
}