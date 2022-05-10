using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Song {

        //歌のタイトル
        public string Title { get; set; }

        //アーティスト名
        public string ArtiseName { get; set; }

        //演奏時間（単位：秒）
        public int Length { get; set; }


        //引数付きコンストラクタ
        public Song(string title, string artiseName, int length) {
            Title = title;
            ArtiseName = artiseName;
            Length = length;
        }
    }
}
