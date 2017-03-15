using System;

namespace DataReaders
{
    public class DateReader : RangeReader<DateTime>
    {
        protected override bool Validate(string strValue, out DateTime value)
        {
            bool result = DateTime.TryParseExact(strValue, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out value);
            if (!result)
            {
                Console.WriteLine("Введiть дату в форматi дд.мм.рррр");
            }
            return result;
        }

        protected override bool ValidateRange(string strValue, DateTime min, DateTime max, out DateTime value)
        {
            if (Validate(strValue, out value))
            {
                if (value.Ticks >= min.Ticks && value.Ticks <= max.Ticks)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
