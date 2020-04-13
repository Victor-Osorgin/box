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

namespace Polimorf
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

    public class Programm
    {
        static void Main(string[] args)
        {
            BaseShip ship = GetShip(ShipType.FightShip);
            string result = ship.Fight();

            Console.WriteLine(result);

            Console.ReadLine();
        }

        static BaseShip GetShip(ShipType shipType)
        {
            switch (shipType)
            {
                case shipType.FightShip:
                    return new FightShip();

                case shipType.TransportShip:
                    return new TransportShip();

                default:
                    throw new Exception("Неизвестный тип корабля.");
            }

        }
    }

    public class BaseShip
    {
        public virtual string Move(int distance)
        {

            string result = string.Format("Пройдено колометров: {0}", distance);
            return result;
        }

        public virtual string Fight()
        {
            return "Произошел бой";
        }
    }
    public class TransportShip : BaseShip
    {
        public override string Move(int distance)
        {
            double time = (double)distance / 1000;
            return string.Format("Пройдено километров: {0} за время: {1}", distance, time);
        }
        public override string Fight()
        {
            return "Транспортный корабль не может вступать в бой!";
        }

        public override string ToString()
        {
            return "Транспортный корабль";
        }
    }

    public class Badship
    {
        public ShipType ShipType { get; set; }

        public string Move(int distance)
        {
            double time = 0;

            if (ShipType == ShipType.TransportShip)
            {
                time = (double)distance / 1000;
            }

            if (ShipType == ShipType.FightShip)
            {
                time = (double)distance / 2000;
            }

            return string.Format("Пройдено километров: {0} за время: {1}", distance, time);

        }

        public string Fight()
        {
            if (ShipType == ShipType.TransportShip)
            {
                return "Транспортный корабль не может вступать в бой!";
            }

            if (ShipType == ShipType.FightShip)
            {
                return "Противник уничтожен";
            }

            return "Неизестный тип корабля.";
        }

        public enum ShipType
        {
            TransportShip = 1,
            FightShip = 2
        }

        public class FightShip : BaseShip
        {
            public override string Move(int distance)
            {
                double time = (double)distance / 2000;
                return string.Format("Пройдено километров: {0} за время: {1}", distance, time);
            }
            public override string Fight()
            {
                return "Транспортный корабль уничтожен.";
            }

            public override string ToString()
            {
                return "Боевой корабль";
            }
        }
    }
}

}
