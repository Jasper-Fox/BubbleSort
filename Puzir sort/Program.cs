namespace Puzir_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] A = new int[20];

            for (int i = 0; i < A.Length; i++)
            {
            A[i] = rand.Next(1, 100);
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine("\n");
            PSort(A);
            foreach (int a in A)
                Console.Write($"{a} ");         
        }

        static int[] PSort(int[] X)
        {
            for (int j = 0; j < X.Length; j++)          
                for (int i = X.Length - 1; i > j; i--)
                    if (X[i] < X[i - 1])
                    {
                        int a = X[i];
                        X[i] = X[i - 1];
                        X[i - 1] = a;
                    }                                           
            return X;
        }
    }
}
