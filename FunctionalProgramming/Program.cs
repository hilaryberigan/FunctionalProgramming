using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class Program
    {

        static void Main()
        {
            Func<string, int> foo;
            foo = ReturnAverage;
            Console.WriteLine(foo("90,100,82,89,55"));
            Func<string, string> foo2;
            foo2 = ReturnOrderedNumberedString;
            Console.WriteLine(foo2("mynameishilaryandiamdoingwell"));

            Console.ReadLine();
        }

        public static int ReturnAverage(string item)
        {
            int average = Convert.ToInt32
                (
                    item.Split(',')
                    .Select(int.Parse)
                    .ToArray()
                    .OrderBy(grade => grade)
                    .Skip(3)
                    .Average(grade => grade)
                );

            return average;
        }

        public static string ReturnOrderedNumberedString(string item)
        {
            string final = 
                string.Join
                (
                    "", 
                    string.Join(",", item.ToCharArray())
                    .Split(',')
                    .ToArray()
                    .OrderBy(a => a)
                    .GroupBy(s => s)
                    .Select
                    (group => 
                        (group.Key.ToUpper()) + "" + Convert.ToString(group.Count())
                    )                    
                );

            return final;
        }

        public static 
    }

}      


       
       
            
       
    

