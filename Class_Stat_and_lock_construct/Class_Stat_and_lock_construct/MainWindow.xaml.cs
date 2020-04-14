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

namespace Class_Stat_and_lock_construct
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

    class D
    {
        private D(){}
        static D()
        {
            a = 200;
        }
        static int a;
        static double b = 0.002;
        public static void Print()
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

        }
    }
    class Class2
    {
        static void Main()
        {
            D.Print();
            D d = new D();
        }
    }

}
