namespace FunctionsExamples.Example1
{
    struct MyStruct
    {
        public int x;
        public int y;

        public MyStruct()
        {
            x = 10;
            y = 5;
        }
    }
    
    public class Program
    {
        static void Main()
        {
            int x = 10;
            int y = 5;
            
            Console.WriteLine($"x = {x}, y = {y}");
            
            Swap(x, y);
            
            Console.WriteLine($"x = {x}, y = {y}");
            
            SwapRef(ref x, ref y);
            
            Console.WriteLine($"x = {x}, y = {y}");

            MyStruct myStruct = new MyStruct();
            Console.WriteLine($"myStruct: x = {myStruct.x}, y = {myStruct.y}");
            S(ref myStruct);
            Console.WriteLine($"myStruct: x = {myStruct.x}, y = {myStruct.y}");
        }

        static void Swap(int a, int b)
        {
            Console.WriteLine($"a = {a}, b = {b}");
            
            int temp = a;
            a = b;
            b = temp;
            
            Console.WriteLine($"a = {a}, b = {b}");
        }
        
        static void SwapRef(ref int a, ref int b)
        {
            Console.WriteLine($"a = {a}, b = {b}");
            
            int temp = a;
            a = b;
            b = temp;
            
            Console.WriteLine($"a = {a}, b = {b}");
        }

        static void S(ref MyStruct myStruct)
        {
            int temp = myStruct.x;
            myStruct.x = myStruct.y;
            myStruct.y = temp;
        }
    }
}