using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice4
{
    class pra4_11
    {
        public static void test() {
            var list = new List<int>();
            Random rand = new Random();
            for(int i = 0; i< 5; i++){
                int num = rand.Next(1, 100);
                list.Add(num);
                Console.WriteLine(num);
            }
            Console.Write("最大の値は");
            Console.WriteLine(list.Max());
            Console.Write("最小の値は");
            Console.WriteLine(list.Min());
        }
    }
}
