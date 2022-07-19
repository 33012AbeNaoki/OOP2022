using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //設定情報
        Settings settings = new Settings();

        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();

            dgvArticle.DataSource = listCarReport;
        }

        private void button1_Click(object sender, EventArgs e) {


            Application.Exit();
        }
        private void btReportinput_Click(object sender, EventArgs e) { //追加ボタン

            if (String.IsNullOrWhiteSpace(cbReporterName.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            CarReport newPersons = new CarReport {

                Date = dtDate.Value,
                Auther = cbReporterName.Text,
                Maker = GetRadioButtonKindNumber(),
                CarName = cbCarname.Text,
                Report = tbReport.Text,
                Picture = pictureBox.Image,

            };

            listCarReport.Add(newPersons);

            dgvArticle.Rows[dgvArticle.RowCount - 1].Selected = true;

        }


        private CarReport.MakerGroup GetRadioButtonKindNumber() {
            var selectedmaker = CarReport.MakerGroup.その他;
            if (rbToyota.Checked) {
                selectedmaker = CarReport.MakerGroup.トヨタ;
            }
            if (rbNissan.Checked) {
                selectedmaker = CarReport.MakerGroup.日産;
            }
            if (rbHonda.Checked) {
                selectedmaker = CarReport.MakerGroup.ホンダ;
            }
            if (rbSubaru.Checked) {
                selectedmaker = CarReport.MakerGroup.スバル;
            }
            if (rbOutsidecar.Checked) {
                selectedmaker = CarReport.MakerGroup.外国車;

            }

            return selectedmaker;
        }
        private void dgvPersons_Click(object sender, EventArgs e) {

            if (dgvArticle.CurrentRow == null) return;

            int index = dgvArticle.CurrentRow.Index;
            //例
            //データグリッドビューのインデックス〇番目の名前をテキストボックスに格納
            cbReporterName.Text = listCarReport[index].Auther;
            cbCarname.Text = listCarReport[index].CarName;
            tbReport.Text = listCarReport[index].Report;
            pictureBox.Image = listCarReport[index].Picture;
            dtDate.Value = listCarReport[index].Date.Year > 1900 ?
                listCarReport[index].Date : DateTime.Today;

            GetRadioButtonKindNumber(index);
        }

        private void GetRadioButtonKindNumber(int index) {
            switch (listCarReport[index].Maker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbOutsidecar.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;

                default:
                    break;
            }
        }
        private void setCBReporterName(string report) {

            if (!cbReporterName.Items.Contains(report)) {

                //まだ登録されていなければ登録処理
                cbReporterName.Items.Add(report);
            }
        }
        private void setCBCarName(string report2) {

            if (!cbCarname.Items.Contains(report2)) {

                cbCarname.Items.Add(report2);
            }
        }


        private void btPictureopen_Click(object sender, EventArgs e) {

            if (openFileDialog.ShowDialog() == DialogResult.OK) {

                pictureBox.Image = Image.FromFile(openFileDialog.FileName);

            }
        }
        private void btPicturedel_Click(object sender, EventArgs e) {

            pictureBox.Image = null;
        }

        private void btReportcorrect_Click(object sender, EventArgs e) {

            listCarReport[dgvArticle.CurrentRow.Index].Auther = cbReporterName.Text;
            listCarReport[dgvArticle.CurrentRow.Index].Maker = GetRadioButtonKindNumber();
            listCarReport[dgvArticle.CurrentRow.Index].CarName = cbCarname.Text;
            listCarReport[dgvArticle.CurrentRow.Index].Report = tbReport.Text;
            listCarReport[dgvArticle.CurrentRow.Index].Picture = pictureBox.Image;
            listCarReport[dgvArticle.CurrentRow.Index].Date = dtDate.Value;


            dgvArticle.Refresh();//データグリッドビュー更新
        }

        private void btDel_Click(object sender, EventArgs e) {

            listCarReport.RemoveAt(dgvArticle.CurrentRow.Index);
        }

        private void btSave_Click(object sender, EventArgs e) {



            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {


                try {
                    //バイナリー形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(saveFileDialog1.FileName, FileMode.Create)) {

                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void cbColorSelect_Click(object sender, EventArgs e) {

            if (cdColorSelect.ShowDialog() == DialogResult.OK) {

                BackColor = cdColorSelect.Color;
                settings.MainFormColor = cdColorSelect.Color;//設定
            }
        }

        private void btOpen_Click_1(object sender, EventArgs e) {

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {

                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read)) {

                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvArticle.DataSource = null;
                        dgvArticle.DataSource = listCarReport;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbCarname.Items.Clear();//コンボボックスのアイテム削除
                cbReporterName.Items.Clear();
                //コンボボックス登録
                foreach (var item in listCarReport.Select(p => p.Auther)) {

                    setCBCarName(item);//存在する会社を登録
                }
                foreach (var item in listCarReport.Select(p => p.CarName)) {

                    setCBReporterName(item);

                }
            }

        }
        private void Form1_FormClosed(object sender, EventArgs e) { 

            //設定ファイルをシリア

            using (var writer= XmlWriter.Create("setting.xml")) {

                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer,settings);

            }
        }


        private void Form1_Load(object sender, EventArgs e) {

            //設定ファイルを逆シリアル化

            using (var reader = XmlReader.Create(new StringReader("setting.xml"))) {

                var serializer = new XmlSerializer(typeof(Settings));
                settings = serializer.Deserialize(reader) as Settings;

            }

        }
    }
}


