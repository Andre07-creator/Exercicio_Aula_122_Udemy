using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio__Aula212_Udemy.Entites
{
    class PortalOnline
    {
        public SortedSet<int> A = new SortedSet<int>();
        public SortedSet<int> B = new SortedSet<int>();
        public SortedSet<int> C = new SortedSet<int>();
        public void AddA(int a)
        {
            A.Add(a);
        }
        public void AddB(int b)
        {
            A.Add(b);
        }
        public void AddC(int c)
        {
            A.Add(c);
        }
        public override string ToString()
        {
            A.UnionWith(B);
            A.UnionWith(C);
            return "Total students: " + A.Count;
        }
    }   
    
}
