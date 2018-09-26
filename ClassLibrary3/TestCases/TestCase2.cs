using Xunit;
using FluentAssertions;
using ClearentChallenge;

namespace ClassLibrary3.TestCases
{
    public class TestCase2
    {
        [Fact]
        public void
            Should_ReturnTheIntrestValueForAPersonAndTheirThreeCards_When_TheCardsBalanceisSetCorrectly_AndIntrestIsGenerated()
        {
            // Arrange
            var visa = new Visa(100);
            var mCard = new MC(100);
            var discover = new Discover(100);
            CreditCard[] cardArray1 = {visa, discover};
            ICard[] cardArray2 = {mCard};
            var wallet1 = new Wallet(cardArray1);
            var wallet2 = new Wallet(cardArray2);
            IWallet[] walletArray = {wallet1, wallet2};
            var person = new Person();

            // Action
            var personResult = person.TotalWalletIntrest(walletArray);
            var walletResult1 = wallet1.TotalCardsIntrest();
            var walletResult2 = wallet2.TotalCardsIntrest();

            // Assert
            personResult.Should().Equals(16);
            walletResult2.Should().Equals(5);
            walletResult1.Should().Equals(11);
        }
    }
}