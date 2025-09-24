using System;
using System.Threading;
class pacMan
{
static void Main()
    {
        string line = "....................................";
        int length = line.Length;
        for(int i=0;i<length;i++)
        {
            Console.Write("\r" + new string(' ', i) + "Ashfa" + line.Substring(i + 1));
            Thread.Sleep(200);
            Console.Write("\r" + new string(' ', i+1) + line.Substring(i + 1));
            Thread.Sleep(200);
        }
        Console.Write("\r" + new string(' ',length) + "Ashfa");
        Console.WriteLine("\n\nGame Over!Pac-Man ate all the dots");
    }
}