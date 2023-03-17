using System;

namespace ClassOpdracht1
{
     // hier word een string gemaakt die dan kan gebruikt worden om een class te vinden en hem makkelijk te kunnen gebruiken
    internal class ClassStructureExercise
    {
        private readonly string accountName;

        internal ClassStructureExercise(string accountName)
        {
            this.accountName = accountName;
        }

        // greeting is een string met de inhoud hallo daarna word die aangeroepen in de concole dan kan de maker iets nog typen plus de speler zijn account naam
        internal void ShowGreetingInConsole()
        {
            string greeting = "hello";
            Console.WriteLine(greeting + " " + accountName);
        }

        // hier word een for loop gebruikt die gaat dan steeds omhoog als de console word gebruikt
        internal void Show1To10()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }


        // hier willen we de lengten weten van al dit hiervoor word een Mathf gebruikt
        internal double DistBetweenPoints(int x1, int y1, int x2, int y2)
        {

            int dx = x2 - x1;
            int dy = y2 - y1;

            double lengthSquared = (dx * dx) + (dy * dy);

            double length = Math.Sqrt(lengthSquared);
            return length;

        }

        // hier word de int gemutiplyd
        internal int MultiplyToPower2(int value)
        {
            int result = value * value;
            return result;
        }


        // in deze class word een string array gemaakt
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }
    }
}