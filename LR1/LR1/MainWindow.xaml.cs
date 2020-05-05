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


namespace LR1 // Лабораторная работа 1 (Вариант 10)
{
    class Skiers // Базовый класс Лыжники
    {
        public int number;  // Объявили поля number и name
        public string name;

        //Создали виртульный метод
        public virtual void Say()
        {
            Console.WriteLine("На старт!");
        }

        // Создали перегруженные конструкторы
        public Skiers() { }
        public Skiers(int number)
        {
            this.number = number;
        }

        public Skiers(int number, string name)
        {
            this.number = number;
            this.name = name;
        }
    }

    class Team : Skiers // Класс наследник
    {
        public int Number        // Инкапсуляция полей через свойства
        {
            get { return number; }
            set { number = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override void Say()      // Переопределили виртуальный метод
        {
            base.Say();
            Console.WriteLine("Внимание!");
        }

    }
    
    public interface ISkiers        // Создали интерфейс
    {
        void Skier();
        
    }

    class Program
    {
        class Marsh : ISkiers
        {
            public void Skier()
            {
                Console.WriteLine("Марш!");
            }
        }
        static void Main(string[] args)
        {
            ISkiers c = new Marsh();
            c.Skier();
            Skiers obj1 = new Skiers();
            Skiers obj2 = new Skiers(number: 27);
            Skiers obj3 = new Skiers(number: 13, name: "Jerry");

            Console.ReadLine();
        }

    }
}

