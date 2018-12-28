using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice4
{
    class pra4_10{
        public static void test() {
            Random rand = new Random();
            
            for(int i=0; i <5; i++){
                int num = rand.Next(1, 100);
                Console.WriteLine(num);
            }
        }
    }
}
