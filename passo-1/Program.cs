using System;

using Exceptions;

namespace Seminario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Sistema de Faturamento...");
			
            // Testando a nossa nova exceção customizada
			throw new FalhaComunicacaoSefazException("Simulando erro de comunicação");
            
            Console.WriteLine("... Continuação do código ...");
        }
    }
}
