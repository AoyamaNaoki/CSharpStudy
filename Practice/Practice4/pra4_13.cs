using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice4
{
    class pra4_13
    {
        public static void test() {
            Random rand = new Random();
            int num = rand.Next(1, 10);
            if(num >= 5){
                Console.WriteLine("発生した数値は" + num);
                for (int i = 0; i< num; i++){
                    Console.Write("★");
                }
            }else{
                Console.WriteLine("発生した数値は" + num);
                for(int i = 0; i< num; i++){
                    Console.Write("☆");
                }
            }
        }
    }
}
