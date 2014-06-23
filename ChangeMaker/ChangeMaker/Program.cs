using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //CALLING FUNCTIONS HERE
            Console.WriteLine("CHANGE MAKER!!!!!");
            Console.WriteLine();
            ChangeMaker(3.18);
            Console.WriteLine();
            ChangeMaker(0.99);
            Console.WriteLine();
            ChangeMaker(12.93);

            //keeps console open
            Console.ReadKey();
        }
        //change maker: round money amount to penny and 
        //compute minimum amount of coins to make change
        static void ChangeMaker(double amount)
        {
            //declare function variables
            int quarter = 25;
            int numQuarter = 0;
            int dime = 10;
            int numDime = 0;
            int nickel = 5;
            int numNickel = 0;
            int penny = 1;
            int numPenny = 0;

            //code to perform the changes to amount
            int amountC = Convert.ToInt32(amount * 100);
           
           while (amountC >= quarter)
           {
               amountC -= quarter;
               numQuarter++;
           }
           while (amountC >= dime)
           {
               amountC -= dime;
               numDime++;
           }
           while (amountC >= nickel)
           {
               amountC -= nickel;
               numNickel++;
           }
           while (amountC >= penny)
           {
               amountC -= penny;
               numPenny++;
           }


            //write ouput to the console
            Console.WriteLine("Amount: " + "$" + amount);
            Console.WriteLine("Quarters: " + numQuarter);
            Console.WriteLine("Dimes: " + numDime);
            Console.WriteLine("Nickels: " + numNickel);
            Console.WriteLine("Pennies: " + numPenny);
        }
    }
}
