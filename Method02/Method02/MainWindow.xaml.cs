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

namespace Method02
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
    }

    class Class1
    {
        static int Max(int a, int b)
        {
            if (a > b) return a;
            else       return b;
        }
        static void Main()
        {
            int a = 2, b = 4;
            int x = Max(a, b);
            Console.WriteLine(x);
            short t1 = 3, t2 = 4;
            int y = Max(t1, t2);
            Console.WriteLine(y);

            int z = Max(a + t1, t1 / 2 * b);
            Console.WriteLine(z);
        }
    }
}
