using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {

            //2.1.3
            var songs = new Song[] {
            new Song("Let it be","The Beatles",243),
            new Song("CHRONICLE","Masato Okukai",211),
            new Song("PREMIUM","Masato Okukai",209),
            new Song("GRAND CROSS","Masato Okukai",200),
            };
            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(Song[] songs) { 

            foreach(var song in songs) {


            }
        }
    }
}

