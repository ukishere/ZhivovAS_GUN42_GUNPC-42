using System.IO.Pipelines;

internal class Program
{
    private static void Main(string[] args)
    {
        string check;
        int first_number;
        int second_number;
        string logic_operator;

        while(true)
        {
            Console.WriteLine("Enter first number:");

            if (!Int32.TryParse(Console.ReadLine(), out first_number))
            {
                Console.WriteLine("Not a number");
                continue;
            }

            Console.WriteLine("Enter second number:");

            if (!Int32.TryParse(Console.ReadLine(), out second_number))
            {
                Console.WriteLine("Not a number");
                continue;
            }

            Console.WriteLine("Enter operator:");

            logic_operator = Console.ReadLine();

            switch(logic_operator[0])
            {
                case '+':
                    Console.WriteLine("Result\n{0} + {1} = {2}", first_number, second_number, first_number+second_number );
                    break;

                case '-':
                    Console.WriteLine("Result\n{0} - {1} = {2}", first_number, second_number, first_number-second_number );
                    break;

                case '*':
                    Console.WriteLine("Result\n{0} * {1} = {2}", first_number, second_number, first_number*second_number );
                    break;

                case '/':
                    Console.WriteLine("Result\n{0} / {1} = {2}", first_number, second_number, first_number/second_number );
                    break;

                default:
                    Console.WriteLine("Wrong operator");
                    break;
            }

        Console.WriteLine("Type yes to continue");
        check = Console.ReadLine();

        if(check != "yes") return;
        }
    }
}