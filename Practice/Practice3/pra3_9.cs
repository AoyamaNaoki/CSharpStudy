using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice3
{
    class pra3_9
    {
        public static void test() {
            Console.WriteLine("文字を入力してください");
            String str = Console.ReadLine();
            if(str == "abc"){
                Console.WriteLine("abcです");
            }
            else{
                Console.WriteLine("abcではありません"); 
            }
        }
    }
}
