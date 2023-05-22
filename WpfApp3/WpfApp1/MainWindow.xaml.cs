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
            int count;
            int k = Convert.ToInt32(DD.Text);
            if (k >= 1 && k <= 365)
            { for (int i = 7; k >= i;) { k = k - i; } }
            count = k;
            if (count == 0) { Answer.Text = ("номер дня недели 1"); }
            else if (count == 1) { Answer.Text = ("номер дня недели 2"); }
            else if (count == 2) { Answer.Text = ("номер дня недели 3"); }
            else if (count == 3) { Answer.Text = ("номер дня недели 4"); }
            else if (count == 4) { Answer.Text = ("номер дня недели 5"); }
            else if (count == 5) { Answer.Text = ("номер дня недели 6"); }
            else if (count == 6) { Answer.Text = ("номер дня недели 0"); }
        }
    }
}
