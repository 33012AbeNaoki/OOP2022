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

        IEnumerable<string> xTitle, xLink;

        public Form1() {
            InitializeComponent();
        }

        private void btRssget_Click(object sender, EventArgs e) {

            lbRsstitle.Items.Clear();

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

        private void btBack_Click(object sender, EventArgs e) {

            wvBrowser.GoBack();
        }

        private void btForward_Click(object sender, EventArgs e) {

            wvBrowser.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e) {
            BackForwardButtonMaskCheck();
        }



        private void wvBrowser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e) {

            BackForwardButtonMaskCheck();
        }
        //進む・戻るボタンのマスク設定
        private void BackForwardButtonMaskCheck() {
            btBack.Enabled = wvBrowser.CanGoBack;
            btForward.Enabled = wvBrowser.CanGoForward;
        }

        private void lbRsstitle_SelectedIndexChanged(object sender, EventArgs e) {

            int index = lbRsstitle.SelectedIndex;  //選択した個所のインデックスを取得（0～）

            if (index == -1) {
                return;
            }

            var url = xLink.ElementAt(index);

            //wbBrowser.Navigate(url);
            wvBrowser.Source = new Uri(url);

        }
    }
}