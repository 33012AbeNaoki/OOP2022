using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {

        Random rand = new Random();//乱数

        public Form1() {
            InitializeComponent();
        }
        private void btRondom_Click(object sender, EventArgs e) {

            //number.Value = rand.Next(minValue:1,maxValue:7); 1～6の乱数

            number.Value = rand.Next(minValue:(int)udMin.Value,maxValue:(int)udMax.Value);
        }
        //イベントハンドラ（起動時に一度だけ実行）
        private void Form_Loand(object sender, EventArgs e) { 
        
        }
    }
}
