namespace InternetAccessCalculation
{
    class StrCheckDecimal
    {
        public string CheckStrDecimal(string str, decimal dMax)
        {
            if (decimal.TryParse(str, out dMax))
            {
                return dMax.ToString();
            }
            return str;
        }
    }
}
