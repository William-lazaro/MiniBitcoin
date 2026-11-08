namespace MiniBitcoin.ConsoleApp;
public sealed class BitcoinExchange
{
 private readonly Wallet _wallet; private readonly BitcoinQuote _quote; private readonly List<Transaction> _transactions=new();
 public Wallet Wallet=>_wallet; public BitcoinQuote Quote=>_quote; public IReadOnlyList<Transaction> Transactions=>_transactions.AsReadOnly();
 public BitcoinExchange(Wallet wallet,BitcoinQuote quote){_wallet=wallet??throw new ArgumentNullException(nameof(wallet));_quote=quote??throw new ArgumentNullException(nameof(quote));}
 public Transaction Buy(decimal brl){if(brl<=0)throw new ArgumentOutOfRangeException(nameof(brl));if(brl>_wallet.BalanceBrl)throw new InvalidOperationException("Saldo em BRL insuficiente.");var btc=decimal.Round(brl/_quote.PriceBrl,8,MidpointRounding.ToZero);if(btc<=0)throw new InvalidOperationException("Valor muito pequeno para comprar BTC.");_wallet.DebitBrl(brl);_wallet.CreditBtc(btc);var t=new Transaction(TransactionType.Compra,btc,brl,_quote.PriceBrl,DateTime.Now);_transactions.Add(t);return t;}
 public Transaction Sell(decimal btc){if(btc<=0)throw new ArgumentOutOfRangeException(nameof(btc));if(btc>_wallet.BalanceBtc)throw new InvalidOperationException("Saldo em BTC insuficiente.");btc=decimal.Round(btc,8,MidpointRounding.ToZero);var brl=decimal.Round(btc*_quote.PriceBrl,2,MidpointRounding.ToZero);if(brl<=0)throw new InvalidOperationException("Valor muito pequeno para vender BTC.");_wallet.DebitBtc(btc);_wallet.CreditBrl(brl);var t=new Transaction(TransactionType.Venda,btc,brl,_quote.PriceBrl,DateTime.Now);_transactions.Add(t);return t;}
 public decimal GetTotalPortfolioBrl()=>decimal.Round(_wallet.BalanceBrl+_wallet.BalanceBtc*_quote.PriceBrl,2,MidpointRounding.ToZero);
}
