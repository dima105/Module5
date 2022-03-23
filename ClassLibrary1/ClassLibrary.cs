namespace ClassLibrary
{

    public class ArrayWorker
    {
        public ArrayWorker()
        {
        }
        public int[] Invert(int[] arrayWork)
        {
            var x = new int[arrayWork.Length];
            for (int i = 0; i <= arrayWork.Length - 1; i++)
            {
                x[i] = arrayWork[arrayWork.Length - 1 - i];
            }
            return x;
        }
        public int[] Insert(ref int[] source, int newValue, int index)
        {
            var newArrayWork = new int[source.Length + 1];
            newArrayWork[index] = newValue;
            for (int i = 0; i < index; i++)
            {
                newArrayWork[i] = source[i];
            }
            for (int i = index; i < source.Length; i++)
            {
                newArrayWork[i + 1] = source[i];
            }
            return newArrayWork;
        }
    }
    public class Cone
    {

        public Cone(double radius, double height)
        {
            _radius = radius;
            _height = height;
        }

        private double _radius;
        private double _height;

        public double SquareSide()
        {
            return Math.PI * _radius * _radius;
        }

        public double SquareShape()
        {
            return Math.PI * _radius * (_radius + Math.Sqrt(_radius * _radius + _height * _height));
        }

    }
}