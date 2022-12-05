using System;

class Christmastree
{
    static void Main()
    {
        string x;
        Console.Write("Podaj wysokosc choinki: ");
        x = Console.ReadLine()!;
        int height = Convert.ToInt32(x);
        int help = 1;
        int help2 = height;
        for (int i = 0; i < help2; i++)
        {

            for (int j = 0; j < height; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < help; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            help++;
            height--;
        }
    }
}