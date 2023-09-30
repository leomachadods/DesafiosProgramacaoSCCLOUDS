using System;

namespace DesafiosProgramacaoSCCLOUDS
{
    public class Program
    {
       static void Main(string[] args)
        {
            foreach(int n in NumerosPrimos.PrimosRecursivos(50))
            {
                Console.WriteLine(n);
            }
        }
    }
}
