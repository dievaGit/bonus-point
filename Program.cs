using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int x = 0;

            do
            {
                //Requesting data from the user
                Console.Write(" Enter the punctuation: ");
                x = Convert.ToInt32(Console.ReadLine());
                
            }
            while (x <= 0 || x > 9);

            if(x >= 1 && x <= 3)
            {
                x *= 10;
                Console.Write(" The score has the bonus of: {0} ", x);
            }
            else
            {
                if (x >= 4  && x <= 6)
                {
                    x *= 100;
                    Console.Write(" The score has the bonus of: {0} ", x);
                }
                else
                {
                    if (x >= 7 && x <= 9)
                    {
                        x *= 1000;
                        Console.Write(" The score has the bonus of: {0} ", x);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
