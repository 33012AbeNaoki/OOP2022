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
            new Song("CHRONICLE","Team Fortune",211),
            new Song("PREMIUM","Team Fortune",209),
            new Song("PLUS","Team Fortune",206),
            };
            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(Song[] songs) {

            foreach(var song in songs) {
                Console.WriteLine("{0},{1},{2:m\\:ss}", song.Title, song.ArtiseName, TimeSpan.FromSeconds(song.Length));

            }
        }
    }
}

