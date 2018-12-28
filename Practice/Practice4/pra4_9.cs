using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice4
{
    class pra4_9{
        public static void test() {
            Random rand = new Random();
            while (true) { 
            int num = rand.Next(1, 100);
                Console.WriteLine(num);
                if(num % 10 == 0){
                    break;
                }
            }
        }
    }
}
