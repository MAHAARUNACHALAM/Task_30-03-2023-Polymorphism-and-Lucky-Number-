/*Abstraction:

A company XYZ wants to develop an app which can predict the
lucky number for a person.
The name of the app is LuckyNumberPredictor.
This app consists of a method - upon calling the person gets to know his/her lucky number.
 This method calls another class —> NumberPredictor - which have the formula for
 predicting the lucky number of that person. This approach is done so that no-one else gets
to know the secret formula for this prediction.

LuckyNumberPredictor accepts only one argument i.e: date of birth of the person. The formula
for predicting the lucky number is quite simple -> a person’s lucky number is calculated by rounding off the date of birth to the nearest Fibonacci number.
Another thought that XYZ company is  having - is to predict unlucky number as well - but for this — for now, they don’t have any formula ready. 
But they want to have this idea to be stored in - in their NumberPredictor class. The company is asking you to develop this system.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToday
{

    class NumberPredictor
    {
        static void fibonacci(string DateofBirth)
        {
            //Convert string Dob to int
            int Dob=int.Parse(DateofBirth);
            //Method to round off date of birth to nearest fibonacci number
            //Find nearest fibonacci number of this dob
            // Base Case
            if (Dob == 0)
            {
                Console.Write(0);
                return;
            }

            int first = 0, second = 1;
            int third = first + second;

            while (third <= Dob)
            {

                // Update the first
                first = second;

                // Update the second
                second = third;

                // Update the third
                third = first + second;
            }

            // Store the Fibonacci number
            // having smaller difference with N
            int ans = (Math.Abs(third - Dob) >=
                      Math.Abs(second - Dob)) ?
                               second : third;
            Console.Write("Lucky number is"+ans);

        }
        public static void PredictLuckyNumber(string DateofBirth)
        {
            if (DateofBirth == null)
            {
                Console.WriteLine("Invalid Date");
                
            }
            else
            {
                //Round off Dateof birth to nearest fibonacci number
                fibonacci(DateofBirth);
            }
        }
        public static void PredictUnLuckyNumber(String DateofBirth)
        {
            Console.WriteLine("Will be Implemented in future");
        }
    }

    class LuckyNumberPredictor
    {
        public static void PredictLuckyNumber(string DateOfBirth)
        {
            //Create object of NumberPredictor
            NumberPredictor.PredictLuckyNumber(DateOfBirth);
        }
        public static void PredictUnluckyNumber(String DateofBirth)
        {
            NumberPredictor.PredictUnLuckyNumber(DateofBirth);
        }

    }
    
    
    class Program
    {
        static void Main(string[] args)
        {

            //Getting user input
            Console.WriteLine("Enter Date of Birth");
            string DateofBirth=Console.ReadLine();
            //Getting User Choice
            Console.WriteLine("Enter the option\n1.Predict Lucky Number\n2.PredictUnLucky Number");
            int choice= Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                //Call PredictLuckyNumber method
                LuckyNumberPredictor.PredictLuckyNumber(DateofBirth);
            }
            else if(choice == 2) {
                //Call PredictUnluckyNumber method
                LuckyNumberPredictor.PredictUnluckyNumber(DateofBirth);
            }
            else
            {
                Console.WriteLine("Wrong Choice");
            }

        }
    }
 
}
