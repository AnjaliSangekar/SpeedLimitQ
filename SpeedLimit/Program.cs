using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedLimit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter speed limit");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Car speed");
            int speed = Convert.ToInt32(Console.ReadLine());

            int demeritPoints = 0;

            if (limit > speed)
            {
                Console.WriteLine("OK ,Good to go");
            }
            else
            {
                int diff = speed - limit;

                for(int c = 5; c <= diff; c += 1)
                {
                    demeritPoints++;
                }
            }

            Console.WriteLine("demeritPoints : " + demeritPoints);

            if(demeritPoints >= 12)
            {
                Console.WriteLine("Your license is suspended");
            }
            else
            {
                Console.WriteLine("You are not suspended");
            }
        }
    }
}
