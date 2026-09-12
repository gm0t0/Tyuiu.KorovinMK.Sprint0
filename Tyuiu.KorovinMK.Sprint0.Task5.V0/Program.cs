using Tyuiu.KorovinMK.Sprint0.Task5.V0.Lib;
namespace Tyuiu.KorovinMK.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 8));
            Console.WriteLine("A - B = " + DataService.Subtraction(8, 6));
            Console.WriteLine("A * B = " + DataService.Multiplication(9, 4));
            Console.WriteLine("A / B = " + DataService.Division(10, 2));
            Console.ReadKey();
        }
    }
}

