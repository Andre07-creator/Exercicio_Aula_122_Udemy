using System;
using Exercicio__Aula212_Udemy.Entites;
using System.Collections.Generic;

namespace Exercicio__Aula212_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            PortalOnline portal = new PortalOnline();
            Console.Write("How many students for course A? ");
            int na = int.Parse(Console.ReadLine());
            for(int i = 0; i < na; i++)
            {
              portal.AddA (int.Parse(Console.ReadLine()));
            }
            Console.Write("How many students for course B? ");
            int nb = int.Parse(Console.ReadLine());
            for (int i = 0; i < nb; i++)
            {
                portal.AddB(int.Parse(Console.ReadLine()));
            }
            Console.Write("How many students for course C? ");
            int nc = int.Parse(Console.ReadLine());
            for (int i = 0; i < nc; i++)
            {
                portal.AddC(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(portal);
        }

    }
}
