using System;

namespace Seminario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tentando emitir nota fiscal...\n");

            var servico = new ServicoFaturamento();
            
            // Aqui chamamos o método que, lá no fundo, vai estourar um erro.
            // Como não temos try-catch, o erro vai subir até quebrar o programa.
            servico.EmitirNotaFiscal();
            
            Console.WriteLine("... Continuação do código ...");
        }
    }
}
