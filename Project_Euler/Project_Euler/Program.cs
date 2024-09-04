using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kolmonen = 3;
            int vitonen = 5;
            List<int> lista = new List<int>();
       

            foreach(int index in Enumerable.Range(1, 999))
            {
                if (index % kolmonen == 0 || index % vitonen == 0 && !lista.Contains(index))
                {
                    lista.Add(index);
                }
            }

            int tulos = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                tulos = tulos + lista[i];
            }
            Console.WriteLine("Luku on: " + tulos);

            Console.ReadLine();
        }
    }
}
