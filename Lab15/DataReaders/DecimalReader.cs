using System;

namespace DataReaders
{
    class DecimalReader : RangeReader<decimal>
    {
        protected override bool Validate(string strValue, out decimal value)
        {
            bool result = decimal.TryParse(strValue, out value);
            if (!result)
            {
                Console.WriteLine("Введiть число");
            }
            return result;
        }

        protected override bool ValidateRange(string strValue, decimal min, decimal max, out decimal value)
        {
            if (decimal.TryParse(strValue, out value))
            {
                if (value >= min && value <= max)
                {
                    return true;
                }
            }
            Console.WriteLine("Введіть число в межах вiд {0} до {1}", min, max);
            return false;
        }
    }
}
