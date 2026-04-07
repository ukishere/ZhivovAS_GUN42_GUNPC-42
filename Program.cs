using System.Formats.Asn1;
using System.IO.Pipelines;

internal class Program
{
    private static void Main(string[] args)
    {
        //Task A1
        Console.WriteLine("Task A1");

        int[] a1 = new int[8]; 
        a1[0] = 0;
        a1[1] = 1;

        Console.Write("{0} {1} ", a1.GetValue(0), a1.GetValue(1));

        for (int i = 2; i <= 7; i++)
        {
            a1[i] = a1[i-1] + a1[i-2];
            Console.Write("{0} ", a1.GetValue(i));
        }

        // Task A2
        Console.WriteLine("\n\nTask A2");

        string[] a2 = new string[11] {
                                        "January", 
                                        "February", 
                                        "March", 
                                        "April", 
                                        "May", 
                                        "June", 
                                        "July", 
                                        "August", 
                                        "September",
                                        "November",
                                        "December"
                                        };
     
        for (int i = 0; i <= 10; i++)
        {
            Console.Write("{0} ", a2.GetValue(i));
        } 

        //Task A3
        Console.WriteLine("\n\nTask A3");

        int[,] a3 = new int[3,3];
        a3[0,0] = 2;
        a3[0,1] = 3;
        a3[0,2] = 4;

        Console.WriteLine("{0} {1} {2}", a3[0,0], a3[0,1], a3[0,2]);

        for (int i = 1; i<= 2; i++)
        {
            for (int j = 0; j <= 2; j++)
            {
                a3[i,j] = a3[i-1,j] * a3[0,j];
                Console.Write("{0} ", a3[i,j]);  
            }
            Console.WriteLine();           
        }

        //Task A4
        Console.WriteLine("\nTask A4");

        double[] a41 = new double[] {1,2,3,4,5};
        double[] a42 = new double[] {Math.E, Math.PI};
        double[] a43 = new double[] {Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000)};

        double[][] a4 = new double[3][] {a41, a42, a43};

        for (int i = 0; i<= 2; i++)
        {
            for (int j = 0; j <= a4[i].Length-1; j++)
            {
                Console.Write("{0} ", a4[i][j]);
            }
            Console.WriteLine();           
        } 

        //Task B1
        Console.WriteLine("\nTask B1");

        int[] array = { 1, 2, 3, 4, 5 }; 
        int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

        Array.Copy(array, array2, 3); 

        for (int i=0; i <= array2.Length-1; i++)
        {
            Console.Write("{0} ", array2[i]);
        }

        //Task B2
        Console.WriteLine("\n\nTask B2");

        Array.Resize(ref array, array.Length*2);

        for (int i=0; i <= array.Length-1; i++)
        {
            Console.Write("{0} ", array[i]);
        }
    }
}