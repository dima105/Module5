using ClassLibrary;

namespace Module5_2

{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = new int[] { 1, 3, 5, 7, 9 };
            

            ArrayWorker myObject = new ArrayWorker();

            Console.WriteLine(String.Concat(myObject.Insert(ref source, 6, 3)));
          
        }
    }
}
