using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    
    public class Logic
    {
        public static string Revers(string str)
        {
            string str2;
            string[] mas = str.Split(' ');
            
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = new string(mas[i].Reverse().ToArray());
            }

            str2 = string.Join(" ", mas);

            return str2;
        }

        public static string Compare(string str)
        {
            var A = Logic.Revers(str);
            string outMessage = A;

            return outMessage;
        }
    }
}
