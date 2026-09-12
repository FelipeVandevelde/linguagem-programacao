# Passo 0: O Ponto de Partida

Aqui nós temos a base do nosso projeto, com apenas o arquivo principal da aplicação pronto para iniciar.

## 🧪 Momento de Teste

Neste laboratório utilizaremos um compilador C# online. 

1. Copie todo o conteúdo do arquivo `Program.cs` desta pasta.
2. Cole no editor do compilador online substituindo o código que estava lá.
3. Clique em **Run** (ou Executar).

**Resultado Esperado:** O console do compilador exibirá apenas a mensagem:
`Iniciando Sistema de Faturamento...`

Isso garante que todos estão com o ambiente funcionando.


# Mudanças

<details close>
<summary>

### - `HelloWorld.cs`

**15 deletions**

</summary>

```diff
@@ -1,15 +0,0 @@

- using System;
- using System.Collections.Generic;
- using System.Linq;
- using System.Text.RegularExpressions;
- 
- namespace HelloWorld
- {
- 	public class Program
- 	{
- 		public static void Main(string[] args)
- 		{
- 			Console.WriteLine("Hello, World!");
- 		}
- 	}
- }
 ```
</details>

<details open>
<summary>

### + `Program.cs`

**12 additions**

</summary>

```diff
@@ -0,0 +1,12 @@

+ using System;
+ 
+ namespace Seminario
+ {
+     public class Program
+     {
+         public static void Main(string[] args)
+         {
+             Console.WriteLine("Iniciando Sistema de Faturamento...");
+         }
+     }
+ }

```

</details>

[**Ir para o Passo 1 ->**](../passo-1/README.md)