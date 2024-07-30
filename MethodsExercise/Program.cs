using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise
{
    public class Program
    {
        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"One day, {name} went shopping. They wanted a shirt that was {color}, with the logo of {band} on it. They also wanted to get a stuffed animal of a {animal}.");
        }

        public static int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo; 
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Modulus(int numOne, int numTwo)
        {
            return numOne % numTwo;
        }

        static void Main(string[] args)
        {
            int added = Add(2, 2);
            Console.WriteLine(added);

            int subtracted = Subtract(4, 1);
            Console.WriteLine(subtracted);

            int multiplied = Multiply(40, 2);
            Console.WriteLine(multiplied);

            int divided = Divide(40, 4);
            Console.WriteLine(divided);

            int modded = Modulus(30, 4);
            Console.WriteLine(modded);


           MadLib();

        }
    }
}
