using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace multinomialDistWpf
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

        public int fac(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * fac(n - 1);
            }
        }

        public float getMultiDist(int n, 
                                  int x1, int x2, int x3, 
                                  float p1, float p2, float p3)
        {
            int productOfFacs = fac(x1) * fac(x2) * fac(x3);
            float productOfProbs = (float)(Math.Pow(p1, x1) * Math.Pow(p2, x2) * Math.Pow(p3, x3));

            float result = (fac(n) / productOfFacs) * productOfProbs;
            return result;

        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            int x1 = int.Parse(txtX1.Text);
            int x2 = int.Parse(txtX2.Text);
            int x3 = int.Parse(txtX3.Text);

            float p1 = float.Parse(txtP1.Text);
            float p2 = float.Parse(txtP2.Text);
            float p3 = float.Parse(txtP3.Text);

            int n = int.Parse(txtN.Text);

            float result = getMultiDist(n, x1, x2, x3, p1, p2, p3);
            lblResult.Content = result.ToString();
        }
    }
}
