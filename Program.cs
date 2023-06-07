using System;

class Program
{
    static void Main()
    {
        int[] array = GenerateArray(1000, 1, 6);

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int maxL = 0;
        int startI = 0;
        int curL = 1;
        int curStartI = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                curL++;
            }
            else
            {
                if (curL > maxL)
                {
                    maxL = curL;
                    startI = curStartI;
                }

                curL = 1;
                curStartI = i;
            }
        }


        if (curL > maxL)
        {
            maxL = curL;
            startI = curStartI;
        }

        Console.WriteLine("Самая длинная цепочка повторяющихся элементов:");
        for (int i = startI; i < startI + maxL; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Длина цепочки: " + maxL);
        Console.WriteLine("Начальный индекс: " + startI);

        Console.ReadLine();
    }

    static int[] GenerateArray(int length, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }
        return array;
    }

    static void PrintArray(int[] array)
    {
        for (int i=0;i<array.Length;i++)
            Console.Write(array[i]+" ");
        Console.WriteLine();
    }
}