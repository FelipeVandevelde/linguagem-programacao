# Passo 1: Criando a Hierarquia de Exceções

Neste passo, criamos uma hierarquia própria de exceções. Isso é fundamental para que a nossa aplicação saiba diferenciar um erro de negócio de um erro de infraestrutura.

## 🧪 Momento de Teste

1. Crie o arquivo `Exceptions.cs` (contendo a `FaturamentoException` e `FalhaComunicacaoSefazException`).
2. Atualize o seu `Program.cs`  para forçamos o lançamento da nova exceção usando a palavra-chave `throw`.
3. Clique em **Run**.

**Resultado Esperado:** 
Desta vez a aplicação irá falhar (*crash*). No console em vermelho e sinalizando erro, você verá explicitamente a falha com o nome da nossa classe: `FalhaComunicacaoSefazException: Simulando erro de comunicação`. 

Isso prova que nosso tipo customizado de erro existe e está operante no sistema.

# Mudanças

<details close>
<summary>

### + `TratamentosErros/Exceptions.cs`

**20 additions**

</summary>

```diff
@@ -0,0 +1,20 @@

+ using System;
+
+ namespace Exceptions
+ {
+     public abstract class FaturamentoException : Exception
+     {
+         protected FaturamentoException(string message) : base(+ message) { }
+         protected FaturamentoException(string message, Exception innerException) : base(message, innerException) { }
+     }
+ 
+     public class FalhaComunicacaoSefazException : FaturamentoException
+     {
+         public FalhaComunicacaoSefazException(string message) : base(message) { }
+     }
+ 
+     public class NotaFiscalInvalidaException : FaturamentoException
+     {
+         public NotaFiscalInvalidaException(string message) : base(message) { }
+     }
+ }
 ```
</details>

<details open>
<summary>

### `Program.cs`

**5 additions**

</summary>

```diff
@@ -0,0 +3,3 @@

using System;

+ using Exceptions;

namespace Seminario

@@ -0,0 +13,16 @@

            Console.WriteLine("Iniciando Sistema de Faturamento...");
+ 
+             // Testando a nossa nova exceção customizada
+             throw new FalhaComunicacaoSefazException("Simulando erro de comunicação");
+
+             Console.WriteLine("... Continuação do código ...");
        }
 ```

</details>

[**Ir para o Passo 2 ->**](../passo-2/README.md)