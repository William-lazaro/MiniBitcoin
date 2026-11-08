# MiniBitcoin
Aplicação acadêmica de console em C#/.NET para simular carteira de Bitcoin, cotação, compra, venda, extrato e patrimônio consolidado.

> **Atenção:** a cotação inicial de R$ 350.000,00 é fictícia. O usuário pode atualizá-la no menu. Não há integração com corretora, blockchain ou dinheiro real.

## Requisitos
- .NET 10 SDK
- Git

## Estrutura
- `MiniBitcoin.Console`: aplicação de console e regras de negócio.
- `MiniBitcoin.Tests`: testes unitários com xUnit.

## Executar
Na pasta raiz:
```bash
dotnet restore
dotnet run --project MiniBitcoin.Console/MiniBitcoin.Console.csproj
```

## Testar
```bash
dotnet test
```

## Funcionalidades e regras
- Carteira com saldo em BRL e BTC; não aceita saldos negativos.
- Débitos exigem valores positivos e saldo suficiente.
- Cotação simulada configurável pelo menu.
- Compra converte BRL em BTC pela cotação atual.
- Venda converte BTC em BRL pela cotação atual.
- BTC tratado com até 8 casas decimais.
- Extrato registra tipo, quantidades, cotação e data/hora.
- Patrimônio = saldo BRL + (saldo BTC × cotação atual).
- Não há taxas de operação nesta versão, pois a lista não exige esse cálculo.

## TDD e Conventional Commits
A lista solicita escrever os testes antes da implementação. Os testes estão organizados por carteira, cotação e operações. Para demonstrar o fluxo de commits solicitado, use mensagens compatíveis com as etapas realmente realizadas:
```bash
git add .
git commit -m "chore: initial project structure with console and xunit apps"
git add .
git commit -m "test(carteira): add unit tests for wallet balance validation"
git add .
git commit -m "feat(carteira): implement wallet entity and initial balance rules"
git add .
git commit -m "test(transacao): add unit tests for bitcoin buy and sell operations"
git add .
git commit -m "feat(transacao): implement bitcoin purchase and sale logic with quote validation"
git add .
git commit -m "test(extrato): add unit tests for transaction ledger and portfolio valuation"
git add .
git commit -m "feat(extrato): implement transaction history and portfolio summary"
git add .
git commit -m "feat(console): implement interactive menu for bitcoin wallet application"
git add .
git commit -m "refactor(core): improve code readability and organize namespaces"
git add .
git commit -m "docs: add comprehensive instructions in README.md"
```
> O pacote entregue contém o estado final do código; não contém um histórico Git retroativo. Para comprovar TDD, faça os commits durante o desenvolvimento, sem inventar datas ou etapas.

## Publicar no GitHub
Crie um repositório público vazio chamado `MiniBitcoin` e execute na pasta raiz:
```bash
git init
git add .
git commit -m "chore: initial project structure with console and xunit apps"
git branch -M main
git remote add origin URL_DO_SEU_REPOSITORIO
git push -u origin main
git log --oneline
```
