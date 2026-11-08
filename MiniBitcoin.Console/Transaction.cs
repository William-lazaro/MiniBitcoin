namespace MiniBitcoin.ConsoleApp;
public enum TransactionType { Compra, Venda }
public sealed record Transaction(TransactionType Type, decimal BtcAmount, decimal BrlAmount, decimal BitcoinPriceBrl, DateTime Date);
