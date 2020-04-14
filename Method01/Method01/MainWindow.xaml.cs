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

namespace Method01
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
        static string s = "Demo";
        double y;

        public double Gety()
        {
            return y;
        }

        public void Sety(double y_)
        {
            y = _y;
        }

        public static string Gets()
        {
            return s;
        }
    }

    class Class1
    {
        static void Main()
        {
            Demo x = new Demo();
            x.Sety(0.12);
            Console.WriteLine(x.Gety());
            Console.WriteLine(Demo.Gets());
            Console.WriteLine( Gets() );
        }
    }

}
