using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice3
{
    class pra3_14
    {
        public static void test() {
            Console.WriteLine("a,bに1から10までの数値を入力してください");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if(num1 > 10 || num1 < 1 || num2 > 10 || num2 < 1){
                Console.WriteLine("範囲外です");
            }else if(num1 > num2){
                Console.WriteLine("num1のほうが大きいです");
            }else if(num1 < num2){
                Console.WriteLine("num2のほうが大きいです");
            }else{
                Console.WriteLine("等しいです");
            }
        }
    }
}
