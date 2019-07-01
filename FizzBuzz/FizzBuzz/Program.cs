using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we initialize the three variables we need for this task.
            int number = 0;
            int dividedByThree;
            int dividedByFive;

            //Here we create a loop that plays the FizzBuzz game till 100.
            for (int i = 0; i < 100; i++)
            {
                //We add one to the number.
                number++;

                //We divide the number with both 3 and 5 and put the remainders in to the variables.
                dividedByThree = number % 3;
                dividedByFive = number % 5;

                //If the remainder after dividing with 3 is 0 but after 5 is not, print the number and the word Fizz.
                if(dividedByThree == 0 && dividedByFive != 0)
                {
                    Console.WriteLine(number + " Fizz");


                }
                //If the remainder after dividing with 5 is 0 but after 3 is not, print the number and the word Buzz.
                if(dividedByFive == 0 && dividedByThree != 0)
                {
                    Console.WriteLine(number + " Buzz");

                }
                //If both remainders come out as 0, then the number is dividable with both and then the program prints the number with the word FizzBuzz.
                if(dividedByThree == 0 && dividedByFive == 0)
                {
                    Console.WriteLine(number + " FizzBuzz");

                }
                //If the number is not dividable with either 3 or 5, the program just prints the number and continues.
                else if(dividedByThree != 0 && dividedByFive != 0)
                {
                    Console.WriteLine(number);
                }


            }
            //Lastly we stop the program after the loop so we can take a look at the results.
            Console.ReadLine();

        }
    }
}
