﻿using System;

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

        abstract protected bool Validate(string strValue, out T value);
        abstract protected bool ValidateRange(string strValue, T min, T max, out T value);
    }
}
