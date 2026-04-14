using System.Formats.Asn1;
using System.IO.Pipelines;

internal class Program
{
    private static void Main(string[] args)
    {
        //Task 1
        Console.WriteLine("Task 1");
        int[] a = new int[10]; 
        for(int i = 2; i < a.Length; i++)
        {
            if (i == 2)
            {
                a[0] = 0;
                a[1] = 1;
                Console.Write("{0} {1} ", a[0], a[1]);
            }
            a[i] = a[i-1] + a[i-2];    
            Console.Write("{0} ", a[i]);
        }

        //Task 2
        Console.WriteLine("\nTask 2");
        for(int i = 2; i <=20; i++)
        {
            if(i % 2 != 1)
            {
                Console.Write("{0} ", i);
            }
        }

        //Task 3
        Console.WriteLine("\nTask 3");
        for(int i = 1; i <= 5; i++)
        {
            for(int j = 1; j <= 5; j++)
            {
                Console.WriteLine("{0} * {1} = {2}", i, j, i*j);
            }
        }

        //Task 4
        Console.WriteLine("Task 4\nGuess the password:");

        string password = "qwerty";
        string attempt;
        do
        {
            attempt = Console.ReadLine();
        }
        while(password != attempt);
    }

}