using MiniBitcoin.ConsoleApp;
namespace MiniBitcoin.Tests;
public class BitcoinQuoteTests
{
 [Fact] public void AcceptsPositiveQuote(){Assert.Equal(350000m,new BitcoinQuote(350000m).PriceBrl);}
 [Theory][InlineData(0)][InlineData(-1)] public void RejectsNonPositiveQuote(decimal v){Assert.Throws<ArgumentOutOfRangeException>(()=>new BitcoinQuote(v));}
 [Fact] public void UpdatesQuote(){var q=new BitcoinQuote(300000);q.Update(400000);Assert.Equal(400000,q.PriceBrl);}
}
