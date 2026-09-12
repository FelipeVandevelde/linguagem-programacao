using System;

namespace Seminario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("====== BEM-VINDO AO SEMINÁRIO ======\n");

            Console.WriteLine("CENÁRIO 1: O custo do diagnóstico perdido");
            Console.WriteLine("Apertando o botão de faturar...");
            
            var cenarioRuim = new ApresentacaoRuim();
            cenarioRuim.Executar(); 
            
            Console.WriteLine("\n===================================================\n");

            Console.WriteLine("CENÁRIO 2: Hierarquia própria e propagação preservada");
            Console.WriteLine("Apertando o botão de faturar...");
            
            var cenarioBom = new ApresentacaoBoa();
            cenarioBom.Executar();


            Console.WriteLine("... Continuação do código ...");
        }
    }
}
