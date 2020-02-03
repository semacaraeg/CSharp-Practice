using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;


namespace ConversionProject
{
    class Program
    {
        //this is a checker when user pressed the 'Q' option to Quit
        static bool didUserQuit = false;
        static void Main(string[] args)
        {
            //display Main Menu as long as the user has not pressed the Quit option
            while (didUserQuit == false)
            {
                MainMenu();
            }

        }

        static void MainMenu()
        {
            char userInput;

            Console.WriteLine("Please choose from options below:");
            Console.WriteLine("A : Calculate BMI");
            Console.WriteLine("B : Convert Temperature");
            Console.WriteLine("C : Convert Kilos to Pounds or vice versa");
            Console.WriteLine("Q : Quit");

            //capture user input, converting the integer value to the character value
            userInput = Convert.ToChar(Console.Read());

            switch (userInput)
            {
                case 'a':
                case 'A':
                    ShowBMIMenu();
                    break;
                case 'b':
                case 'B':
                    ShowTempConversionMenu();
                    break;
                case 'c':
                case 'C':
                    ShowKgtoPoundMenu();
                    break;
                case 'q':
                case 'Q':
                    didUserQuit = true;
                    Environment.Exit(0);
                    break;
                default:
                    Console.ReadLine();
                    Console.WriteLine("Not valid option!");
                    break;
            }
        }

        static void ShowBMIMenu()
        {
            char userInput;
            bool isMetric = false;
            float weight = 0.0F;
            float height = 0.0F;

            Console.ReadLine();
            Console.WriteLine("Please choose from options below:");
            Console.WriteLine("A : Use Metric (cm / kg)");
            Console.WriteLine("B : Use Standard (inches / pounds)");
            Console.WriteLine("Q : Back to Main Menu");

            userInput = Convert.ToChar(Console.Read());

            switch (userInput)
            {
                case 'a':
                case 'A':
                    isMetric = true;
                    height = GetUserHeightInput("centimeters");
                    weight = GetUserWeightInput("kilograms");
                    break;
                case 'b':
                case 'B':
                    isMetric = false;
                    height = GetUserHeightInput("inches");
                    weight = GetUserWeightInput("pounds");
                    break;
                case 'q':
                case 'Q':
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.ReadLine();
                    Console.WriteLine("Not valid option");
                    break;
            }

            //use the calculate BMI from the Utility class
            UtilityClass u = new UtilityClass();
            float BMIResult = u.GetBMI(height, weight, isMetric);
            Console.WriteLine($"Your BMI is {BMIResult}");
        }

        //GetUserHeightInput and GetUserWeightInput methods are use for getting the input values
        //from the user, passing a string that has the system used (i.e. metric(kg/cm) or standard(pound/in)) to the methods 
        //the string metric_height is used for displaying the right system used out in the console
        static float GetUserHeightInput(string metric_height)
        {
            float height;
            Console.ReadLine();
            Console.WriteLine($"Your height({metric_height})");
            height = float.Parse(Console.ReadLine());
            return height;
        }
        static float GetUserWeightInput(string metric_weight)
        {
            float weight;
            Console.WriteLine($"Your weight({metric_weight})");
            weight = float.Parse(Console.ReadLine());
            return weight;
        }

        //Menu for Temperature Conversions
        static void ShowTempConversionMenu()
        {
            Console.Clear();
            char userInput;
            UtilityClass u = new UtilityClass();

            Console.ReadLine();
            Console.WriteLine("Please choose from options below:");
            Console.WriteLine("A : Convert Celsius to Fahrenheit");
            Console.WriteLine("B : Convert Fahrenheit to Celsius");
            Console.WriteLine("Q : Back to Main Menu");

            userInput = Convert.ToChar(Console.Read());

            switch (userInput)
            {
                case 'a':
                case 'A':
                    Console.ReadLine();
                    Console.WriteLine("Celsius:");
                    float celsius = float.Parse(Console.ReadLine());
                    //printing out the converted values using a formatted string and calling the method created in the UtilityClass
                    // that returns a formatted string
                    Console.WriteLine($"{celsius} Celsius is " + u.ConvertCelsiusToFahren(celsius));
                    break;
                case 'b':
                case 'B':
                    Console.ReadLine();
                    Console.WriteLine("Fahrenheit:");
                    float fahren = float.Parse(Console.ReadLine());
                    //printing out the converted values using a formatted string and calling the method created in the UtilityClass
                    // that returns a formatted string
                    Console.WriteLine($"{fahren} Fahrenheit is " + u.ConvertFahrenToCelsius(fahren));
                    break;
                case 'q':
                case 'Q':
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.ReadLine();
                    Console.WriteLine("Not valid option");
                    break;
            }

        }

        static void ShowKgtoPoundMenu()
        {
            Console.Clear();
            char userInput;
            UtilityClass u = new UtilityClass();

            Console.ReadLine();
            Console.WriteLine("Please choose from options below:");
            Console.WriteLine("A : Convert Kilogram to Pounds");
            Console.WriteLine("B : Convert Pounds to Kilograms");
            Console.WriteLine("Q : Back to Main Menu");

            userInput = Convert.ToChar(Console.Read());
            switch (userInput)
            {
                case 'a':
                case 'A':
                    Console.ReadLine();
                    Console.WriteLine("Kilograms:");
                    float kg = float.Parse(Console.ReadLine());
                    Console.WriteLine($"{kg} Kilogram(s) is " + u.ConvertWeightToPounds(kg) + " pounds!");
                    break;
                case 'b':
                case 'B':
                    Console.ReadLine();
                    Console.WriteLine("Pounds:");
                    float pounds = float.Parse(Console.ReadLine());
                    Console.WriteLine($"{pounds} Pounds is " + u.ConvertWeightToKg(pounds) + " kilograms!");
                    break;
                case 'q':
                case 'Q':
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.ReadLine();
                    Console.WriteLine("Not valid option");
                    break;
            }

        }
    }
}
