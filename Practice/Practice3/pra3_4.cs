using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice3
{
    class pra3_4
    {
        public static void test() {
            Console.WriteLine("整数を入力してください");
            int i = int.Parse(Console.ReadLine());
            if (i <= 20 || i >= 80)
            {
                Console.WriteLine("20以下か80以上の値です");
            }
        }
    }
}
