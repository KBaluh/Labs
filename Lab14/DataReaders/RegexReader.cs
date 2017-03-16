using System;
using System.Text.RegularExpressions;

namespace DataReaders
{
    public class RegexReader : AbstractReader<string>
    {
        private string _pattern;
        private string _errorMessage;

        public RegexReader(string pattern, string errorMessage = null)
        {
            _pattern = pattern;
            _errorMessage = errorMessage;
        }

        protected override bool Validate(string strValue, out string value)
        {
            Match match = Regex.Match(strValue, _pattern);
            if (match.Success)
            {
                value = match.Value.Replace("-", "");
            }
            else
            {
                value = string.Empty;
                if (!string.IsNullOrEmpty(_errorMessage))
                {
                    Console.WriteLine(_errorMessage);
                }
            }
            return match.Success;
        }
    }
}
