using System;

namespace Seminario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("CENÁRIO: A Apresentação Ruim (Erro Engolido)\n");
            
            var cenarioRuim = new ApresentacaoRuim();
            cenarioRuim.Executar();

            Console.WriteLine("\n[Programa continuou executando, mas nós não sabemos a causa real do erro]\n");
            
            Console.WriteLine("... Continuação do código ...");
        }
    }
}
