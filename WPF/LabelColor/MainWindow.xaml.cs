using System;
using System.Collections.Generic;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();

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


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {



            int r = (int)rSlider.Value;
            int g = (int)gSlider.Value;
            int b = (int)bSlider.Value;

            cLavel.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;

            cLavel.Background = new SolidColorBrush(Color.FromRgb(color.R, color.G, color.B));

            rText.Text = FromRgb(color.R);
            gText.Text = FromRgb(color.G);
            bText.Text = FromRgb(color.B);
        }
        private string FromRgb(byte r) {

            return r.ToString();

        }

        private void Slider_PreviewTextInput(object sender, TextCompositionEventArgs e) {

            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }

        private void Slider_PreviewExecuted(object sender, ExecutedRoutedEventArgs e) {

            if (e.Command == ApplicationCommands.Paste) {
                e.Handled = true;
            }
        }

        private void Text_PreviewTextInput(object sender, TextCompositionEventArgs e) {

        }
    }
}
