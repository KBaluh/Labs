namespace StringCheck
{
    class StrCheckInt
    {        
        public string CheckStrInt(string str, int dMax)
        {
            if (int.TryParse(str, out dMax))
            {
                return dMax.ToString();
            }
            return str;
        }
    }
}
