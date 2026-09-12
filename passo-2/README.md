# Passo 2: Simulando o Serviço de Faturamento

Aqui adicionamos a classe `ServicoFaturamento.cs`. Nela, o método `EmitirNotaFiscal()` chama um método privado chamado `ConectarSefaz()`, que é onde nossa exceção será gerada de forma proposital (simulando que a Sefaz caiu).

## 🧪 Momento de Teste

1. Crie o arquivo `ServicoFaturamento.cs` (contendo a Exception e a classe `ServicoFaturamento`).
2. Atualize o `Program.cs` para que apenas instancie o serviço e emita a nota, sem usar nenhum tratamento (`try-catch`).
3. Clique em **Run**.

**Resultado Esperado:** 
O programa também irá falhar (*crash*). Porém, repare no **Stack Trace natural** gerado no console:
- Ele mostra a falha que descrevemos na classe. 
- Mostra também que a falha originou na linha de `ConectarSefaz`, passou por `EmitirNotaFiscal` e subiu para o `Main`. 
- Está é a  **propagação em pilha (Call Stack)**!.

# Mudanças

<details close>
<summary>

### + `TratamentosErros/ServicoFaturamento.cs`

**23 additions**

</summary>

```diff
@@ -0,0 +1,23 @@

+ using System;
+ 
+ using Exceptions;
+ 
+ public class ServicoFaturamento
+ {
+     public void EmitirNotaFiscal()
+     {
+         ValidarDados();
+         ConectarSefaz(); // O erro vai estourar aqui
+     }
+ 
+     private void ValidarDados()
+     {
+         // Tudo certo com os dados...
+     }
+ 
+     private void ConectarSefaz()
+     {
+         // Simula uma falha de infraestrutura profunda na pilha
+         throw new FalhaComunicacaoSefazException("Timeout na porta 443 da API Sefaz.");
+     }
+ }
 ```
</details>

<details open>
<summary>

### `Program.cs`

**6 additions · 3 deletions**

</summary>

```diff
@@ -3,3 +0,0 @@

using System;

- using Exceptions;
- 
namespace Seminario

@@ -11,12 +11,17 @@

-             Console.WriteLine("Iniciando Sistema de Faturamento...");
+             Console.WriteLine("Tentando emitir nota fiscal...\n");

-             // Testando a nossa nova exceção customizada
+             var servico = new ServicoFaturamento();
-             throw new FalhaComunicacaoSefazException("Simulando erro de comunicação");
+ 
+             // Aqui chamamos o método que, lá no fundo, vai estourar um erro.
+             // Como não temos try-catch, o erro vai subir até quebrar o programa.
+             servico.EmitirNotaFiscal();

            Console.WriteLine("... Continuação do código ...");
 ```

</details>

<footer>
  <div align="right">
  
  [**Ir para o Passo 3 →**](../passo-3/README.md)
  </div>

  <div align="left">
  
  [**← Voltar para o Passo 1**](../passo-1/README.md)
  </div>
</footer>
