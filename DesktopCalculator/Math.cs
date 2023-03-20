using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopCalculator
{
    internal class Math
    {
        private static double tempX;

        public static string Sum(double rightNum, double leftNum)
        {
            tempX = leftNum + rightNum;
            return tempX.ToString();

            //if 
        }

        public static string Difference(double leftNum, double rightNum)
        {
            tempX = leftNum - rightNum;
            return tempX.ToString();
        }

    }
}
