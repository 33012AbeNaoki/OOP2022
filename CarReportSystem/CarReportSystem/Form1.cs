using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {

        BindingList<CarReport> listPersons = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            Application.Exit();
        }
        private void btReportinput_Click(object sender, EventArgs e) {

            CarReport newPersons = new CarReport {

                Date = dtDate.Value,
                Auther = cbReporterName.Text,
                Maker = GetRadioButtonKindNumber(),

            };

            listPersons.Add(newPersons);

        }

        private CarReport.MakerGroup GetRadioButtonKindNumber() {
            var selectedmaker = CarReport.MakerGroup.その他;
            if (rbNissan.Checked) {
                selectedmaker = CarReport.MakerGroup.日産;
            }
            if (rbHonda.Checked) {
                selectedmaker = CarReport.MakerGroup.ホンダ;
            }
            if (true) {

            }

            return selectedmaker;
        }

        private void btPictureopen_Click(object sender, EventArgs e) {

            if (openFileDialog.ShowDialog() == DialogResult.OK) {

                pictureBox.Image = Image.FromFile(openFileDialog.FileName);

            }
        }
        private void btPicturedel_Click(object sender, EventArgs e) {

            pictureBox.Image = null;
        }

       
    }
}
