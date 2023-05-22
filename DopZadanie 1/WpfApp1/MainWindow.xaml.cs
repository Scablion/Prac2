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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int A = int.Parse(DD.Text);
            int B = int.Parse(MM.Text);
            int C = int.Parse(MM_Copy.Text);
            int SSquare = C * C, count = 0, S = A * B;

            while (S >= SSquare)
            {
                S -= SSquare;
                count++;
            }

            Answer.Text = ($"Mаксимальное число квадратов \nв прямоугольнике = {count}");

        }
    }
}
