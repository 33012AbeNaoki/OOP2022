using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //設定情報保存用オブジェクト
        Settings settings = Settings.getInstance();

        
        public Form1() {
            InitializeComponent();
           
        }
        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            

        }

        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            //色設定ダイアログの表示
           
            if (cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;//背景色変更
                settings.MainFormColor = cdColorSelect.Color.ToArgb();  //設定オブジェクトへセット
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            ////設定ファイルをシリアル化（P305）
            //using (var writer = XmlWriter.Create("settings.xml")) {
            //    var serializer = new XmlSerializer(settings.GetType());
            //    serializer.Serialize(writer, settings);
            //}
        }

        private void Form1_Load(object sender, EventArgs e) {
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void btAddReport_Click(object sender, EventArgs e) {
            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(cbAuther.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }
            DataRow newRow = infosys202202DataSet.CarReportDB.NewRow();
            newRow[1] = dtpDate.Text;
            newRow[2] = cbAuther.Text;
            newRow[3] = GetRadioButtonMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbPicture.Image);
            //データセットへ新しいレコードを追加
            infosys202202DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202202DataSet.CarReportDB);


        }
        //設定されているメーカーを返す
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return CarReportSystem.CarReport.MakerGroup.トヨタ;
            }
            if (rbNissan.Checked) {
                return CarReportSystem.CarReport.MakerGroup.日産;
            }
            if (rbHonda.Checked) {
                return CarReportSystem.CarReport.MakerGroup.ホンダ;
            }
            if (rbSubaru.Checked) {
                return CarReportSystem.CarReport.MakerGroup.スバル;
            }
            if (rbImport.Checked) {
                return CarReportSystem.CarReport.MakerGroup.外国車;
            }

            return CarReportSystem.CarReport.MakerGroup.その他;
        }

    


     
        //コンボボックスに記録者を登録する（重複なし）
        private void setCbAuther(string company) {
            if (!cbAuther.Items.Contains(company)) {
                //まだ登録されていなければ登録処理
                cbAuther.Items.Add(company);
            }
        }
        //コンボボックスに車名を登録する（重複なし）
        private void setCbCarName(string company) {
            if (!cbCarName.Items.Contains(company)) {
                //まだ登録されていなければ登録処理
                cbCarName.Items.Add(company);
            }
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdCarReportOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdCarReportOpen.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

    


       

        private void Connection_Click(object sender, EventArgs e) {

            this.carReportDBTableAdapter.Fill(this.infosys202202DataSet.CarReportDB);
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }
 

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {

            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202202DataSet);
        }

        private void carReportDBDataGridView_Click(object sender, EventArgs e) {

            if (carReportDBDataGridView.CurrentRow == null)
                return;

            dtpDate.Text = carReportDBDataGridView.CurrentRow.Cells[1].Value.ToString();
            cbAuther.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
            GetRadioButtonMaker();
            cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();

        }

        private void btModifyReport_Click(object sender, EventArgs e) {


            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202202DataSet);
        }
        //エラー回避
        private void carReportDBDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void 更新_Click(object sender, EventArgs e) {

            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtpDate.Text;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbAuther.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetRadioButtonMaker();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);

            this.carReportDBTableAdapter.Update(this.infosys202202DataSet.CarReportDB);
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            dtpDate.Text = null;
            cbAuther.Text = null;
            cbCarName.Text = null;
            tbReport.Text = null;
        }

      
    }
}

