using MiniBitcoin.ConsoleApp;
namespace MiniBitcoin.Tests;
public class WalletTests
{
 [Fact] public void RejectsNegativeInitialBalances(){Assert.Throws<ArgumentOutOfRangeException>(()=>new Wallet(-1,0));Assert.Throws<ArgumentOutOfRangeException>(()=>new Wallet(0,-1));}
 [Fact] public void DebitBrlUpdatesBalance(){var w=new Wallet(100);w.DebitBrl(40);Assert.Equal(60,w.BalanceBrl);}
 [Fact] public void RejectsInsufficientBrlWithoutChangingBalance(){var w=new Wallet(50);Assert.Throws<InvalidOperationException>(()=>w.DebitBrl(60));Assert.Equal(50,w.BalanceBrl);}
 [Fact] public void RejectsInvalidDebit(){var w=new Wallet(50,1);Assert.Throws<ArgumentOutOfRangeException>(()=>w.DebitBrl(0));Assert.Throws<ArgumentOutOfRangeException>(()=>w.DebitBtc(-1));}
 [Fact] public void RejectsInsufficientBtc(){var w=new Wallet(0,.001m);Assert.Throws<InvalidOperationException>(()=>w.DebitBtc(.002m));}
}
