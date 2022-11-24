using Newtonsoft.Json;
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

namespace WeatherApp {
    public partial class Form1 : Form {

        public string weathercode1;
        public string weathercode2;
        public string weathercode3;

        public string url = "https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json";
        public string url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json";
        public string urlp = "https://www.jma.go.jp/bosai/weather_map/data/list.json";

        public Form1() {
            InitializeComponent();

            cbSelect.SelectedItem = "群馬県";
        }

        private void btWeatherGET_Click(object sender, EventArgs e) {

            if (cbSelect.SelectedItem == null) {
                MessageBox.Show("地域を選択してください。地域が選択されていない場合は、" +
                    "宗谷地方の情報を表示します。"
                    , "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else {
                URLSelect();

            }

            var wc = new WebClient() {

                Encoding = Encoding.UTF8
            };
            try {
                var dString = wc.DownloadString(url);
                var json = JsonConvert.DeserializeObject<Class1[]>(dString);

                var dString2 = wc.DownloadString(url2);
                var json2 = JsonConvert.DeserializeObject<Rootobject_t>(dString2);

                var dStringp = wc.DownloadString(urlp);
                var jsonp = JsonConvert.DeserializeObject<Rootobject_p>(dStringp);


                Weather_info(json, json2, jsonp);
            }
            catch (Exception) {

                MessageBox.Show("ネットワークに接続してください。","エラー",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
           

        }

        private void Weather_info(Class1[] json, Rootobject_t json2, Rootobject_p jsonp) {
            try {
                
                lbdate.Text = json[0].reportDatetime.ToString();
                lbtoday.Text = json[0].timeSeries[0].areas[0].weathers[0];
                lbtomo.Text = json[0].timeSeries[0].areas[0].weathers[1];
                lbtomo2.Text =json[0].timeSeries[0].areas[0].weathers[2];
                lb1.Text = json[0].timeSeries[2].areas[0].temps[0];
                lb2.Text = json[0].timeSeries[2].areas[0].temps[2];
                lb3.Text = json[0].timeSeries[2].areas[0].temps[3];
                lb4.Text = json[1].timeSeries[1].areas[0].tempsMin[1];
                lb5.Text = json[1].timeSeries[1].areas[0].tempsMax[1];
                tbGaikyou.Text = json2.text;
                lb0.Text = "-";

                weathercode1 = json[0].timeSeries[0].areas[0].weatherCodes[0];
                weathercode2 = json[0].timeSeries[0].areas[0].weatherCodes[1];
                weathercode3 = json[0].timeSeries[0].areas[0].weatherCodes[2];

                pb1.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + weathercode1 + ".png";
                pb2.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + weathercode2 + ".png";
                pb3.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + weathercode3 + ".png";

               
            }
            catch (Exception) {

                lbdate.Text = json[0].reportDatetime.ToString();
                lbtoday.Text = json[0].timeSeries[0].areas[0].weathers[0];
                lbtomo.Text = json[0].timeSeries[0].areas[0].weathers[1];
                lbtomo2.Text = "情報なし";
                lb0.Text = "-";
                lb1.Text = json[0].timeSeries[2].areas[0].temps[0];
                lb2.Text = json[0].timeSeries[2].areas[0].temps[2];
                lb3.Text = json[0].timeSeries[2].areas[0].temps[3];
                lb4.Text = json[1].timeSeries[1].areas[0].tempsMin[1];
                lb5.Text = json[1].timeSeries[1].areas[0].tempsMax[1];
                tbGaikyou.Text = json2.text;

                weathercode1 = json[0].timeSeries[0].areas[0].weatherCodes[0];
                weathercode2 = json[0].timeSeries[0].areas[0].weatherCodes[1];
                weathercode3 = json[0].timeSeries[0].areas[0].weatherCodes[2];

                pb1.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + weathercode1 + ".png";
                pb2.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + weathercode2 + ".png";
                pb3.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + weathercode3 + ".png";
            }
        }

    



        private void URLSelect() {


            if (cbSelect.SelectedItem.ToString() == "宗谷地方") {

                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "上川・留萌地方") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/012000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/012000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "網走・北見・紋別地方") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/013000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "釧路・根室地方") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/014100.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014100.json";
            }
            if (cbSelect.SelectedItem.ToString() == "胆振・日高地方") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/015000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/015000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "石狩・空知・後志地方") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/016000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/016000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "渡島・檜山地方") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/017000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/017000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "青森県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/020000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "岩手県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/030000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/030000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "宮城県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/040000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/040000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "秋田県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/050000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/050000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "山形県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/060000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/060000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "福島県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/070000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/070000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "茨城県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/080000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/080000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "栃木県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/090000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "群馬県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "埼玉県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/110000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/110000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "千葉県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/120000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/120000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "東京都") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "神奈川県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/140000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/140000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "山梨県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/190000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/190000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "長野県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/200000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/200000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "岐阜県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/210000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/210000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "静岡県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/220000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/220000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "愛知県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/230000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/230000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "三重県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/240000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/240000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "新潟県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/150000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/150000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "富山県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/170000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/170000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "福井県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/180000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/180000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "滋賀県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/250000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/250000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "京都府") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/260000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/260000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "大阪府") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/270000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/270000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "兵庫県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/280000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/280000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "奈良県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/290000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/290000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "和歌山県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/300000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/300000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "鳥取県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/310000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/310000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "島根県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/320000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/320000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "岡山県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/330000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/330000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "広島県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/340000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/340000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "徳島県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/360000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/360000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "香川県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/370000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/370000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "愛媛県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/380000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/380000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "高知県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/390000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/390000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "山口県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/350000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/350000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "福岡県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/400000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/400000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "佐賀県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/410000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/410000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "長崎県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/420000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/420000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "熊本県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/430000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/430000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "大分県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/440000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/440000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "宮崎県") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/450000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/450000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "奄美地方") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/460040.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460040.json";
            }
            if (cbSelect.SelectedItem.ToString() == "鹿児島県（奄美地方除く）") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/460100.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460100.json";
            }
            if (cbSelect.SelectedItem.ToString() == "沖縄本島地方") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/471000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/471000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "大東島地方") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/472000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/472000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "宮古島地方") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/473000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/473000.json";
            }
            if (cbSelect.SelectedItem.ToString() == "八重山地方") {
                url = "https://www.jma.go.jp/bosai/forecast/data/forecast/474000.json";
                url2 = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/474000.json";
            }
        }

        
    }
}

