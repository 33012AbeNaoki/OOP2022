using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();

        }

        private static void Exercise1_2() {

            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.First(b => b.Price == max);

            Console.WriteLine(book);

        }

        private static void Exercise1_3() {

            var count = Library.Books.GroupBy(b => b.PublishedYear)
                .Select(s => new { Publishedyear = s.Key, Count = s.Count() })
                .OrderBy(o => o.Publishedyear);

            foreach (var s in count) {

                Console.WriteLine("{0}年 {1}冊", s.Publishedyear, s.Count);
            }

        }

        private static void Exercise1_4() {

            var rank = Library.Books
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => new {
                    book.Title,
                    book.PublishedYear,
                    book.Price,
                    CategoryName = category.Name
                })
                .OrderByDescending(x => x.PublishedYear)
                .ThenByDescending(x => x.Price);

            foreach (var item in rank) {

                Console.WriteLine("{0}年{1}円 {2} ({3})", item.PublishedYear, item.Price, item.Title, item.CategoryName);

            }
        
        }

        private static void Exercise1_5() {
        
        }

        private static void Exercise1_6() {
        
        }

        private static void Exercise1_7() {
        
        }

        private static void Exercise1_8() {
        
        }
    }
}
