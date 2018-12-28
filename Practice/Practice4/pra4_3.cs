using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice4 {
    class pra4_3 {
        public static void test() {
            Console.WriteLine("整数値を入力してください");
            int num = int.Parse(Console.ReadLine());
            do{
                Console.Write("■");
                num--;
            } while (num > 0);
        }
    }
}
