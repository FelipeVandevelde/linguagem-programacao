# Revisao: Comparando práticas e apresentações

Para podermos ver a diferença das duas apresentações vamos executar elas em sequência. Isso nos permite analisar os dois em uma única instancia e comparar as duas práticas ainda no mesmo log.

## 🧪 Momento de Teste Final

1. Atualize o `Program.cs` para rodar ambos os cenários em sequência.
2. Clique em **Run**.

**Resultado Esperado:** 
O console exibirá o Cenário 1 (mensagem inútil escondendo o erro) e, logo abaixo, executará o Cenário 2.
No Cenário 2, você verá a mensagem correta (`Timeout na porta 443`) e o **Stack Trace completo** detalhando o arquivo e o método exato de onde o erro surgiu (`ConectarSefaz`).

É assim que combinamos hierarquias personalizadas e controle de fluxo, garantindo que o programa não feche, mas que o log mantenha todo o custo e tempo de diagnóstico perto de zero!

# Mudanças

### `Program.cs`

**14 additions · 5 deletions**

</summary>

```diff
@@ -8,27 +8,27 @@
        {
-             Console.WriteLine("CENÁRIO: A Apresentação Boa\n")
+             Console.WriteLine("====== REVISANDO RESULTADOS ======\n");

-             var cenarioBom = new ApresentacaoBoa();
+             Console.WriteLine("CENÁRIO 1: O custo do diagnóstico perdido");
-             cenarioBom.Executar();
+             Console.WriteLine("Apertando o botão de faturar...");

-             Console.WriteLine("\n[Programa continuou executando, e nos sabemos a causa real do erro]\n");
+             var cenarioRuim = new ApresentacaoRuim();
+             cenarioRuim.Executar(); 
+             
+             Console.WriteLine("\n===================================================\n");
+ 
+             Console.WriteLine("CENÁRIO 2: Hierarquia própria e propagação preservada");
+             Console.WriteLine("Apertando o botão de faturar...");
+             
+             var cenarioBom = new ApresentacaoBoa();
+             cenarioBom.Executar();

            Console.WriteLine("... Continuação do código ...");
        }
 ```

</details>

<footer>
  <div align="right">
  
  [**Ir para o inicio  →**](../README.md)
  </div>

  <div align="left">
  
  [**← Voltar para o Passo 4**](../passo-4/README.md)
  </div>
</footer>
