namespace ReverseArray
{
    internal class Program
    {
        static void ReverseArray(string[] array)
        {
            int n = array.Length;

            Console.WriteLine("Array Length ::" + n);

            for (int i = 0; i < n / 2; i++)
            {
                string temp = array[i];

                Console.WriteLine("temp Value ::" + temp);

                array[i] = array[n - i - 1];

                Console.WriteLine("array[i] ::" + array[i]);

                array[n - i - 1] = temp;
            }
        }

            static void Main(string[] args)
            {
                string[] _inputArray = { "Apple", "Banana", "Orange", "Mango" };

                Console.WriteLine("Input Array ::");

                foreach (string x in _inputArray)
                {
                    Console.WriteLine(x);
                }

                ReverseArray(_inputArray);

                Console.WriteLine("Reversed Array");

                foreach(string x in _inputArray)
                {
                    Console.WriteLine(x);
                }

            }
        }
    }

