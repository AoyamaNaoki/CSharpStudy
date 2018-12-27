using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice3
{
    class pra3_10
    {
        public static void test() {
            Console.WriteLine("文字列1を入力");
            String str1 = Console.ReadLine();
            Console.WriteLine("文字列2を入力");
            String str2 = Console.ReadLine();
            if(str1 == str2){
                Console.WriteLine("2つの文字列は等しい");
            }else if (str1 != str2){
                Console.WriteLine("2つの文字列は等しくない");
            }
        }
    }
}
