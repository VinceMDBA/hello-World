using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Int32 index;
            System.Int32 loop;
            System.String AppMessage;
            System.String strRANDOM;
            System.Random random = new Random();

            index = 1;
            do
            {
                loop = 1;
                strRANDOM = null;
                do
                {
                    strRANDOM = strRANDOM + (Char)random.Next(97, 122);
                    loop = loop + 1;
                } while (loop <= 4);

                System.Console.WriteLine($"index = {index}: random string: {strRANDOM}.");
                index = index + 1;

            } while (index <= 10);
            System.Console.WriteLine("Application Complete");
            AppMessage = System.Console.ReadLine();
        }
    }
}
