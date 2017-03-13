namespace Lab2.Dut.Readers
{
    class DecimalReader : AbstractReader<decimal>
    {
        protected override bool Validate(string strValue, out decimal value)
        {
            return decimal.TryParse(strValue, out value);
        }

        protected override bool ValidateRange(string strValue, int min, int max, out decimal value)
        {
            if (decimal.TryParse(strValue, out value))
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
