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

namespace Pizza
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            summary.Text = 
                "Jan Kowalski" + Environment.NewLine
                + "Vegetariana na ultracienkim spodzie" + Environment.NewLine
                + "dodatki:" + Environment.NewLine
                + "Dodatkowy ser: cheddar" + Environment.NewLine
                + "Sos: pikantny" + Environment.NewLine
                + "--";
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            int min_width = 250;
            this.MinWidth = this.Width > min_width ? this.Width : min_width;
            this.MinHeight = this.Height;
        }
    }
}
