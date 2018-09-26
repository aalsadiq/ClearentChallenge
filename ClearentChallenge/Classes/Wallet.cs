namespace ClearentChallenge
{
    /// <summary>
    /// This class represents the Wallet Model 
    /// @author: Ahmed Alsadiq
    /// @updated: 5/25/18
    /// </summary>
    public class Wallet : IWallet
    {
        public  double TotalWalletIntrest { set; get; }
        public ICard[] Cards { get; set; }

        // Wallet constructor
        public Wallet()
        {
        }
        // Wallet Constructor by Passing Cards in
        public Wallet(ICard[] cards)
        {
            Cards = cards;
        }

        // This method returns the value of the intrest on each card that is built as part of the wallet
        public double TotalCardsIntrest()
        {
            foreach (var card in Cards)
            {
                TotalWalletIntrest += card.SimpleIntrest();
            }
            return TotalWalletIntrest;
        }

        // This method returns the value of the intrest on each card that are passed in as part of an array
        public double TotalCardsIntrest(ICard[] cards)
        {
            foreach (var card in cards)
            {
                TotalWalletIntrest += card.SimpleIntrest();
            }
            return TotalWalletIntrest;
        }

        
    }
}
