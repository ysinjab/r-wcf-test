using Core.Enums;
using System;
using System.ServiceModel;
using Utils;

namespace Redify45
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RedPill" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RedPill.svc or RedPill.svc.cs at the Solution Explorer and start debugging.
    public class RedPill : IRedPill
    {
        public long FibonacciNumber(long n)
        {
            if (n > 92)
            {
                var ex = new ArgumentOutOfRangeException("n", "Fib(>92) will cause a 64-bit integer overflow.");
                throw new FaultException<ArgumentOutOfRangeException>(ex, ex.Message);
            }
            if (n < -92)
            {
                var ex = new ArgumentOutOfRangeException("n", "Fib(<92) will cause a 64-bit integer overflow.");
                throw new FaultException<ArgumentOutOfRangeException>(ex, ex.Message);
            }
            return Fibonacci.Calculate(n);
        }

        public Guid WhatIsYourToken()
        {
            return new Guid("82e4f53e-43fd-4451-b28d-c8922a6e441b");
        }


        public string ReverseWords(string s)
        {
            if (s == null)
            {
                var ex = new ArgumentNullException("s", "Value cannot be null.");
                throw new FaultException<ArgumentNullException>(ex, ex.Message);
            }

            return StringHelper.ReverseWords(s);
        }


        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return TriangleType.Error;
            }
            else if ((a + b <= c) || (b + c <= a) || (a + c <= b))
            {
                return TriangleType.Error;
            }
            else if (a == b && a == c && b == c)
            {
                return TriangleType.Equilateral;
            }
            else if (a == b || a == c || b == c)
            {
                return TriangleType.Isosceles;
            }
            else
            {
                return TriangleType.Scalene;
            }
        }
    }
}
