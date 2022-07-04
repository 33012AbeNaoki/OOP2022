using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {

            var xdoc = XDocument.Load("Sample.xml");

            var samples = xdoc.Root.Elements().Select(x => new {
                Name = (string)x.Element("name"),
                Team = x.Element("teammembers")
            });

            foreach (var sample in samples) {

                Console.WriteLine("{0} {1}",sample.Name,sample.Team.Value);

            }
        }

        private static void Exercise1_2(string file) {

            var xdoc = XDocument.Load("Sample.xml");

            var samples = xdoc.Root.Elements().Select(x => new {
               NameKanji = x.Element("name").Attribute("kanji").Value,
                FirstPlay = x.Element("firstplayed"),
            }).OrderBy(x => int.Parse((string)x.FirstPlay));

            foreach (var sample in samples) {

                Console.WriteLine("{0} {1}",sample.NameKanji ,sample.FirstPlay.Value);
            }
        }

        private static void Exercise1_3(string file) {

            var xdoc = XDocument.Load("Sample.xml");

            var samples = xdoc.Root.Elements().Select(x => new {
                Name = x.Element("name"),
                Teammember = x.Element("teammembers"),
            });
        }

        private static void Exercise1_4(string file, string newfile) {
            
        }
    }
}
