using System;

namespace DataReaders
{
    public class StrReader : AbstractReader<string>
    {
        protected override bool Validate(string strValue, out string value)
        {
            bool result = !string.IsNullOrEmpty(strValue);
            if (!result)
            {
                Console.WriteLine("Строка не повинна бути пустою");
            }
            value = strValue;
            return result;
        }
    }
}
