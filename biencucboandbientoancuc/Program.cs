using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biencucboandbientoancuc
{
    internal class Program
    {
        static int x = 5;
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(x);
            x = 10;
            printsomting();
        }
        static void printsomting()
        {
            Console.WriteLine(x);
        }*/

            int values;
            //Console.WriteLine("Values before increase: {0}",values);
            Increasevalues(out values);
            Console.WriteLine("Values After increase: {0}", values);
            Console.ReadLine();

        }
        static void Increasevalues(out int count)
        {
             count = 0;
            count++;
        }
    }
}
