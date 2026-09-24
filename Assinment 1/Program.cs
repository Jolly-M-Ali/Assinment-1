namespace Assinment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  1 -Write a program that allows the user to enter a number then print it.

            Console.Write("Enter a number: ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            Console.WriteLine("You entered: " + number);

            //  2 -Write C# program that Convert a string to an integer, but the string contains non-numeric characters.
            //And mention what will happen 

            string x = Console.ReadLine();
            x = "abc";
            int num = Convert.ToInt32(x);
            Console.WriteLine(num);

            //it will crashed because convert can not convert a string that contains non-numeric characters to an integer.
            //It will throw a System.FormatException.

            //3  -Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

        }
    }
}
