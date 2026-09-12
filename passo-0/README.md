# Passo 0: O Ponto de Partida

Aqui nós temos nosso primeiro passo, remover o arquivo padrão e criar para termos apenas o arquivo principal da aplicação pronto para iniciar.

## 🧪 Momento de Teste

Começando por abrir o compilador online que utilizaremos [OneCompiler](https://onecompiler.com/csharp). 

1. Na parte esquerda selecione o icone de arquivos para poder visualizar os arquivos da nossa aplicação.
2. Aperte com o botão direito no arquivo "HelloWorld.cs" e selecione "Delete"
3. Crie o arquivo `Program.cs`.
5. Clique em **Run** (ou Executar).

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

<details close>
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

<footer>
  <div align="right">
  
  [**Ir para o Passo 1 →**](../passo-1/README.md)
  </div>

  <div align="left">
  
  [**← Voltar para inicio**](../README.md)
  </div>
</footer>
