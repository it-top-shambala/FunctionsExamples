namespace FunctionsExamples.Example3
{
    public class Program
    {
        static void Main()
        {
            int[] array = new int[] { 1, 3, 0, -1 };

            int[] res = MinElementOfArray(array);
            int min = res[0];
            int number = res[1];
            
            PrintArray(array);
            Console.WriteLine($"min = {min}, index = {number}");
            
            MinElementOfArray2(array, out var min2, out var number2);
            Console.WriteLine($"min = {min2}, index = {number2}");

            var res2 = MinElementOfArray3(array);
            //Console.WriteLine($"min = {res2.Item1}, index = {res2.Item2}");
            Console.WriteLine($"min = {res2.min}, index = {res2.index}");
        }
        
        static int[] MinElementOfArray(int[] arr)
        {
            int min = arr.Min();
            int numberOfMin = Array.IndexOf(arr, min);

            return new int[] { min, numberOfMin };
        }
        
        static void MinElementOfArray2(int[] arr, out int min, out int index)
        {
            min = arr.Min();
            index = Array.IndexOf(arr, min);
        }

        static (int min, int index) MinElementOfArray3(int[] arr)
        {
            int min = arr.Min();
            int index = Array.IndexOf(arr, min);
            return (min, index);
        }
        
        static void PrintArray(int[] arr)
        {
            Console.Write("[ ");
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("]");
        }
    }
}