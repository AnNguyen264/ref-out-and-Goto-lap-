using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            goto Howktem;
            Console.WriteLine("howktem");
        Howktem:
            Console.WriteLine("Hello");
            #region vd1
            /*
            int a = 2;
            switch (a)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    goto case 1;              
                case 3:
                    Console.WriteLine("case 3");
                    break;
            }
            */
            #endregion
            #region vd2
            /*
            int b = 2;
            // neu a==2
            if (b == 2)
            {
                // dich chuyen den a_Is_2
                goto b_Is_2;
            }
            Console.WriteLine("A==1");
        b_Is_2:// dk 
            Console.WriteLine("A==2");
            */
            #endregion
            #region vd3
            /*
            int c = 1;
            firstboi:
            // neu a==2
            if (c == 2)
            {
                // dich chuyen den a_Is_2
                goto c_Is_2;
            }
            Console.WriteLine("A==1");
            c_Is_2:// dk 
            Console.WriteLine("A==2");
            goto firstboi;
            */
            #endregion
            #region vd4
           
            string howktem = "howktem.com";
            int count = 0;
             beginloop:
            Console.WriteLine(howktem);
            count++;
            if(count<10)
            goto beginloop;
            #endregion
            do// lam di 
            {

            }while(true);// khi thoa man
        }
    }
}
