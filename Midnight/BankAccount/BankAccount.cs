namespace Midnight
{
    public class BankAccount
    {
        #region Description problem

        // Link: https://www.testdome.com/questions/c-sharp/account-test/38493?visibility=1&skillId=18

        // Level: Easy

        // Using only NUnitLite 1's Assert.AreEqual method, write tests for the Account class that cover the following cases:

        // The Deposit and Withdraw methods will not accept negative numbers.
        // Account cannot overstep its overdraft limit.
        // The Deposit and Withdraw methods will deposit or withdraw the correct amount, respectively.
        // The Withdraw and Deposit methods return the correct results.

        // Ps.: Has been use xUnit with FluentAssertions for Testes.

        #endregion

        public double Balance { get; private set; }
        public double OverdraftLimit { get; private set; }

        public BankAccount(double overdraftLimit)
        {
            this.OverdraftLimit = overdraftLimit > 0 ? overdraftLimit : 0;
            this.Balance = 0;
        }

        public bool Deposit(double amount)
        {
            if (amount >= 0)
            {
                this.Balance += amount;
                return true;
            }
            return false;
        }

        public bool Withdraw(double amount)
        {
            if (this.Balance - amount >= -this.OverdraftLimit && amount >= 0)
            {
                this.Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
