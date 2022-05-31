using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {

            int spase = text.Count(c => c == ' ');
            Console.WriteLine("空白数：{0}",spase);

            //Console.WriteLine(text.Count(t => t ==  ' '));
        }

        private static void Exercise3_2(string text) {

            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
            
            //Console.WriteLine(text.Replace("big", "small"));
        }

        private static void Exercise3_3(string text) {

            int count = text.Split(' ').Length;
            Console.WriteLine("単語数：{0}",count);

            //String[] words = text.Split(' ');
            //Console.WriteLine("単語の数：" + words.Count());
        }

        private static void Exercise3_4(string text) {

            text.Split(' ').Where(word => word.Length <= 4).ToList().ForEach(word => Console.WriteLine(word));

           //var s = text.Split(' ').Where(word => word.Length <= 4);

           // foreach (var item in s) {
           //     Console.WriteLine(item);
           // }

            //var words = text.Split(' ').Where(w => w.Length <= 4);

            //foreach (var word in words) {
                //Console.WriteLine(word);
            //}
        }

        private static void Exercise3_5(string text) {

            var array = text.Split(' ').ToArray();
            if (array.Length >0) {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1)) {
                    
                    sb.Append(' ');
                    sb.Append(word);
                }
                var str = sb.ToString();
                Console.WriteLine(text);
            }




        }
    }
}
