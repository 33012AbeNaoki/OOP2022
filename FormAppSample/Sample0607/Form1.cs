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
        public Form1() {
            InitializeComponent();
        }
        private void btRondom_Click(object sender, EventArgs e) {

           var r = new Random();

            number.Value = r.Next(6);

            
        }
    }
}
