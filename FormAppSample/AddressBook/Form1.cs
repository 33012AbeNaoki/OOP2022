using System;
using System.Activities.Expressions;
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

namespace AddressBook {
    public partial class Form1 : Form {

        //データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1() {
            InitializeComponent();

            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {

            if (ofdFileOpenDaiarog.ShowDialog() == DialogResult.OK) {

                pbPicture.Image = Image.FromFile(ofdFileOpenDaiarog.FileName);

            }

        }
        private void btAddPerson_Click(object sender, EventArgs e) {

            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            Person newPerson = new Person {

                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };

            listPerson.Add(newPerson);
            dgvPersons.Rows[dgvPersons.RowCount - 1].Selected = true;

            //if (listPerson.Count() > 0) {
            //    btDelete.Enabled = true;
            //    btUpdate.Enabled = true;

            //}
            EnabledCheck();


            setDbCompany(cbCompany.Text);
        }
        //コンボボックスに会社名を登録する（重複なし）
        private void setDbCompany(string company){

            if (!cbCompany.Items.Contains(company)) {

                //まだ登録されていなければ登録処理
                cbCompany.Items.Add(company);
            }
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {

            var listGroup = new List<Person.GroupType>();

            if (cbFamily.Checked) {
                listGroup.Add(Person.GroupType.家族);
            }
            if (cbFriend.Checked) {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked) {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked) {
                listGroup.Add(Person.GroupType.その他);
            }
            return listGroup;
        }

        private void btPictureClear_Click(object sender, EventArgs e) {

            pbPicture.Image = null;
        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {

            if (dgvPersons.CurrentRow == null) return;

            int index = dgvPersons.CurrentRow.Index;
            //例
            //データグリッドビューのインデックス〇番目の名前をテキストボックスに格納
            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            cbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;

            groupCheckBoxAllClear();//グループチェックボックスを初期化

            foreach (var group in listPerson[index].listGroup) {

                switch (group) {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }


            }
        }
        //グループのチェックボックスをオールクリア
        private void groupCheckBoxAllClear() {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {

            listPerson[dgvPersons.CurrentRow.Index].Name = tbName.Text;
            listPerson[dgvPersons.CurrentRow.Index].MailAddress = tbMailAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Address = tbAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Company = cbCompany.Text;
            listPerson[dgvPersons.CurrentRow.Index].listGroup = GetCheckBoxGroup();
            listPerson[dgvPersons.CurrentRow.Index].Picture = pbPicture.Image;

            dgvPersons.Refresh();//データグリッドビュー更新
        }

        private void btDelete_Click(object sender, EventArgs e) {
            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);

                EnabledCheck();//マスク処理呼び出し
            

        }

        //更新・削除ボタンのマスク解除、設定を行う（マスク判定を含む）
        private void EnabledCheck() {

          btUpdate.Enabled = btDelete.Enabled = listPerson.Count() > 0 ? true : false;


            //if (listPerson.Count() > 0) {
            //    //マスク解除
            //    btDelete.Enabled = true;
            //    btUpdate.Enabled = true;
            //}
            //else {
            //    //マスク設定
            //    btDelete.Enabled = false;
            //    btUpdate.Enabled = false;
            //}
            
        }

        private void Form1_Load(object sender, EventArgs e) {

            EnabledCheck();//マスク処理呼び出し
        }

        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e) {

            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {

                try {
                    //バイナリー形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {

                        bf.Serialize(fs, listPerson);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {

            cbCompany.Items.Clear();

            if (ofdFileOpenDaiarog.ShowDialog() == DialogResult.OK) {
                try {

                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDaiarog.FileName, FileMode.Open, FileAccess.Read)) {

                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>)bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                //コンボボックス登録
                foreach (var item in listPerson.Select(p => p.Company)) {
                    
                    setDbCompany(item);//存在する会社を登録
                }
            }
            EnabledCheck();
        }
    }
}


