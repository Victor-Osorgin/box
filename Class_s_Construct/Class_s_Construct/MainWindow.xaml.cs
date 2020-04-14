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

namespace Class_s_Construct
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
        public Demo(int a, double y)
        {
            this.a = a;
            this.y = y;
        }
        public double Gety()
        {
            return y;
        }

        int a;
        double y;
    }

    class Class1
    {
        static void Main()
        {
            Demo a = new Demo( 300, 0.002 );
            Console.WriteLine( a.Gety() );
            Demo b = new Demo(1, 5.71);
            Console.WriteLine(b.Gety());
        }
    }
}
