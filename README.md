# ₿ MiniBitcoin

Aplicação acadêmica desenvolvida em C# e .NET para simulação e gerenciamento de uma carteira de Bitcoin.

O projeto permite trabalhar com saldo em reais (BRL), saldo em Bitcoin (BTC), cotação, operações de compra e venda e acompanhamento do histórico de transações.

## 🎯 Objetivo do Projeto

Desenvolver uma aplicação de console que simule operações básicas de uma carteira de criptomoedas, aplicando conceitos de programação orientada a objetos, regras de negócio e testes automatizados.

## 🚀 Funcionalidades

- **Gestão de carteira:** controle dos saldos em BRL e BTC.
- **Cotação do Bitcoin:** consulta e utilização do preço do Bitcoin.
- **Compra de Bitcoin:** simulação de compras utilizando saldo disponível em reais.
- **Venda de Bitcoin:** conversão de Bitcoin em reais.
- **Histórico de transações:** registro das operações realizadas.
- **Patrimônio consolidado:** acompanhamento do valor total da carteira.

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Aplicação |
|---|---|
| C# | Linguagem de programação |
| .NET 10 | Plataforma de desenvolvimento |
| xUnit | Testes unitários |
| Git | Controle de versão |
| GitHub | Hospedagem do código |

## 📁 Estrutura do Projeto

```text
MiniBitcoin/
│
├── MiniBitcoin.Console/
│   └── Aplicação principal
│
├── MiniBitcoin.Tests/
│   └── Testes unitários
│
├── MiniBitcoin.sln
├── .gitignore
└── README.md
```

## ⚙️ Como executar o projeto

### 1. Pré-requisitos

- .NET 10 SDK instalado.
- Git instalado.
- Visual Studio Code ou outra IDE compatível.

### 2. Clonar o repositório

```bash
git clone https://github.com/William-lazaro/MiniBitcoin.git
```

### 3. Entrar na pasta

```bash
cd MiniBitcoin
```

### 4. Restaurar dependências

```bash
dotnet restore
```

### 5. Executar a aplicação

```bash
dotnet run --project MiniBitcoin.Console/MiniBitcoin.Console.csproj
```

## 🧪 Testes Automatizados

O projeto utiliza xUnit para verificar o comportamento das funcionalidades e as regras de negócio.

Para executar os testes, utilize:

```bash
dotnet test
```

**Última validação realizada:** 17 testes aprovados e nenhuma falha.

## 📚 Conceitos Aplicados

- Programação orientada a objetos.
- Separação entre aplicação e testes.
- Testes unitários.
- Validação de regras de negócio.
- Desenvolvimento orientado a testes (TDD).
- Versionamento com Git.
- Conventional Commits.

## 👨‍💻 Projeto Acadêmico

Projeto desenvolvido como atividade acadêmica da disciplina de **Gestão e Qualidade de Software**.

