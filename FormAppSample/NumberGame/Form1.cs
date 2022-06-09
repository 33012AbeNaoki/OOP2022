using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {

        private Random rand = new Random();//乱数オブジェクト生成

        private int randomnumber;

        public Form1() {
            InitializeComponent();
        }
        //アプリケーション起動時に一度だけ実行されるイベントハンドラ
        private void Form1_Load(object sender, EventArgs e) {

            //乱数取得
            getRandom();//乱数取得
           
        }

        //判定ボタンイベントハンドラ
        private void inNum_Click(object sender, EventArgs e) {

            //入力した数値とあらかじめ取得した乱数を比較し結果を表示

            if (randomnumber == number.Value) {
                tbRes.Text = "正解";
            }
            else if (randomnumber > number.Value) {
                tbRes.Text = "入力値より小さい";
            }
            else if (randomnumber < number.Value) {
                tbRes.Text = "入力値より大きい";

            }
        }
        private void maxNum_ValieChengd(object sender,EventArgs e) {
            getRandom();
        }

        private void getRandom() {
            randomnumber = rand.Next(1, (int)maxNum.Value);
        }
    }
}
