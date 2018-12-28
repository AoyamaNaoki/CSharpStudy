using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Practice4
{
    class pra4_12
    {
        public static void test() {
            Random rand = new Random();
            var guusuu = new List<int>();
            var kisuu = new List<int>();

            for(int i = 0; i < 5; i++){
                int num = rand.Next(1, 100);
                Console.WriteLine(num);
                if(num % 2 == 0){
                    guusuu.Add(num);
                }else{
                    kisuu.Add(num);
                }
            }
            Console.WriteLine("偶数の数：" + guusuu.Count());
            Console.WriteLine("奇数の数：" + kisuu.Count());
        }
    }
}
