using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> testing = new CustomList<int>();
            testing.Add(4);
            testing.Add(5);
            testing.Add(6);
            testing.Add(7);
            testing.Remove(6);

        }
    }
}
