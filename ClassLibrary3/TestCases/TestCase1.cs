using Xunit;
using FluentAssertions;
using ClearentChallenge;

namespace ClassLibrary3
{
    public class TestCase1
    {
        [Fact]
        public void Should_ReturnTheIntrestValueForAPersonAndTheirThreeCards_When_TheCardsBalanceisSetCorrectly_AndIntrestIsGenerated()
        {
            // Arrange
            var visa = new Visa(100);
            var mCard = new MC(100);
            var discover = new Discover(100);
            CreditCard[] array = {visa, mCard, discover};
            var person = new Person();
            
            // Act
            var personResult = person.TotalCardsIntrest(array);
            var visaResult = visa.SimpleIntrest();
            var mCardResult = mCard.SimpleIntrest();
            var discoverResult = discover.SimpleIntrest();

            // Assert
            personResult.Should().Equals(16);
            visaResult.Should().Equals(10);
            mCardResult.Should().Equals(5);
            discoverResult.Should().Equals(1);
        }
      
    }
}