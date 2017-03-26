using System;
using System.Collections.Generic;
using Source.Models;

namespace Source
{
    class Program
    {
        public static void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        public static int AddNumbers(params int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }

            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }

            return sum; 
        } 

        public static int AddNumbers(int a, int b) 
            => a+b;

        static void Main(string[] args)
        {
            var delegates = new Delegates();
            delegates.Init();

            // Sandbox.Run();

            // DisplayText("Welcome");
            // int sum = AddNumbers(1,2,3,9,100);
            // int x = 5;
            // double y = 10.5;
            // decimal money = 10M;
            // string text = "Hello";
            // char c = 'c';
            // var red = Color.Red;
            // if(red == Color.Blue)
            // {

            // }
            // // List<int> numbers = new List<int>();
            // // numbers.Add(1);
            // // numbers.Add(2);
            // // numbers.Add(3);
            // var numbers = new List<int>
            // {
            //     1,2,3
            // };
            // foreach(var number in numbers)
            // {
            //     Console.WriteLine(number);
            // }
            // for(int i = 0; i < numbers.Count; i++)
            // {
            //     int number = numbers[i];
            //     Console.WriteLine(number);
            // }

            // var input = "";
            // do
            // {
            //     input = Console.ReadLine();
            //     switch(input)
            //     {
            //         case "a": 
            //             Console.WriteLine("Option A"); 
            //             break;
            //         case "b": 
            //             Console.WriteLine("Option B"); 
            //             break;
            //         default:
            //             Console.WriteLine("No option");
            //             break; 
            //     }
            //     // if(input == "a")
            //     // {
            //     //     Console.WriteLine("Option A");
            //     // }
            //     // else
            //     // {
            //     //     Console.WriteLine("No option");
            //     // }
            // }while(input == "q");
        }
    }

    enum Color
    {
        Red = 1,
        Blue = 5,
        Green = 10
    }
}
