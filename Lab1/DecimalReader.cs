using System;

namespace Lab1
{
    class DecimalReader
    {
        public decimal Read(string text = null)
        {
            decimal result = 0;
            string strValue = string.Empty;
            do
            {
                Console.Write(text);
                strValue = Console.ReadLine();
            }
            while (!Decimal.TryParse(strValue, out result));
            return result;
        }
    }
}
