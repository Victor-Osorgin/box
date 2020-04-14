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

namespace Constants
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

    class Demo
    {
        public int a = 1;
        public const double c = 1.66;
        public static string s = "Demo";
        double y;
    }

    class Class1
    {
        static void Main()
        {
            Demo x = new Demo();
            Console.WriteLine( x.a );
            Console.WriteLine(Demo.c);
            Console.WriteLine(Demo.s);
        }
    }
}
