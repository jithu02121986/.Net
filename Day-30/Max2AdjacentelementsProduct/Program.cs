using System;

namespace Max2AdjacentelementsProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3, 4, 2 };
            int result = Max2AdjacentProductResult(arr);
            Console.WriteLine("Max product of two adjacent elements is: " + result);
        }
        public static int Max2AdjacentProductResult(int[] arr)
        {

            if (arr == null || arr.Length < 2)
            {
                
                Console.WriteLine("Array should have at least 2 elements");
            }

            int maxProduct = arr[0] * arr[1];

           
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int product = arr[i] * arr[i + 1];
                if (product > maxProduct)
                {
                    maxProduct = product;
                }
            }

            return maxProduct;
        }

    }
}
