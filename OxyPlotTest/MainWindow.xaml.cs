using OxyPlot;
using OxyPlot.Series;
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

namespace OxyPlotTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (graph1.Model.Series[0] as FunctionSeries).Points.Clear();
            (graph1.Model.Series[0] as FunctionSeries).Points.Add(new DataPoint(10, 10));
            (graph1.Model.Series[0] as FunctionSeries).Points.Add(new DataPoint(20, 20));
            graph1.InvalidatePlot();

           //(graph1.Model.Series[1] as BarSeries).Items.Add(new BarItem(3));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(arg.Text);
            Factorial factor = new Factorial();
            int b = factor.Calculate_Factorial(a);
            MessageBox.Show(Convert.ToString(b));
        }
    }
}
