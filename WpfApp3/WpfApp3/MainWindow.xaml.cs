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

namespace WpfApp3
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

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            int k2 = 0;
            string text1 = Tb1.Text;
            int L2 = text1.Length;
            for (int i = 0; i < L2-1; i++)
            {
                if (text1[i] >= 'а'&& text1[i] <= 'я' && (text1[i+1]==' '|| text1[i + 1] == '.'|| text1[i + 1] == ','||text1[i + 1] == '!'|| text1[i + 1] == '?'))
                {
                    k2++;
                }


            }
            if (text1[L2-1] != ' ' && text1[L2 - 1] != '.' && text1[L2 - 1] != ',' && text1[L2 - 1] != '!' && text1[L2 - 1] != '?')
            {
                k2++;
            }
            Tb2.Text = String.Format("{0}", k2);
        }
    }
}
