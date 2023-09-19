using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {

        int n = 8000000;
        double[,] numbers;

        Stopwatch timer = new Stopwatch();
        numbers = GenRandomNumbers(n);

        timer.Start();
        AddNumbers(numbers, n);
        timer.Stop();
        Console.WriteLine("Additions");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms" + timer.ElapsedTicks + "Ticks" );

        timer.Start();
        MultiplyNumbers(numbers,n);
        timer.Stop();
        Console.WriteLine("Multiplications");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms" + timer.ElapsedTicks + "Ticks" );


        timer.Start();
        Sin(numbers,n);
        timer.Stop();
        Console.WriteLine("Sin");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms" + timer.ElapsedTicks + "Ticks" );

        timer.Start();
        Cos(numbers,n);
        timer.Stop();
        Console.WriteLine("Cos");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms" + timer.ElapsedTicks + "Ticks" );



        //int i;
        //for (i=0; i<n; ++i)
        //{
        //    Console.WriteLine(numbers[i,0] + " " + numbers[i,1] + numbers[i,2]);
        //}
    }

    static double[,] GenRandomNumbers(int count)
    {
        Random rand = new Random();
        double[,] num = new double[count, 3];
        for(int i=0; i< count; ++i)
        {
            num[i,0]= 100.0*rand.NextDouble();
            num[i,1]= 100.0*rand.NextDouble();
        }

        return num;
    }

    static void AddNumbers(double[,]nums, int count)
    {
        int i;
        for (i=0; i < count; ++i)
        {
            nums[i,2]= nums[i,0] + nums[i,1];
        }
    }

    static void MultiplyNumbers(double[,] nums, int count)
    {
        int i;
        for(i=0; i <count; ++i)
        {
            nums[i, 2] = nums[i, 0] * nums[i, 1];
        }
    }


     static void Sin(double[,] nums, int count)
    {
        int i;
        for(i=0; i <count; ++i)
        {
            nums[i, 2] = Math.Sin(nums[i, 0]); 
        }
    }
        static void Cos(double[,] nums, int count)
    {
        int i;
        for(i=0; i <count; ++i)
        {
            nums[i, 2] = Math.Cos(nums[i, 0]);
        }
    }



}
