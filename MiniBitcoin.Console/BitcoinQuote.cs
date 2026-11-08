namespace MiniBitcoin.ConsoleApp;
public sealed class BitcoinQuote
{
 public decimal PriceBrl {get;private set;}
 public BitcoinQuote(decimal price){Update(price);}
 public void Update(decimal price){if(price<=0)throw new ArgumentOutOfRangeException(nameof(price),"A cotação deve ser maior que zero.");PriceBrl=price;}
}
