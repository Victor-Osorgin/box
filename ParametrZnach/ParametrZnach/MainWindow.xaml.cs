﻿using System;
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

namespace ParametrZnach
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
        static void P(int a, ref int b)
        {
            a = 44; b = 33;
            Console.WriteLine("внутри метода {0 {1}",a ,b);
        }
        static void Main()
        {
            int a = 2, b = 4;
            Console.WriteLine("до вызова   {0} {1}", a, b );
            P(a, ref b);
            Console.WriteLine("после вызова {0}{1}", a, b);
        }
    }
   


}
