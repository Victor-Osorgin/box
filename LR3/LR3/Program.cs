using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

       /* static int Test()
        {
            int cat = 0;
            int y = (-8);
            int i = 9;
            int x = 2;
            if (x == 1)
            {
                int calc = cat + 15;
                return calc;
            }
            else
            {
                int calc = cat + (12 * x) - (i + (y * (x - 1)));
                return calc;
            }
            Console.WriteLine(cat);
        }   */


        
    }
}
