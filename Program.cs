using System.IO.Pipelines;

internal class Program
{
    private static void Main(string[] args)
    {
        string check;
        int first_number;
        int second_number;
        int result;
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
                case '&':
                    result = first_number & second_number;

                    Console.WriteLine("(Decimal) {0} & {1} = {2}", first_number, second_number, result);

                    Console.WriteLine("(Binary) {0} & {1} = {2}", 
                    Convert.ToString(first_number, 2), 
                    Convert.ToString(second_number, 2), 
                    Convert.ToString(result, 2)); 

                    Console.WriteLine("(Hexadecimal) {0} & {1} = {2}", 
                    Convert.ToString(first_number, 16), 
                    Convert.ToString(second_number, 16), 
                    Convert.ToString(result, 16));

                    break;

                case '|':
                    result = first_number | second_number;
                    
                    Console.WriteLine("(Decimal) {0} | {1} = {2}", first_number, second_number, result);

                    Console.WriteLine("(Binary) {0} | {1} = {2}", 
                    Convert.ToString(first_number, 2), 
                    Convert.ToString(second_number, 2), 
                    Convert.ToString(result, 2)); 

                    Console.WriteLine("(Hexadecimal) {0} | {1} = {2}", 
                    Convert.ToString(first_number, 16), 
                    Convert.ToString(second_number, 16), 
                    Convert.ToString(result, 16));

                    break;

                case '^':
                    result = first_number ^ second_number;
                    
                    Console.WriteLine("(Decimal) {0} ^ {1} = {2}", first_number, second_number, result);

                    Console.WriteLine("(Binary) {0} ^ {1} = {2}", 
                    Convert.ToString(first_number, 2), 
                    Convert.ToString(second_number, 2), 
                    Convert.ToString(result, 2)); 

                    Console.WriteLine("(Hexadecimal) {0} ^ {1} = {2}", 
                    Convert.ToString(first_number, 16), 
                    Convert.ToString(second_number, 16), 
                    Convert.ToString(result, 16));

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