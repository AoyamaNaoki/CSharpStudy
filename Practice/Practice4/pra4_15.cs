using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice4
{
    class pra4_15
    {
        public static void test() {
            for(int i = 1; i<= 100; i++){
                if(i % 10 == 0){
                    Console.WriteLine(i+" ");
                }else{
                    Console.Write(i + " ");
                }
            }
        }
    }
}
