using System;

namespace DataReaders
{
    public abstract class RangeReader<T> : AbstractReader<T>
    {
        public T ReadRange(string formatText, T min, T max)
        {
            T result;
            string strValue = string.Empty;
            do
            {
                Console.Write(formatText, min, max);
                strValue = Console.ReadLine();
            }
            while (!ValidateRange(strValue, min, max, out result));
            return result;
        }

        abstract protected bool ValidateRange(string strValue, T min, T max, out T value);
    }
}
