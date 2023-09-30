using System;

namespace DesafiosProgramacaoSCCLOUDS
{
    public class NumerosPrimos
    {
        public static List<int> PrimosRecursivos(int n)
        {
            if(n < 1)
            {
                Console.WriteLine("input inválido");
                return null;
            }

            if (n < 2)
                return new List<int>();
            
                
            else if(IsPrimo(n))
            {
                var primos = PrimosRecursivos(n - 1);
                primos.Add(n);
                return primos;
            }
            else
            {
                return PrimosRecursivos(n - 1);
            }
        }
       
        public static bool IsPrimo(int n, int i = 2)
        {
            if (n <= 2)
                return n == 2;
            if (n % i == 0)
                return false;
            if (i * i > n)
                return true;
            return IsPrimo(n, i + 1);
        }
        public static List<int> PrimosLinear(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("input inválido");
                return null;
            }
            var primos = new List<int>();
            for (int num = 2; num <= n; num++)
            {
                bool isPrimo = true;
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrimo = false;
                        break;
                    }
                }
                if (isPrimo)
                    primos.Add(num);
            }
            return primos;
        }
    }
}
