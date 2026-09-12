using Tyuiu.KorovinMK.Sprint0.Task4.V0.Lib;
namespace Tyuiu.KorovinMK.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(7, 8));

            Console.WriteLine(DataService.Subtraction(12, 8));

            Console.WriteLine(DataService.Multiplication(7, 9));

            Console.WriteLine(DataService.Division(64, 8));

            Console.ReadKey();
        }
    }   
}
