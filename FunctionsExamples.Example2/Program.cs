namespace FunctionsExamples.Example2
{
    public class Program
    {
        static void Main()
        {
            int x = 5;
            int y = 10;
            int res = 0;
            Add(x, y, ref res);
            Console.WriteLine($"{x} + {y} = {res}");
            
            AddOut(x, y, out var result);
            Console.WriteLine($"{x} + {y} = {result}");
        }

        static void Add(int x, int y, ref int res)
        {
            res = x + y;
        }

        static void AddOut(in int x, int y, out int res)
        {
            res = x + y;
        }
    }
}