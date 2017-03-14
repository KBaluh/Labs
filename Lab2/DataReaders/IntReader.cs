namespace DataReaders
{
    public class IntReader : AbstractReader<int>
    {
        protected override bool Validate(string strValue, out int value)
        {
            return int.TryParse(strValue, out value);
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
            return false;
        }
    }
}
