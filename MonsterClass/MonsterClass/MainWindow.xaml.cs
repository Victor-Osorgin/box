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

namespace MonsterClass
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

    class Monster
    {
        public Monster()
        {
            this.name = "Noname";
            this.health = 100;
            this.ammo = 100;
        }

        public Monster(string name) : this()
        {
            this.name = name;
        }

        public Monster(int health, int ammo, string name)
        {
            this.name = name;
            this.health = health;
            this.ammo = ammo;
        }

        public string GetName()
        {
            return name;
        }

        public int GetHealth()
        {
            return health;
        }

        public int GetAmmo()
        {
            return ammo;
        }

        public void Passport()
        {
            Console.WriteLine("Monster {0} \t health = {1} ammo = {2}".name. health. ammo);
        }

        string name;
        int health. ammo;
    }

    class Class1
    {
        static void Main()
        {
            Monster X = new Monster();
            X.Passport();
            Monster Vasia = new Monster("Vasia");
            Vasia.Passport();
            Monster Masha = new Monster(200. 200. "Masha");
            Masha.Passport();
        }
    }
}
