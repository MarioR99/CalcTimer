using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {

        int n = 8000;
        double[,] numbers;
        float[,] fnumbers;
        int[,] wholenumbers;

        Stopwatch timer = new Stopwatch();
        numbers = GenRandomNumbers(n);
        fnumbers = GenRandomFloatNumbers(n);
        wholenumbers = GenRandomWholeNumbers(n);


        timer.Start();
        AddNumbers(numbers, n);
        timer.Stop();
        Console.WriteLine("Addition with Doubles");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms" + timer.ElapsedTicks + "Ticks" );

        timer.Start();
        AddFloatNumbers(fnumbers, n);
        timer.Stop();
        Console.WriteLine("Addition with Floats");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms" + timer.ElapsedTicks + "Ticks" );

        timer.Start();
        MultiplyNumbers(numbers,n);
        timer.Stop();
        Console.WriteLine("Multiplications");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms" + timer.ElapsedTicks + "Ticks" );

        timer.Start();
        Expo(numbers,n);
        timer.Stop();
        Console.WriteLine("Math.Pow Power Function");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms" + timer.ElapsedTicks + "Ticks" );

        timer.Start();
        Sqrt(numbers,n);
        timer.Stop();
        Console.WriteLine("Math.Sqrt Power Function");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms" + timer.ElapsedTicks + "Ticks" );

        
        timer.Start();
        DirectMultiplicationExpo(numbers,n);
        timer.Stop();
        Console.WriteLine("Direct Multiplication Expo Function");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms" + timer.ElapsedTicks + "Ticks" );


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

     static float[,] GenRandomFloatNumbers(int count)
    {
        Random rand = new Random();
        float[,] num = new float[count, 3];
        for(int i=0; i< count; ++i)
        {
            num[i,0]= (float)(100.0 *rand.NextDouble());
            num[i,1]= (float)(100.0 *rand.NextDouble());
        }

        return num;
    }
     static int[,] GenRandomWholeNumbers(int count)
    {
        Random rand = new Random();
        int[,] num = new int[count, 3];
        for(int i=0; i< count; ++i)
        {
            num[i,0]= (int)(10.0 *rand.NextDouble());
            num[i,1]= (int)(10.0 *rand.NextDouble());
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

    static void AddFloatNumbers(float[,]nums, int count)
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

      static void DirectMultiplicationExpo(double[,] nums, int count)
    {

    for(int j=0; j< count; ++j)
    {
            double index = nums[j, 0];
            //Console.WriteLine("First number " + nums[j,0]);
    
        for (int i = 0; i < count + 1; i++)
        {
            nums[j,0] = nums[j,0]*index;
            //Console.WriteLine(nums[j,0]);
        }
        
    }


}

       static void Expo(double[,] nums, int count)
    {
        int i;
        for(i=0; i <count; ++i)
        {
            nums[i, 2] = Math.Pow (nums[i, 1],nums[i, 0]);
        }
    }

       static void Sqrt(double[,] nums, int count)
    {
        int i;
        for(i=0; i <count; ++i)
        {
            nums[i, 1] = Math.Sqrt (nums[i, 0]);
        }
    }

}
