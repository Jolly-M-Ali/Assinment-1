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


            //Console.WriteLine("You entered: " + number);

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

            float p = 10.5f;
            float y = 2.5f;
            float z = p + y;
            Console.WriteLine(z)

;            //4- Write C# program that Extract a substring from a given string

            String str = "Hello";
            String substr = str.Substring(1, 3);
            Console.WriteLine(substr);

            //5-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            int a = 5;
            int b = a;
            a = 10;
            Console.WriteLine(b); // Output: 5
            //6 -Write C# program that Assigning one reference type variable to another and modifying
            //the object through one variable and mention what will happen

            string abc = "abc";
            string A = abc;
            abc = "xbc";
            Console.WriteLine(A); // Output: abc


            //7-Write C# program that take two string variables and print them as one variable 
             string str1 = "Hello";
            string str2 = "world";
            string str3 = str1 + " " + str2;
            Console.WriteLine(str3);


            //8- 
            int d;
            d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);
            // answer is 1 because the expression !(30 < 20) evaluates to true, and when converted to an integer, true is represented as 1 in C#.

            //9-
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            // answer is 6 1 because 13 / 2 performs integer division, which results in 6, and 13 % 2 calculates the remainder of the division,
            // which is 1. The output is formatted as "6 1"

            //10- 

            int numb = 1, za = 5;


            if (!(num <= 0))
                Console.WriteLine(++numb + za++ + " " + ++za);
            else
                Console.WriteLine(--numb + za-- + " " + --za);



            //d {7,7} because the condition !(num <= 0) evaluates to true since num is 1, which is greater than 0




            

        }
    }
}
