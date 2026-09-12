using System;

using Exceptions;

public class ApresentacaoBoa
{
	public void Executar()
	{
		var servico = new ServicoFaturamento();

		try
		{
			servico.EmitirNotaFiscal();
		}
		catch (FalhaComunicacaoSefazException ex) // Captura específica
		{
			Console.WriteLine($"✅ [BOM] Capturamos um erro de infraestrutura previsível.");
			Console.WriteLine($"Motivo: {ex.Message}");
			Console.WriteLine($"\n--- INÍCIO DO STACK TRACE --- \n{ex.StackTrace}\n--- FIM DO STACK TRACE ---\n");
		}
		catch (FaturamentoException)
		{
			Console.WriteLine("Erro de negócio genérico.");
			throw; // Propaga sem perder a pilha se fosse tratar em outro lugar
		}
	}
}
