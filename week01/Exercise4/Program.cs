using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter numbers to add to the list (type 0 to stop):");
        var numbersList = new System.Collections.Generic.List<int>();
        int input;


        while (true)
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input == 0)
                {
                    break;
                }
                numbersList.Add(input);
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        if (numbersList.Count > 0)
        {
            numbersList.Sort();

            int min = numbersList.First();
            int max = numbersList.Last();

            Console.WriteLine($"You entered the following numbers: {string.Join(", ", numbersList)}");
            Console.WriteLine($"The minimum value is: {min}");
            Console.WriteLine($"The maximum value is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}


