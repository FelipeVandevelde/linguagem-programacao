using System;

namespace Seminario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("CENÁRIO: A Apresentação Boa\n");
            
            var cenarioBom = new ApresentacaoBoa();
            cenarioBom.Executar();

            Console.WriteLine("\n[Programa continuou executando, e nos sabemos a causa real do erro]");
            
            Console.WriteLine("... Continuação do código ...");
        }
    }
}
