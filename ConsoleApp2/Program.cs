// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            a[i] = rnd.Next(0, 100);
            Console.WriteLine("{0,2}", a[i]);

        }
        Console.WriteLine();
        int min = a[0];
        for (int i = 1; i < 10; i++) ;
        min = Math.Min(min,a[0]);
        Console.WriteLine(" Минимальное значение:" + min);
        Console.ReadKey();
    }

        
}



