using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice3
{
    class pra3_2
    {
        public static void test() {
            Console.WriteLine("整数を入力してください");
            int i = int.Parse(Console.ReadLine());
            if(i != 4){
                Console.WriteLine("4ではありません");
            }
        }
    }
}
