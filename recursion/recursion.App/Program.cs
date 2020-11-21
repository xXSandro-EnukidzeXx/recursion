using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace recursion.App
{
    class Program
    {
        static void Main()
        {
            Debug.Assert(factorial(0) == 1);
            Debug.Assert(factorial(1) == 1);
            Debug.Assert(factorial(5) == 120);

            Debug.Assert(triangleNos(1) == 1);
            Debug.Assert(triangleNos(5) == 15);

            Debug.Assert(multiply(3, 4) == 12);
            Debug.Assert(exponents(2, 3) == 8);
            Debug.Assert(exponents(2, -3) == 0.125);

            Debug.Assert(gcd(45, 10) == 5);
            Debug.Assert(gcd(10, 45) == 5);

            Debug.Assert(elReverso("cat is somewhat running") == "running somewhat is cat");
            Debug.Assert(Xish("awful", "Game of Thrones season eight was irredeemably awful")==true);
            //I couldn't bothered to do elfish as it didn't seem that interesting and was shamelessly building up to this
        }

        public static int factorial(int n)
        {
            if(n<=1)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }

        public static int triangleNos(int n)
        {
            if (n == 1)
                return 1;
            return n + triangleNos(n - 1);
        }

        public static int multiply(int a, int b)
        {
            if(a == 0)
                return 0;
            return b + multiply(a - 1, b);
        }

        public static double exponents(int x, int n)
        {
            
            if (n == 0)
                return 1;
            if (n > 0)
                return x * exponents(x, n - 1);
            else
                return (1 / exponents(x, -n));
        }

        public static int gcd(int a, int b)
        {
            if (b > a)
            {
                int c = b;
                b = a;
                a = c;
            }
            if (b == 0)
            {
                return a;
            }
            int t = a % b;
            return gcd(b, t);
        }

        public static string elReverso(string source)
        {
            string[] aw = source.Split();
            List<string> lw = new List<string>(aw); 
            if (lw.Count == 1)
                return lw[0];
            string first = " " + lw[0];
            lw.RemoveAt(0);
            return elReverso(string.Join(" ", lw)) + first;
            
        }

        public static bool Xish(string x, string check)
        {
            if(x.Length > 1)
            {
                foreach (var i in x)
                {
                    bool a = Xish(Char.ToString(i), check);
                    if (a == false)
                        return a; 
                }
                return true;
                
            }
            else
            {
                if (check.Contains(x))
                    return true;
                else
                    return false;
            }
        }
    }
}
