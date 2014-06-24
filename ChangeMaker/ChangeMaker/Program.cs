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
            Console.WriteLine();
            Console.WriteLine("Let's bring out the BIG BUCKS!");
            ChangeMaker(11234.38);
            Console.WriteLine();
            ChangeMaker(4875874.72);

            //keeps console open
            Console.ReadKey();
        }
        //change maker: round money amount to penny and 
        //compute minimum amount of coins to make change
        static void ChangeMaker(double amount)
        {
            //declare function variables
            int oneHundDollar = 10000;
            int numOneHund = 0;
            int fiftyDollar = 5000;
            int numFifty = 0;
            int twentyDollar = 2000;
            int numTwenty = 0;
            int tenDollar = 1000;
            int numTen = 0;
            int fiveDollar = 500;
            int numFive = 0;
            int oneDollar = 100;
            int numOne = 0;
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
            while (amountC >= oneHundDollar)
            {
                amountC -= oneHundDollar;
                numOneHund++;
            }
            while (amountC >= fiftyDollar)
            {
                amountC -= fiftyDollar;
                numFifty++;
            }
            while (amountC >= twentyDollar)
            {
                amountC -= twentyDollar;
                numTwenty++;
            }
            while (amountC >= tenDollar)
            {
                amountC -= tenDollar;
                numTen++;
            }
            while (amountC >= fiveDollar)
            {
                amountC -= fiveDollar;
                numFive++;
            }
            while (amountC >= oneDollar)
            {
                amountC -= oneDollar;
                numOne++;
            }
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
            Console.WriteLine("Hundreds: " + numOneHund);
            Console.WriteLine("Fifties: " + numFifty);
            Console.WriteLine("Twenties: " + numTwenty);
            Console.WriteLine("Tens: " + numTen);
            Console.WriteLine("Fives: " + numFive);
            Console.WriteLine("Ones: " + numOne);
            Console.WriteLine("Quarters: " + numQuarter);
            Console.WriteLine("Dimes: " + numDime);
            Console.WriteLine("Nickels: " + numNickel);
            Console.WriteLine("Pennies: " + numPenny);
        }
    }
}
