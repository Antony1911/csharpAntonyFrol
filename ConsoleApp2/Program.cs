using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SetArray(3, 5);
        }

        static void SetArray(int x, int y)
        {
            int[,] array = new int[x, y];
        }
    }
}
