using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            string a_temp = "";
            string b_temp = "";


            while (true)
            {
                Console.WriteLine("1 -- +");
                Console.WriteLine("2 -- -");
                Console.WriteLine("3 -- *");
                Console.WriteLine("4 -- /");
                string Operation = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Enter a: ");
                a_temp = Console.ReadLine();
                Console.WriteLine("Enter b: ");
                b_temp = Console.ReadLine();

                int.TryParse(a_temp, out int a);
                int.TryParse(b_temp, out int b);

                int result = Operation switch
                {
                    "1" => a + b,
                    "2" => a - b,
                    "3" => a * b,
                    "4" => b != 0 ? a / b : 0,
                    _ => 0
                };

                Console.WriteLine($"result: {result}");

            }



        }
    }
}
