# Projeto de Demonstração de Padrões de Projeto em C#

## Descrição
Este projeto demonstra a implementação de três importantes padrões de projeto usando C# e princípios de Programação Orientada a Objetos (OOP). O objetivo é fornecer exemplos práticos e reais de como esses padrões podem ser aplicados em situações do mundo real.

## Padrões Implementados

### 1. Singleton (Criacional)
- **Arquivo:** `DatabaseConnection.cs`
- **Descrição:** Implementa uma conexão de banco de dados como um Singleton, garantindo que apenas uma instância seja criada e usada em toda a aplicação.
- **Uso:** Ideal para recursos compartilhados, como conexões de banco de dados, pools de objetos ou caches.

### 2. Factory Method (Criacional)
- **Arquivo:** `DocumentFactory.cs`
- **Descrição:** Demonstra a criação de diferentes tipos de documentos (PDF, Word) usando o padrão Factory Method.
- **Uso:** Útil quando uma classe não pode antecipar o tipo de objetos que deve criar ou quando uma classe quer que suas subclasses especifiquem os objetos que cria.

### 3. Observer (Comportamental)
- **Arquivo:** `NewsAgency.cs`
- **Descrição:** Implementa um sistema de notícias onde os assinantes são notificados automaticamente quando novas notícias são publicadas.
- **Uso:** Adequado para situações onde um objeto precisa notificar automaticamente uma lista de outros objetos sobre mudanças em seu estado.

## Como Usar
Cada padrão está implementado em seu próprio arquivo de classe. Para ver os padrões em ação, você pode criar instâncias dessas classes em seu programa principal e chamar seus métodos conforme demonstrado nos comentários de uso em cada arquivo.

## Benefícios
- Demonstração prática de padrões de projeto comuns
- Código limpo e bem organizado seguindo princípios OOP
- Exemplos realistas que podem ser adaptados para uso em projetos reais

## Próximos Passos
- Implementar mais padrões de projeto
- Adicionar testes unitários para cada padrão
- Criar um projeto de exemplo que utilize múltiplos padrões em conjunto
 