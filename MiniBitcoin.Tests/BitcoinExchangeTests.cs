using MiniBitcoin.ConsoleApp;
namespace MiniBitcoin.Tests;
public class BitcoinExchangeTests
{
 [Fact] public void BuyConvertsBrlToBtc(){var w=new Wallet(1000);var x=new BitcoinExchange(w,new BitcoinQuote(100000));var t=x.Buy(500);Assert.Equal(500,w.BalanceBrl);Assert.Equal(.005m,w.BalanceBtc);Assert.Equal(TransactionType.Compra,t.Type);Assert.Single(x.Transactions);}
 [Fact] public void BuyRejectsInsufficientFunds(){var w=new Wallet(100);var x=new BitcoinExchange(w,new BitcoinQuote(100000));Assert.Throws<InvalidOperationException>(()=>x.Buy(200));Assert.Equal(100,w.BalanceBrl);Assert.Empty(x.Transactions);}
 [Theory][InlineData(0)][InlineData(-10)] public void BuyRejectsInvalidAmount(decimal v){var x=new BitcoinExchange(new Wallet(100),new BitcoinQuote(100000));Assert.Throws<ArgumentOutOfRangeException>(()=>x.Buy(v));}
 [Fact] public void SellConvertsBtcToBrl(){var w=new Wallet(0,.01m);var x=new BitcoinExchange(w,new BitcoinQuote(100000));var t=x.Sell(.005m);Assert.Equal(.005m,w.BalanceBtc);Assert.Equal(500,w.BalanceBrl);Assert.Equal(TransactionType.Venda,t.Type);}
 [Fact] public void SellRejectsInsufficientBtc(){var x=new BitcoinExchange(new Wallet(0,.001m),new BitcoinQuote(100000));Assert.Throws<InvalidOperationException>(()=>x.Sell(.002m));Assert.Empty(x.Transactions);}
 [Fact] public void PortfolioUsesCurrentQuote(){var q=new BitcoinQuote(100000);var x=new BitcoinExchange(new Wallet(100,.01m),q);Assert.Equal(1100,x.GetTotalPortfolioBrl());q.Update(200000);Assert.Equal(2100,x.GetTotalPortfolioBrl());}
 [Fact] public void KeepsBuyAndSellHistory(){var x=new BitcoinExchange(new Wallet(1000),new BitcoinQuote(100000));x.Buy(500);x.Sell(.002m);Assert.Equal(2,x.Transactions.Count);Assert.Equal(TransactionType.Compra,x.Transactions[0].Type);Assert.Equal(TransactionType.Venda,x.Transactions[1].Type);}
}
