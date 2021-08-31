using Midnight;
using Xunit;
using FluentAssertions;

namespace MidnightTest
{
    public class BankAccountTest
    {
        [Fact]
        public void ShoudReturnFalseToInputNegativeNumbersForWithdrawAndDeposit()
        {
            BankAccount bankAccount = new BankAccount(-20);
            bankAccount.Withdraw(-150).Should().BeFalse();
            bankAccount.Deposit(-20).Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnFalseToOverstepOverdraftLimit()
        {
            BankAccount bankAccount = new BankAccount(-20);
            bankAccount.Withdraw(10).Should().BeFalse();
        }

        [Fact]
        public void ShouldDepositAndWithdrawCorrectAmount() 
        { 
            BankAccount bankAccount = new BankAccount(100);

            bankAccount.Deposit(200);
            bankAccount.Balance.Should().Be(200.0);

            bankAccount.Withdraw(10);
            bankAccount.Balance.Should().Be(190.0);
        }

        [Fact]
        public void ShouldReturnCorrectResultsForDepositAndWithdraw()
        {
            BankAccount bankAccount = new BankAccount(100);
            bankAccount.Withdraw(10).Should().BeTrue();
            bankAccount.Deposit(15).Should().BeTrue();
        }
    }
}
