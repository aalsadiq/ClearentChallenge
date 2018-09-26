namespace ClearentChallenge
{
    /// <summary>
    /// This class represents the Visa Card a child of the class CreditCard to the different type of  
    /// @author: Ahmed Alsadiq
    /// @updated: 5/25/18
    /// </summary>
    public class Visa : CreditCard
    {
        // Constructor to instantiate by passing in the balance
        public Visa(double balance)
        {
            CardType = "Visa";
            IntrestPercentage = 0.10;
            CardBalance = balance;
        }
    }
}