using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice3
{
    class pra3_8
    {
        public static void test() {
            Console.WriteLine("文字を入力してください");
            int num = int.Parse(Console.ReadLine());
            if(num == 1){
                Console.WriteLine("春です");
            }else if(num == 2){
                Console.WriteLine("夏です");
            }else if(num == 3){
                Console.WriteLine("秋です");
            }else if(num == 4){
                Console.WriteLine("冬です");
            }else{
                Console.WriteLine("エラーです");
            }
        }
    }
}