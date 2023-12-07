namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBankAccount = new BankAccount("027213902");
            myBankAccount.Deposit(1000);
            myBankAccount.Withdraw(500);
            myBankAccount.output();
        }
    }
}