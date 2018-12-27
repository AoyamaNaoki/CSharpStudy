using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice3
{
    class pra3_7
    {
        public static void test() {
            Console.WriteLine("文字を入力してください");
            int num = int.Parse(Console.ReadLine());
            if(num % 2 == 0){
                Console.WriteLine("偶数です");
            }
            else{
                Console.WriteLine("奇数です");
            }
        }
    }
}
