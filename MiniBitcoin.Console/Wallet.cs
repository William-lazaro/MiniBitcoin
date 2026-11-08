namespace MiniBitcoin.ConsoleApp;
public sealed class Wallet
{
 public decimal BalanceBrl { get; private set; }
 public decimal BalanceBtc { get; private set; }
 public Wallet(decimal initialBrl=0m, decimal initialBtc=0m)
 { if(initialBrl<0) throw new ArgumentOutOfRangeException(nameof(initialBrl)); if(initialBtc<0) throw new ArgumentOutOfRangeException(nameof(initialBtc)); BalanceBrl=initialBrl; BalanceBtc=decimal.Round(initialBtc,8); }
 public void CreditBrl(decimal v){Positive(v);BalanceBrl+=v;}
 public void DebitBrl(decimal v){Positive(v);if(v>BalanceBrl)throw new InvalidOperationException("Saldo em BRL insuficiente.");BalanceBrl-=v;}
 public void CreditBtc(decimal v){Positive(v);BalanceBtc+=decimal.Round(v,8,MidpointRounding.ToZero);}
 public void DebitBtc(decimal v){Positive(v);if(v>BalanceBtc)throw new InvalidOperationException("Saldo em BTC insuficiente.");BalanceBtc-=decimal.Round(v,8,MidpointRounding.ToZero);}
 private static void Positive(decimal v){if(v<=0)throw new ArgumentOutOfRangeException(nameof(v),"O valor deve ser maior que zero.");}
}
