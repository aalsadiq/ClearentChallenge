namespace ClearentChallenge
{
    /// <summary>
    /// This class represents the Person Model 
    /// @author: Ahmed Alsadiq
    /// @updated: 5/25/18
    /// </summary>
    public class Person : IPerson
    {
        public double TotalPersonIntrest { get; set; }
        public IWallet[] Wallets { get; set; }

        // Default Constructor
        public Person()
        {

        }

    // Constructor by passing an Array of Wallets
        public Person(IWallet[] wallets)
        {
            Wallets = wallets;
        }

        // This method returns the value of the intrest on each card as part of an Array
        /*public double[] TotalCardsIntrest(ICard[] cards)
        {
            for (int i = 0 ; i < cards.Length;i++)
            {
                TotalPersonIntrest[i] = cards[i].SimpleIntrest();
            }

            return TotalPersonIntrest;
        }*/

        // This Method returns the value of the total intrest for the person
        public double TotalCardsIntrest(ICard[] Cards)
        {
            foreach (var card in Cards)
            {
                TotalPersonIntrest += card.SimpleIntrest();
            }


            return TotalPersonIntrest;
        }

        // This method returns the value of the intrest on each Wallet as part of an Array
        public double TotalWalletIntrest(IWallet[] Wallets)
        {
            foreach (var wallet in Wallets)
            {
                TotalPersonIntrest += wallet.TotalCardsIntrest();
            }
            return TotalPersonIntrest;
        }

        public double TotalWalletIntrest()
        {
            foreach (var wallet in Wallets)
            {
                TotalPersonIntrest += wallet.TotalCardsIntrest();
            }
            return TotalPersonIntrest;
        }
    }
}
