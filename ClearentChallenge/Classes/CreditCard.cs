namespace ClearentChallenge
{
    /// <summary>
    /// This class represents the CreditCard Model Parent to the different type of CreditCards 
    /// @author: Ahmed Alsadiq
    /// @updated: 5/25/18
    /// </summary>
    public class CreditCard: ICard
    {
        // Public Values
        public string CardType { get; set; }
        public double IntrestPercentage { get; set; }
        public double CardBalance { get ; set ; }

        // Default Constructor
        public CreditCard() { }
        
        // Constructor that Takes in all the information needed to instantiate a CreditCard Object.
        public CreditCard(string cardType, double balance, double intrest)
        {
            CardType = cardType;
            CardBalance = balance;
            IntrestPercentage = intrest;
        }
        
        // Calculating the SimpleIntrest for the CreditCard
        public double SimpleIntrest()
        {
            return CardBalance * IntrestPercentage;
        }
    }
}
