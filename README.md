# trilha-net-tdd-desafio
Desafio de projeto - Blindando Seu Código com TDD e Testes Unitários Usando .NET Core da [DIO](https://www.dio.me/users/uprogramador)

##

Este repositório contém um projeto console C# e um projeto de teste associado para demonstrar uma simples calculadora, que realiza operações de soma, subtração, multiplicação e divisão. O projeto tem uma classe `Calculadora` que mantém um histórico.

## Estrutura do Projeto

O projeto está estruturado em duas partes principais:

1. **Projeto Console (NewTalents):** Este projeto contém a classe `Calculadora` que implementa as operações matemáticas e mantém um histórico.

2. **Projeto de Testes (TestNewTalents):** Este projeto contém testes unitários para verificar a funcionalidade da classe `Calculadora`.

## Classe Calculadora

A classe `Calculadora` oferece as seguintes funcionalidades:

- `Somar(int valor1, int valor2)`: Realiza uma adição e armazena o resultado no histórico.
- `Subtrair(int valor1, int valor2)`: Realiza uma subtração e armazena o resultado no histórico.
- `Multiplicar(int valor1, int valor2)`: Realiza uma multiplicação e armazena o resultado no histórico.
- `Dividir(int valor1, int valor2)`: Realiza uma divisão e armazena o resultado no histórico. Lança uma exceção `DivideByZeroException` se for tentada uma divisão por zero.
- `Historico()`: Retorna o histórico das operações realizadas, limitado às últimas três operações.

## Testes Unitários

O projeto de testes `TestNewTalents` contém uma série de testes unitários para validar o funcionamento da classe `Calculadora`. Os testes cobrem diferentes cenários, incluindo operações válidas e uma exceção por divisão por zero.

## Baixando e Usando o Projeto

Se você deseja baixar e usar este projeto, siga as etapas abaixo:

### Requisitos Prévios

Certifique-se de ter o .NET 7.0 instalado no seu sistema. Você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/pt-br/download/dotnet/7.0).

### Clonando o Repositório

Você pode clonar este repositório usando o Git. Abra o terminal e execute o seguinte comando:

```bash
git clone https://github.com/rfagner/trilha-net-tdd-desafio.git
```

### Executando o Projeto

Depois de clonar o repositório, siga estas etapas para compilar e executar o projeto:

1. Abra um terminal e navegue até o diretório do projeto console (NewTalents) usando o comando `cd`:

```bash
cd NewTalents
```

2. Compile o projeto usando o seguinte comando:

```bash
dotnet build
```

3. Execute o projeto com:

```bash
dotnet run
```

Isso iniciará o aplicativo de console da calculadora.

### Executando os Testes

Para executar os testes do projeto, siga estas etapas:

1. Abra um terminal e navegue até o diretório do projeto de testes (TestNewTalents) usando o comando `cd`:

```bash
cd TestNewTalents
```

2. Execute os testes com:

```bash
dotnet test
```

Isso executará os testes e fornecerá feedback sobre o funcionamento da classe `Calculadora`.

Lembre-se de que este projeto foi desenvolvido usando o .NET 7.0. Certifique-se de que você está usando a versão correta do SDK para evitar problemas de compatibilidade.


