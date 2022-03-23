using ClassLibrary;

namespace Module5_3

{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите радиус конуса: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту конуса: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Cone newCone = new Cone( radius, height);
           
            Console.WriteLine("Площадь поверхности основания = " + String.Concat(newCone.SquareSide()));
            Console.WriteLine("Полная площадь = " + String.Concat(newCone.SquareShape()));

        }
    }
}