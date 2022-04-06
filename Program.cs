using System;
using System.Collections.Generic;
namespace multiTable
{
    class Program
    {
        static void Main(string[] args)
        {
        int [,] multiArray = new int[10,10];
        int[,] array2D = new int[3,2];
        int[,,] array3D = new int [2,3,4]
            {
                {   {45,1,16,17}, {4,47,21,68}, {21,28,32,76}   },
                {   {11,0,85,42}, {9,10,14,96}, {66,99,33,12}   }
            };   
        for(int i=0; i <10; i++)
        {
            for (int j=0; j<10;j++)
            {
                multiArray[i,j] = (i+1)*(j+1);
            }
        };
            int counter = 0;
        foreach(int i in multiArray)
        {
            counter ++;
            Console.WriteLine(counter);
        };
            Console.WriteLine(array2D[0,1]);
            Console.WriteLine(array3D[1,0,3]);
            Console.WriteLine (multiArray[9,9]);

        }


        }
    }

