using System;
using System.Threading;

namespace Source.Models
{
    public class Delegates
    {
        public delegate void Logger(string text);
        public delegate int Adder(int a, int b);

        public void Init()
        {
            var user = new 
            {
                Email = "user@email.com",
                Password = "secret"
            };

            Logger logger = text => { Console.WriteLine(text); };
            Logger multiLogger = DisplayText;
                   multiLogger -= DisplayText;

            // Adder adder = (a,b) => a+b;

            Action sayHello = () => Console.WriteLine("Hello");
            Action<string> displayName = name => Console.WriteLine(name);

            Func<int> simpleNumber = () => 0;
            Func<int,int,int> adder = (a,b) => a+b;

            // Adder adder = AddNumbers;
            // sayHello("hello");
            // int sum = adder(1,2);
            CheckTemperature(text => Console.WriteLine(text), logger, logger);
        }

        public void CheckTemperature(Logger tooLow, Logger optimal, Logger tooWarm)
        {
            var random = new Random();
            int temperature = 15;
            while(true)
            {
                var difference = random.Next(-5,5);
                temperature += difference;
                if(temperature < 10)
                {
                    tooLow("Too low");
                }
                else if(temperature >= 10 && temperature <= 25)
                {
                    optimal("Optimal.");
                }
                else
                {
                    tooWarm("Too warm.");
                }
                Thread.Sleep(500);
            }
        }

        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        public int AddNumbers(int a, int b) => a+b;

        public int Calculate()
        {
            return 1;
        }

        public void DisplayResult(int result)
        {

        } 
    }
}