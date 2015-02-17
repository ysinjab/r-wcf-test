
namespace Utils
{
    public static class Fibonacci
    {
        public static long Calculate(long n)
        {

            long a = 0;
            long b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (long i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
