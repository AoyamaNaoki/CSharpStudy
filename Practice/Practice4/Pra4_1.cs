using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice4 {
    class pra4_1 {
        public static void test() {
            Console.WriteLine("整数値を入力してください");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write("■");
            }
        }
    }
}