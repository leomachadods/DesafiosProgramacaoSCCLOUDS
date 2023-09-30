using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosProgramacaoSCCLOUDS
{
    public class Fibonnaci
    {
        public static int FibonnaciRecursivo(int n)
        {
            if(n < 0)
            {
                Console.WriteLine("Insira um número válido!");
                return -1;
            }
            if (n < 2)
                return n;

            return FibonnaciRecursivo(n - 1) + FibonnaciRecursivo(n - 2);
        }
        public static int FibonnaciLinear(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Insira um número válido!");
                return -1;
            }
            if (n < 2)
                return n;

            int a = 0;
            int b = 1;
            for(int i = 2; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b;
        }
    }
}
