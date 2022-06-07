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
    public partial class 計算アプリ : Form {
        public 計算アプリ() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            if (int.Parse(udNum2.Text) != 0) {
                //tbAns.Text = (int.Parse(tbNum1.Text) / int.Parse(tbNum2.Text)).ToString();
                //tbMod.Text = (int.Parse(tbNum1.Text) % int.Parse(tbNum2.Text)).ToString();
                udAns.Value = udNum1.Value / udNum2.Value;
                udMod.Value = udNum1.Value % udNum2.Value;
            }
            else {
                MessageBox.Show("0で割り算はできません。",
                 "エラー",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void 計算アプリ_Load(object sender, EventArgs e) {

        }
    }
}
