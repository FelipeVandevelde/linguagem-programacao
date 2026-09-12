# Seminário de Tratamento de Erros

Este repositório contém a prática do seminário sobre tratamento de erros em C#. O foco é abordar a construção de uma hierarquia própria de exceções e demonstrar na prática a propagação pela pilha de chamadas (*Call Stack*). 

**O Grande Objetivo:**
Demonstrar a diferença entre capturar exceções da forma correta (usando hierarquias customizadas) e o erro comum de usar `catch (Exception)` genericamente. O erro genérico engole a falha e aumenta drasticamente o custo do diagnóstico no suporte de produção.

## 🛠️ Dinâmica do Laboratório (Como Executar)

Este laboratório foi construído para ser feito junto com a audiência utilizando um **compilador C# online** (ex: .NET Fiddle, Replit, etc), não exigindo que você instale nada no seu computador.

Em vez de projetos locais complexos, o código de cada passo está disponibilizado em **arquivos soltos (`.cs`)**. O objetivo é que você e o seu público copiem os trechos de código e assistam juntos aos testes na plataforma online.

Siga a trilha passo a passo:

1. **[Passo 0: O Ponto de Partida](./passo-0/README.md)** - Como preparar o ambiente online inicial.
2. **[Passo 1: Criando a Hierarquia de Exceções](./passo-1/README.md)** - Adicionando tipos customizados e testando como eles quebram a aplicação.
3. **[Passo 2: Simulando o Serviço de Faturamento](./passo-2/README.md)** - A falha real acontecendo no fundo da pilha e subindo até o topo sem tratamento.
4. **[Passo 3: O Erro Comum (Apresentação Ruim)](./passo-3/README.md)** - A prática de engolir a falha de forma genérica e a demonstração da perda total de rastreio do erro.
5. **[Passo 4: A Boa Prática (Apresentação Boa)](./passo-4/README.md)** - O tratamento com blocos específicos que salva a nossa aplicação ao mesmo tempo que guarda a preciosa pilha de rastreio (Stack Trace).

### Resultado Final

Todo o código completo, contendo todos os arquivos consolidados, está na pasta **[resultado](./resultado)**.