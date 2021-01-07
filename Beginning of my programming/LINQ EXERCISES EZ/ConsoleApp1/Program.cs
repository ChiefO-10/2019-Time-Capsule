using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 55, 200, 740, 76, 230, 482, 95 };
            //int N = 200;
            //string[] A = { "co", "dill", "ity", "zz","be","zz" }; // zrob najdluzszy wyraz z literami wystepujacymi tylko raz
            //string A ="apple";

            string[] A = { "ROME", "LONDON", "NAIROBI","nairObi", "CALIFORNIA", "ZURICH", "NEW DELHI","amsterdam", "AMSTERDAM", "ABU DHABI", "PARIS" };

            solution(A);

        }


        public static void solution(string[] A)
        {

            //var goodStrings = A.Where(x => x.Distinct().Count()  == x.Length).ToArray();
            //var result = A.Where(x => x % 2 == 0).ToArray();
            //var result = A.GroupBy(x => x)
            //var result = A.Select(x => new{ Name = x.Key,Count = x.Count()}).ToArray();
            //var result = A.GroupBy(x => x).Select(x => new{Number = x.Key,Times = x.Count(),Multi = x.Key * x.Count()}).ToArray();
            //Console.WriteLine( $"{i.Number} {i.Multi} {i.Times} " );
            //var result = A.Where(x => x.ToUpper().First() == 'A' && x.ToUpper().Last() == 'M').ToArray();
            //var result = A.OrderBy(x => x).Reverse().Take(5).ToArray();
            //var result = A.Where(x => String.Equals(x,x.ToUpper())).ToArray();
            //var result = A.Where(x => x.All(y => !Char.IsUpper(y) && Char.IsLetter(y))).ToArray();
            //var result = A.Where(x => x.Any(y => !Char.IsUpper(y) && Char.IsLetter(y))).ToArray();


            

            //foreach (var i in result)
            //{
            //    Console.WriteLine( $" {i} " );
            //}

            return;
        }

    }

}


