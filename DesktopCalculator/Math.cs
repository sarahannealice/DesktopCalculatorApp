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

        //method for addition
        public static string Sum(double rightNum, double leftNum)
        {
            tempX = leftNum + rightNum;
            return tempX.ToString();
        }

        //method for substraction
        public static string Difference(double rightNum, double leftNum)
        {
            tempX = rightNum - leftNum;
            return tempX.ToString();
        }

        //method for multiplication 
        public static string Product(double rightNum, double leftNum)
        {
            tempX = rightNum * leftNum;
            return tempX.ToString();
        }

        //method for division
        public static string Quotient(double rightNum, double leftNum)
        {
            //can't divide by zero -- https://www.math.utah.edu/~pa/math/0by0.html
            if (leftNum == 0)
            {
                return "NaN";
            } else
            {
                tempX = rightNum / leftNum;
                return tempX.ToString();
            }
        }

    }
}
