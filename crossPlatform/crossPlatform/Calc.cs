using System;

namespace crossPlatform
{
	public class Calc
	{
        public static double GetTax(double d)
        {
            return Math.Floor(d * 1.08);
        }
		
	}
}

