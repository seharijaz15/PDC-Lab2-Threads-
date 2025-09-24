using System;
using System.Threading;

class RainSimulation
{
    static void Main()
    {
        string[] frames = new string[]
        {
@"
     . . . . . . . . . . . . . . . . .
     , , , , , , , , , , , , , , , , ,
     , , , , , , , , , , , , , , , , ,
           ~ ~ ~  A S H F A  ~ ~ ~
     ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' '
     . . . . . . . . . . . . . . . . .",
@"
     , , , , , , , , , , , , , , , , ,
     . . . . . . . . . . . . . . . . .
           ~ ~ ~  A S H F A  ~ ~ ~
     , , , , , , , , , , , , , , , , ,
     ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' '
     . . . . . . . . . . . . . . . . .",
@"
     ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' '
     . . . . . . . . . . . . . . . . .
           ~ ~ ~  A S H F A  ~ ~ ~
     , , , , , , , , , , , , , , , , ,
     . . . . . . . . . . . . . . . . .
     ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' '",
@"
     . . . . . . . . . . . . . . . . .
     ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' '
           ~ ~ ~  A S H F A  ~ ~ ~
     . . . . . . . . . . . . . . . . .
     , , , , , , , , , , , , , , , , ,
     ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' '"
        };

        Console.CursorVisible = false;

        for (int i = 0; i < 150; i++)
        {
            foreach (string frame in frames)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(frame);
                Thread.Sleep(120); // Slower for elegance
            }
        }

        Console.CursorVisible = true;
    }
}