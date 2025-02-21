﻿using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A Pokemon is a special type of pokemon which likes to Poke others.
            //But at the end of the day, the Pokemon wants to keep statistics, about how many pokes it has managed to make.
            //The Pokemon pokes his target and then proceeds to poke another target.
            //The distance between his targets reduces his poke power.

            //You will be given the poke power the Pokemon has, N – an integer.

            //Then you will be given the distance between the poke targets, M – an integer.

            //Then you will be given the exhaustionFactor Y – an integer.

            //Your task is to start subtracting M from N until N becomes less than M,the Pokemon does not have enough power to reach the next target. 
            //Every time you subtract M from N that means you’ve reached a target and poked it successfully.
            //COUNT how many targets you’ve poked – you’ll need that count.
            //The PokeMon becomes gradually more exhausted.

            //IF N becomes equal to EXACTLY 50 % of its original value, you must divide N by Y, if it is POSSIBLE.
            //This DIVISION is between integers.
            //If a division is not possible, you should NOT do it.Instead, you should continue subtracting.
            //After dividing, you should continue subtracting from N, until it becomes less than M.
            //When N becomes less than M, you must take what has remained of N and the count of targets you’ve poked, and print them as output.

            //NOTE: When you are calculating percentages, you should be PRECISE at maximum.
            //Example: 505 is NOT EXACTLY 50 % from 1000, its 50.5 %.

            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int totalPokes = 0;
            int startingPower = powerN;
            double divideIf = (int)powerN * 0.5;

            while (powerN >= distanceM)
            {
                powerN -= distanceM;
                totalPokes++;
                if (powerN == divideIf && exhaustionFactorY != 0 && powerN >= exhaustionFactorY)
                {
                    powerN /= exhaustionFactorY;
                    if (powerN < distanceM) break;
                }
            }
            Console.WriteLine(powerN);
            Console.WriteLine(totalPokes);
        }
    }
}
