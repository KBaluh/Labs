using System;

namespace DataReaders
{
    public class IntReader : RangeReader<int>
    {
        protected override bool Validate(string strValue, out int value)
        {
            bool result = int.TryParse(strValue, out value);
            if (!result)
            {
                Console.WriteLine("Введiть чiлочисельне число");
            }
            return result;
        }

        protected override bool ValidateRange(string strValue, int min, int max, out int value)
        {
            if (int.TryParse(strValue, out value))
            {
                if (value >= min && value <= max)
                {
                    return true;
                }
            }
            Console.WriteLine("Введіть чілочисельне число в межах вiд {0} до {1}", min, max);
            return false;
        }
    }
}
