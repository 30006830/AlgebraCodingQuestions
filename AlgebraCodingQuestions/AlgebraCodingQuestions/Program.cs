using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraCodingQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Algebra Questions: Question 1.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This program is designed to take a letter from your input.");
            Console.WriteLine("And it will either refer it as a Vowel, or a Consonant.");
            Console.WriteLine("Enter a letter: ");

            string letter = Console.ReadLine(). ToLower();
            
            if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
            {
                Console.WriteLine($"{letter} is a Vowel!");
            }    
            else
            {
                Console.WriteLine($"{letter} is a consonant!");
            }
                

            Console.ReadLine();
            Console.WriteLine("End of Application, Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            
            //Question 2
            Console.WriteLine("This program is a BMI (Body Mass Index) calculator.");
            Console.ReadLine();

            Console.WriteLine("Please Enter your Weight in Kg's: ");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Now Enter your Height in CM's: ");
            float height = float.Parse(Console.ReadLine())/100;
            Console.WriteLine("This is your BMI: " + (weight / (height * height)));

            Console.WriteLine("End of Application. Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();

            //Question 3
            Console.WriteLine("This program will calculate the sum of 20 numbers.");
            float total = 0;

            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Please Enter a Number {i}: ");
                total = total + float.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum of the numbers you have inputted is: {total}");

            Console.WriteLine("End of application, press enter to continue.");
            Console.ReadLine();
            Console.Clear();

            //Question 4
            Console.WriteLine("This program will calculate the factorial of 10.");
            int total1 = 1;
            int e = 1;
            while(e<=10)
            {
                total1 *= e;
                e++;
            }

            Console.WriteLine($"The factorial of 10 is: {total1}");
            Console.ReadLine();           
        }
    }
}
