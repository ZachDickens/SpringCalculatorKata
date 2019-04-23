using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string v)
        {
            //v.Split(",");
            if (v == "")
            {
                return 0;
            }
            if (v.Contains(","))
            {
                
                var pieces = v.Split(",");
                var first = Convert.ToInt32(pieces[0]);
                var second = Convert.ToInt32(pieces[1]);
                return first + second;
            }
            return int.Parse(v);
                        
        }
    }
}
