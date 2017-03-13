using System;

namespace Lab2.Dut.Readers
{
    public class IntReader : AbstractReader<int>
    {
        protected override bool Validate(string strValue, out int value)
        {
            return !Int32.TryParse(strValue, out value);
        }
    }
}
