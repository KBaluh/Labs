using System;

namespace Lab2.Dut.Readers
{
    public abstract class AbstractReader<T>
    {
        public T Read(string text = null)
        {
            T result;
            string strValue = string.Empty;
            do
            {
                Console.Write(text);
                strValue = Console.ReadLine();
            }
            while (!Validate(strValue, out result));
            return result;
        }

        public T ReadRange(string formatText, int min, int max)
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

        abstract protected bool Validate(string strValue, out T value);
        abstract protected bool ValidateRange(string strValue, int min, int max, out T value);
    }
}
