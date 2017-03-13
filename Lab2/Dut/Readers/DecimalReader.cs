using System;

namespace Lab2.Dut.Readers
{
    class DecimalReader : AbstractReader<decimal>
    {
        protected override bool Validate(string strValue, out decimal value)
        {
            return !Decimal.TryParse(strValue, out value);
        }
    }
}
