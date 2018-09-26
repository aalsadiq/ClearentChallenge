namespace ClearentChallenge
{
    /// <summary>
    /// This class represents the MC Card a child of the class CreditCard to the different type of  
    /// @author: Ahmed Alsadiq
    /// @updated: 5/25/18
    /// </summary>
    public class MC : CreditCard
    {
        // Constructor to instantiate by passing in the balance
        public MC(double balance)
        {
            CardType = "MC";
            IntrestPercentage = 0.05;
            CardBalance = balance;
        }
    }
}
