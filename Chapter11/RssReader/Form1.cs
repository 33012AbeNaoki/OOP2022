using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        IEnumerable<string> xTitle,xLink;

        public Form1() {
            InitializeComponent();
        }

        private void btRssget_Click(object sender, EventArgs e) {

           

           using (var wc = new WebClient()) {

                var stream = wc.OpenRead(cbRssurl.Text);

                var xdoc = XDocument.Load(stream);
                xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));
                xLink = xdoc.Root.Descendants("item").Select(x => (string)x.Element("link"));

                foreach (var data in xTitle) {

                    lbRsstitle.Items.Add(data);
                }
           }
        }

        private void lbRsstitle_SelectedIndexChanged(object sender, EventArgs e) {

            int index = lbRsstitle.SelectedIndex;  //選択した個所のインデックスを取得（0～）


        }
    }
}
