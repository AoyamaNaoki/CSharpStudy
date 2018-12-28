using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice4
{
    class pra4_8
    {
        public static void test() {
            while (true){
                Console.WriteLine("0以上の数値を入力してください");
                int num = int.Parse(Console.ReadLine());
                if(num < 0){
                    Console.WriteLine("0未満を入力したため終了");
                    break;
                }
            }
        }
    }
}
