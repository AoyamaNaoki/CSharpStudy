using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice4
{
    class pra4_14{
        public static void test() {
            Random rand = new Random();
            int num = rand.Next(1, 10);
            if(num % 2 == 0){
                Console.WriteLine("偶数です");
                for(int i = 0; i < num; i++) { 
                Console.Write("★");
                }
            }else{
                Console.WriteLine("奇数です");
                for(int i = 0; i< num; i++){
                    Console.Write("☆");
                }
            }
        }
    }
}
