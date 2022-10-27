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

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            ChangeColor();
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

            ChangeColor();

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;

      

            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
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

        private void ChangeColor() {

            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);

            cLavel.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void Button_Click(object sender, RoutedEventArgs e) {


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
