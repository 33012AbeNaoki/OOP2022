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

            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            //Exercise1_4(file, newfile);
            //確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
        }

        private static void Exercise1_1(string file) {

            var xdoc = XDocument.Load(file);

            var sports = xdoc.Root.Elements().Select(x => new {
                Name = (string)x.Element("name").Value,
                Team = x.Element("teammembers").Value
            });

            foreach (var sport in sports) {

                Console.WriteLine("{0} {1}", sport.Name, sport.Team);

            }
        }

        private static void Exercise1_2(string file) {

            var xdoc = XDocument.Load(file);

            var sports = xdoc.Root.Elements().Select(x => new {
                Name = x.Element("name").Attribute("kanji").Value,
                FirstPlay = x.Element("firstplayed").Value,
            }).OrderBy(x =>int.Parse(x.FirstPlay));

            foreach (var sport in sports) {

                Console.WriteLine("{0} {1}", sport.Name, sport.FirstPlay);
            }
        }

        private static void Exercise1_3(string file) {

            var xdoc = XDocument.Load(file);

            var sport= xdoc.Root.Elements().Select(x => new {
                Name = x.Element("name").Value,
                Teammember = x.Element("teammembers").Value,
            }).OrderByDescending(x =>int.Parse(x.Teammember)).First();

            Console.WriteLine("{0} ({1}人)",sport.Name,sport.Teammember);

        }

        private static void Exercise1_4(string file, string newfile) {

            var xdoc = XElement.Load(file);

            var element = new XElement("ballsport",
                new XElement("name", "サッカー", new XAttribute("kana", "蹴球")),
                new XElement("teammembers", "11"),
                new XElement("birth", "1873"));

            xdoc.Add(element);

            //  保存
            xdoc.Save(newfile);

            

        }
    }
}