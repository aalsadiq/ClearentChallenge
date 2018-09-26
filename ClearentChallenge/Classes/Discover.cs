namespace ClearentChallenge
{
    /// <summary>
    /// This class represents the Discover Card a child of the class CreditCard to the different type of 
    /// @author: Ahmed Alsadiq
    /// @updated: 5/25/18
    /// </summary>
    public class Discover : CreditCard
    {
        // Constructor to instantiate by passing in the balance
        public Discover(double balance)
        {
            CardType = "Discover";
            IntrestPercentage = 0.01;
            CardBalance = balance;
        }
    }
}
