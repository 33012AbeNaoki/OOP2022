using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleApplication {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            GetSeason();
            
;        }

         public int GetSeason() {

            var today = DateTime.Now;
            int Month = today.Month; ;

            switch (today.Month) {

                case 11:
                case 12:
                case 1:
                case 2:
                    sesaonComboBox.SelectedIndex = 3;
                    break;
                case 4:
                case 5:
                    sesaonComboBox.SelectedIndex = 0;
                    break;
                case 6:
                case 7:
                case 8:
                    sesaonComboBox.SelectedIndex = 1;
                    break;
                case 9:
                case 10:
                    sesaonComboBox.SelectedIndex = 2;
                    break;
                    
            }
            return Month;
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e) {
            checkBoxTextBlock.Text = "チェック済み";

        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e) {
            checkBoxTextBlock.Text = "未チェック";

        }

        private void redRudioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "赤";

        }

        private void yellowRudioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "黄";

        }

        private void blueRudioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "青";

        }

        private void sesaonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            seasonTextBlock.Text = (string)((ComboBoxItem)sesaonComboBox.SelectedItem).Content;

        }
    }
}
