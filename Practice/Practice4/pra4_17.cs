using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice4
{
    class pra4_17
    {
        public static void test() {
            /*  n-- は基本的に使わないことが多い
            for(int i = 1; i <= 9; i++){
                Console.Write("■");
                for(int n = 9; n >=1; n--){
                    Console.Write("□");
                }
                Console.WriteLine("");
            }
            */
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    if ((i+j) % 3 ==0)
                    {
                        Console.Write("□");
                    }
                    else
                    {
                        Console.Write("■");
                    }
                }
                Console.WriteLine("");
            }
            //1-1,1-2,1-3,1-4....2-1,2-2,2-3,2-4...2-10......3-1,3-2....
        }
    }
}
