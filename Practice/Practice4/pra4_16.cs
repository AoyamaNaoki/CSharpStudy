using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice4
{
    class pra4_16
    {
        public static void test() {
            for (int i = 1; i <= 9; i++){
                for(int n = 1; n <= 9; n++){
                    if(n == 9){
                        Console.WriteLine(i + "*" + n + "=" + i * n + "  ");
                    }else{
                        Console.Write(i + "*" + n + "=" + i * n + "  ");
                    }
                }
            }
        }
    }
}
