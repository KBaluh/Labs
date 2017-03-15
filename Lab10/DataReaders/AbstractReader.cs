using System;

namespace DataReaders
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

        abstract protected bool Validate(string strValue, out T value);
    }
}
