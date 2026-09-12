# Passo 4: A Boa Prática (Apresentação Boa)

O arquivo `ApresentacaoBoa.cs` corrige o erro do Passo 3. Aqui nós utilizamos um bloco de captura específico: pegamos primeiro a nossa `FalhaComunicacaoSefazException` gerada no Passo 1. 

Isso nos permite ter um log rico em detalhes (incluindo todo o Stack Trace) e manter a aplicação resiliente.

## 🧪 Momento de Teste Final

1. Adicione o último arquivo `ApresentacaoBoa.cs` no seu compilador online.
2. Atualize o `Program.cs` (conforme os arquivos desta pasta) para rodar ambos os cenários em sequência.
3. Clique em **Run**.

**Resultado Esperado:** 
O console exibirá o Cenário 1 (mensagem inútil escondendo o erro) e, logo abaixo, executará o Cenário 2.
No Cenário 2, você verá a mensagem correta (`Timeout na porta 443`) e o **Stack Trace completo** detalhando o arquivo e o método exato de onde o erro surgiu (`ConectarSefaz`).

É assim que combinamos hierarquias personalizadas e controle de fluxo, garantindo que o programa não feche, mas que o log mantenha todo o custo e tempo de diagnóstico perto de zero!

# Mudanças

<details open>
<summary>

### + `TratamentosErros/ApresentacaoBoa.cs`

**27 additions**

</summary>

```diff
@@ -0,0 +1,27 @@

+ using System;
+ 
+ using Exceptions;
+ 
+ public class ApresentacaoBoa
+ {
+ 	public void Executar()
+ 	{
+ 		var servico = new ServicoFaturamento();
+ 
+ 		try
+ 		{
+ 			servico.EmitirNotaFiscal();
+ 		}
+ 		catch (FalhaComunicacaoSefazException ex) // Captura específica
+ 		{
+ 			Console.WriteLine($"✅ [BOM] Capturamos um erro de infraestrutura previsível.");
+ 			Console.WriteLine($"Motivo: {ex.Message}");
+ 			Console.WriteLine($"\n--- INÍCIO DO STACK TRACE --- \n{ex.StackTrace}\n--- FIM DO STACK TRACE ---\n");
+ 		}
+ 		catch (FaturamentoException)
+ 		{
+ 			Console.WriteLine("Erro de negócio genérico.");
+ 			throw; // Propaga sem perder a pilha se fosse tratar em outro lugar
+ 		}
+ 	}
+ }
```
</details>

<details open>
<summary>

### `Program.cs`

**4 additions · 4 deletions**

</summary>

```diff
@@ -8,17 +8,17 @@
        {
-            Console.WriteLine("CENÁRIO: A Apresentação Ruim (Erro Engolido)\n");
+            Console.WriteLine("CENÁRIO: A Apresentação Ruim (Erro Engolido)\n");

-            var cenarioRuim = new ApresentacaoRuim();
+            var cenarioBom = new ApresentacaoBoa();
-            cenarioRuim.Executar();
+            cenarioBom.Executar();

-            Console.WriteLine("\n[Programa continuou executando, mas nós não sabemos a causa real do erro]");
+            Console.WriteLine("\n[Programa continuou executando, e nos sabemos a causa real do erro]");

            Console.WriteLine("... Continuação do código ...");
          }
 ```

</details>

[**Veja o resultado final consolidado ->**](../resultado/README.md)
