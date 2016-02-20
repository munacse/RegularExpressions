using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex objNotNaturalPattern = new Regex("[0-9]");
            string str1 = "abcd";
            bool flag = objNotNaturalPattern.IsMatch(str1);
        }
    }
}
