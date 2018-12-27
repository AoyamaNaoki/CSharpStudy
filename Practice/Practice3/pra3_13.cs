using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice3
{
    class pra3_13
    {
        public static void test() {
            Console.WriteLine("1から3の値を入力");
            int num = int.Parse(Console.ReadLine());
            switch (num){
                case 1:
                    Console.WriteLine("グー");
                    break;
                case 2:
                    Console.WriteLine("チョキ");
                    break;
                case 3:
                    Console.WriteLine("パー");
                    break;
                default:
                    Console.WriteLine("正しい値ではありません");
                    break;
            }
        }
    }
}
