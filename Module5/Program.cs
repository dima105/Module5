using ClassLibrary;

namespace Module5_1

{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] {1,3,5,7,9};
            
            ArrayWorker myObject = new ArrayWorker();
            
            Console.WriteLine(String.Concat (myObject.Invert(myArray) ));
        }
    }
}
