using System;

namespace DataReaders
{
    public class ConsoleReader
    {
        private StrReader strReader;
        private IntReader intReader;
        private DecimalReader decimalReader;
        private DateReader dateReader;

        public ConsoleReader()
        {
            strReader = new StrReader();
            intReader = new IntReader();
            decimalReader = new DecimalReader();
            dateReader = new DateReader();
        }

        public decimal ReadDecimal(string text = null)
        {
            return decimalReader.Read(text);
        }

        public decimal ReadDecimalRange(string text, int min, int max)
        {
            return decimalReader.ReadRange(text, min, max);
        }

        public int ReadInt(string text = null)
        {
            return intReader.Read(text);
        }

        public int ReadIntRange(string text, int min, int max)
        {
            return intReader.ReadRange(text, min, max);
        }

        public string ReadStr(string text = null)
        {
            return strReader.Read(text);
        }

        public DateTime ReadDate(string text = null)
        {
            return dateReader.Read(text);
        }

        public string RegStr(string pattern, string text, string error = null)
        {
            RegexReader reader = new RegexReader(pattern, error);
            return reader.Read(text);
        }
    }
}
