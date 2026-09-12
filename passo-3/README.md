# Passo 3: O Erro Comum (Apresentação Ruim)

O erro mais comum que desenvolvedores cometem é se assustar com a "tela vermelha" de erro e tentar colocar um `try { ... } catch (Exception)` genérico em volta de tudo, apenas para o sistema não quebrar. 

## 🧪 Momento de Teste

1. Crie o arquivo `ApresentacaoRuim.cs`.
2. Atualize o `Program.cs` para chamar a execução deste cenário.
3. Clique em **Run**.

**Resultado Esperado:** 
O sistema **continuará rodando com sucesso** (sem quebrar ou parar), exibindo apenas a sua mensagem: `"❌ [RUIM] Ops! Ocorreu um erro na operação."` nos logs do console.

**A grande provocação do seminário:** Onde o erro aconteceu? O que exatamente quebrou? Foi o banco de dados? Foi a Sefaz? Faltou uma configuração? 
A resposta é: **nós não sabemos**. Ao engolir a falha, nós destruímos o diagnóstico e aumentamos absurdamente o tempo e o custo necessário para a equipe de suporte descobrir o problema na vida real.

# Mudanças

<details close>
<summary>

### + `TratamentosErros/ApresentacaoRuim.cs`

**21 additions**

</summary>

```diff
@@ -0,0 +1,21 @@

+ using System;
+ 
+ using Exceptions;
+ 
+ public class ApresentacaoRuim
+ {
+ 	public void Executar()
+ 	{
+ 		var servico = new ServicoFaturamento();
+ 
+ 		try
+ 		{
+ 			servico.EmitirNotaFiscal();
+ 		}
+ 		catch (Exception) // Captura genérica mascarando o problema
+ 		{
+ 			// Diagnóstico perdido: O console não dirá onde nem por que falhou.
+ 			Console.WriteLine("❌ [RUIM] Ops! Ocorreu um erro na operação. Tente novamente.");
+ 		}
+ 	}
+ }
 ```
</details>

<details open>
<summary>

### `Program.cs`

**6 additions · 6 deletions**

</summary>

```diff
@@ -8,17 +8,17 @@
        {
-             Console.WriteLine("Tentando emitir nota fiscal...\n");
+             Console.WriteLine("CENÁRIO: A Apresentação Ruim (Erro Engolido)\n");

-             var servico = new ServicoFaturamento();
+             var cenarioRuim = new ApresentacaoRuim();
- 
+             cenarioRuim.Executar();
-             // Aqui chamamos o método que, lá no fundo, vai estourar um erro.
+ 
-             // Como não temos try-catch, o erro vai subir até quebrar o programa.
+             Console.WriteLine("\n[Programa continuou executando, mas nós não sabemos a causa real do erro]\n");
-             servico.EmitirNotaFiscal();

            Console.WriteLine("... Continuação do código ...");
        }
 ```

</details>

<div style="display: flex; justify-content: space-between;">

<div>

[**← Voltar para o Passo 2**](../passo-2/README.md)

</div>

<div>

[**Ir para o Passo 4 →**](../passo-4/README.md)

</div>

</div>
