using ClearentChallenge;
using FluentAssertions;
using Xunit;

namespace ClassLibrary3.TestCases
{
    public class TestCase3
    {
        [Fact]
        public void
            Should_ReturnTheIntrestValueForAPersonAndTheirThreeCards_When_TheCardsBalanceisSetCorrectly_AndIntrestIsGenerated()
        {
            // Arrange
            var visa = new Visa(100);
            var mCard = new MC(100);
            var discover = new Discover(100);
            CreditCard[] cardArray1 = {visa, mCard, discover};
            ICard[] cardArray2 = {discover};
            var wallet1 = new Wallet(cardArray1);
            var wallet2 = new Wallet(cardArray2);
            var person1 = new Person(new IWallet[] {wallet1});
            var person2 = new Person(new IWallet[] {wallet2});

            // Action
            var person1Result = person1.TotalWalletIntrest();
            var person2Result = person2.TotalWalletIntrest();
            var walletResult1 = wallet1.TotalCardsIntrest();
            var walletResult2 = wallet2.TotalCardsIntrest();

            // Assert
            walletResult1.Should().Equals(16);
            walletResult2.Should().Equals(1);
            
            person1Result.Should().Equals(16);
            person2Result.Should().Equals(1);
        }
    }
}