using System;

using Exceptions;

public class ServicoFaturamento
{
    public void EmitirNotaFiscal()
    {
        ValidarDados();
        ConectarSefaz(); // O erro vai estourar aqui
    }

    private void ValidarDados()
    {
        // Tudo certo com os dados...
    }

    private void ConectarSefaz()
    {
        // Simula uma falha de infraestrutura profunda na pilha
        throw new FalhaComunicacaoSefazException("Timeout na porta 443 da API Sefaz.");
    }
}
