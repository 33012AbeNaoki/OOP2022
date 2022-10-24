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

namespace LabelColor {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
           
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {


            int r = (int)rSlider.Value ;
            int g = (int)gSlider.Value ;
            int b = (int)bSlider.Value ;

            cLavel.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
        }

       
    }
}
