using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Console.Write("１つ目を入力：");
            var inputString1 = Console.ReadLine();
            Console.Write("２つ目を入力：");
            var inputString2 = Console.ReadLine();
           
            if (string.Compare(inputString1, inputString2, ignoreCase: true)==0) {
                Console.WriteLine("等しい");
            }
            else {
                Console.WriteLine("等しくない");
            }

        }
    }
}
