using System;

class Incrementalex
{
    static void Main(string[] userNames)
    {

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

        for (int i = 0; i < numbers.Length; i++) {
            Console.WriteLine("Straight numbers in Array :" + numbers[i]);
        }
        Console.WriteLine("for Loop completed ::"+ numbers.Length);
        //int j = 0;
        for (int i = numbers.Length-1; i >= 0 ; i--)
        {
            Console.WriteLine("Reverse Order : : " + numbers[i]);
        }


    }
}