using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string v)
        {
            v.Split(",");
            if (v == "")
            {
                return 0;
            }

            return int.Parse(v);
                        
        }
    }
}
