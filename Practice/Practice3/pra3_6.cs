using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice3
{
    class pra3_6
    {
        public static void test() {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a={0} b={1}", a, b);
            if(a == b){
                Console.WriteLine("aはbと等しい");
            }else if(a > b){
                Console.WriteLine("aはbよりも大きい");
            }else if(a < b){
                Console.WriteLine("aはbよりも小さい");
                Console.WriteLine("aはbよりも小さい");
            }
        }
    }
}
