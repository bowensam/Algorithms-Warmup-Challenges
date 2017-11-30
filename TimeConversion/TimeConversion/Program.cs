using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
        }

        static string timeConversion(string s)
        {
            // Complete this function
            Program p = new Program();
            char[] timeArray = s.ToCharArray();

            if ((!(p.combineChar(timeArray[0], timeArray[1])).Equals("12")) && (timeArray[8].Equals('P')))
            { //N.B.: C# use ', not "
                String hour = p.combineChar(timeArray[0], timeArray[1]);
                String adjustedhour = (Convert.ToInt32(hour) + 12).ToString();

                timeArray[0] = adjustedhour[0];
                timeArray[1] = adjustedhour[1];
            }
            if (((p.combineChar(timeArray[0], timeArray[1])).Equals("12")) && (timeArray[8].Equals('A')))
            {
                timeArray[0] = '0';
                timeArray[1] = '0';
            }
            return "" + timeArray[0] + timeArray[1] + timeArray[2] + timeArray[3] + timeArray[4] + timeArray[5] + timeArray[6] + timeArray[7];
        }

        private String combineChar(char c1, char c2)
        {
            char[] charArray = { c1, c2 };

            return new String(charArray);
        }
    }
}
