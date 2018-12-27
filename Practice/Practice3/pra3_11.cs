using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice3
{
    class pra3_11
    {
        public static void test() {
            Console.WriteLine("1から100までの数値を入力してください：");
            int num = int.Parse(Console.ReadLine());
            if(num >= 20 && num < 80){
                Console.WriteLine("20以上80未満です");
            }else if ((num < 20 && num >= 1) || (num >=80 && num <= 100)){
                Console.WriteLine("20未満か、80以上です");
            }
            else{
                Console.WriteLine("範囲外です");
            }
        }
    }
}
