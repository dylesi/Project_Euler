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
            int loppuluku_1 = 0;
            int loppuluku_2 = 0;
            List<int> lista = new List<int>();

            foreach(int index in Enumerable.Range(1, 1000))
            {
                if (index % kolmonen == 0)
                {
                    lista.Add(index);
                }

                else if (index % vitonen == 0 && !lista.Contains(index))
                {
                    lista.Add(index);
                }
            }

            int numero = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                numero = numero + lista[i];
            }
            Console.WriteLine("Luku on: " + numero);
            Console.ReadLine();
        }
    }
}


// testaa jokainen numero yhdestä tuhanteen. Jos lukujen 3 ja 5 jakojäännös on nolla, on luku kolmen tai viiden kerroin.
