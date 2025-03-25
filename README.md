# CommonConversions

**CommonConversions** é um projeto **didático** desenvolvido baseado no padrão de Arquitetura Limpa, utilizando .NET 9 como Console App e subdividido em projetos do tipo Class Library e Projetos Testes (xUnit, NUnit e MSUnit), com o objetivo de ensinar conceitos fundamentais de testes unitários em C#. Ele simula um conjunto de conversões comuns do dia a dia, permitindo a aplicação prática de testes automatizados utilizando diversas bibliotecas de apoio.

## 🧠 Objetivo

Demonstrar de forma prática:
- Como estruturar um projeto simples em C#
- Aplicar boas práticas de codificação
- Escrever testes unitários utilizando xUnit, NUnit ou MSTest
- Entender o padrão AAA e padrões de nomencltura nos testes
- Entender a utilização de diversas bibliotecas de apoio na escrita de testes como: Moq, NSubistitute, Bogus, FluentAssertions, AutoFixture
- Analisar as métricas de Cobertura de Código utilizando ferramentas open source
- Utilizar o console como interface simples para entrada e saída de dados

## 🎯 Funcionalidades

- ✅ Conversão de Celsius para Fahrenheit
- ✅ Conversão de Quilômetros para Milhas
- ✅ Conversão de Quilogramas para Libras
- ✅ Leitura de valores via console
- ✅ Interface de linha de comando amigável
- ✅ Testes unitários utilizando o padrão AAA

## 📦 Estrutura do Projeto

O projeto está dividido na seguinte **estrutura**:

```path
CommonConversions/
  ├── src/
  |  └── CommonConversions.Application
  |    └── Services/ 
  │     └── ConversionService.cs
  |  └── CommonConversions.ConsoleApp
  |   └── Program.cs 
  ├── tests/
  │ └── others/
  │    └── CommonConversions.Application.UnitTestsWithMSTest/
  |      └── ConversionsServiceTest.cs
  │    └── CommonConversions.Application.UnitTestsWithNUnit/
  |      └── Services/
  |          └──ConversionsServiceTest.cs
  │ └── CommonConversions.Application.UnitTests/
  |    └── ConversionsServiceTest.cs
```
  
## 🧪 Exemplo de Teste (xUnit)

```csharp
[Fact]
public void CelsiusToFahrenheit_ShouldReturn32_WhenInputIs0()
{
    // Arrange
    var service = new ConversionService();

    // Act
    var result = service.CelsiusToFahrenheit(0);

    // Assert
    Assert.Equal(32, result);
}
```

## 🚀 **Como Executar**

Clone o repositório:

```git
git clone https://github.com/seu-usuario/CommonConversions.git
```

Navegue até a pasta do projeto:

```
cd CommonConversions
```

Execute o projeto:

```
dotnet run
```

Execute os testes:

```
dotnet test
```

## 📘 **Licença**

Este projeto está licenciado sob a MIT License - veja o arquivo LICENSE para mais detalhes.

## 🤝 **Contribuição**

Este projeto foi criado para fins educacionais, mas contribuições são bem-vindas! Se você quiser adicionar novas conversões, melhorar o código ou os testes, fique à vontade para abrir um pull request.

## 👨‍🏫 **Público-Alvo**

- ✅ Estudantes de Engenharia de Software, Análise e Desenvolvimento de Sistemas ou áreas afins
- ✅ Professores que desejam material didático prático para ensinar testes em .NET
- ✅ Desenvolvedores iniciantes aprendendo TDD e testes automatizados
