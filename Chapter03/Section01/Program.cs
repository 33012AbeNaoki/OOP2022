using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
       

        static void Main(string[] args) {

            var list = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            var exists = list.Exists(s => s[0] == 'A');
            Console.WriteLine(exists);
            //foreach (var s in names) {

              //  Console.WriteLine(s);
            //}

            //var name = list.Exists(s => s.Length == 6);
            //Console.WriteLine(exists);
        }

    }
}
