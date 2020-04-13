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

namespace Delegate
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

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Moving += student_Moving;

            student.Move(7);
        }

        static void student_Moving(object sender, MovingEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    public class MovingEventArgs : EventArgs
    {
        public MovingEventArgs(string message)
        {
            Message = message;
        }

        public stringMessage { get; private set;}
    }

    static void Show(string message)
    {
        Console.WriteLine(message);
    }

    static internal TestDelegate(CountDelegate method, string testString)
    {
        return method(testString);
    }

    public delegate void ShowMessage(string message);
    public class Student
    {
        public void Move(int distance)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleap(1000);
                if (Moving != null)
                    Moving(this, new MovingEventArgs(string.Format("Идет перемещение... пройдено километров: {0}", i)));
            }
        }

        public event EventHandler<MovingEventArgs> Moving;
    }

}
