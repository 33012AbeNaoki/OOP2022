using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ColorChanger {

  
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        List<MyColor> colorList = new List<MyColor> {

        };

        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            ChangeColor();
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

            ChangeColor();

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            

            cLavel.Background = new SolidColorBrush(Color.FromRgb(color.R, color.G, color.B));

            rValue.Text = FromRgb(color.R);
            gValue.Text = FromRgb(color.G);
            bValue.Text = FromRgb(color.B);
        }

        private string FromRgb(byte r) {
            return r.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            MyColor stColor = new MyColor();

            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);

            stColor.Color = Color.FromRgb(r, g, b);

            var colorName = ((IEnumerable<MyColor>)DataContext)
                .Where(c => c.Color.R == stColor.Color.R &&
                c.Color.G == stColor.Color.G &&
                c.Color.B == stColor.Color.B).FirstOrDefault();


            stockList.Items.Insert(0,colorName?.Name ??
                "   R  :" + rValue.Text + "   G  :" + gValue.Text + "   B  :" + bValue.Text);

            colorList.Insert(0,stColor);
        }
        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            if (stockList.SelectedIndex == -1) return;     

            rSlider.Value = colorList[stockList.SelectedIndex].Color.R;
            gSlider.Value = colorList[stockList.SelectedIndex].Color.G;
            bSlider.Value = colorList[stockList.SelectedIndex].Color.B;
            ChangeColor();
        }
        private void ChangeColor() {

            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);

            cLavel.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void delButton_Click(object sender, RoutedEventArgs e) {

            if (stockList.SelectedIndex == -1) return;

            colorList.RemoveAt(stockList.SelectedIndex);
            stockList.Items.RemoveAt(stockList.SelectedIndex);


            //var dellIndex = stockList.SelectedIndex;

            //if (dellIndex == -1) return;

            //stockList.Items.RemoveAt(dellIndex);
            //colorList.RemoveAt(dellIndex);

        }
        /// <summary>
        /// 色と色名を保持するクラス
        /// </summary>
        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }
        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }


        private void Slider_PreviewTextInput(object sender, TextCompositionEventArgs e) {

            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }

        private void Slider_PreviewExecuted(object sender, ExecutedRoutedEventArgs e) {

            if (e.Command == ApplicationCommands.Paste) {
                e.Handled = true;
            }
        }


    }
}
