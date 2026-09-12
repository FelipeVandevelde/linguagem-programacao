using System;

using Exceptions;

public class ApresentacaoRuim
{
	public void Executar()
	{
		var servico = new ServicoFaturamento();

		try
		{
			servico.EmitirNotaFiscal();
		}
		catch (Exception) // Captura genérica mascarando o problema
		{
			// Diagnóstico perdido: O console não dirá onde nem por que falhou.
			Console.WriteLine("❌ [RUIM] Ops! Ocorreu um erro na operação. Tente novamente.");
		}
	}
}
