namespace ClearentChallenge
{
    /// <summary>
    /// This Interface will hold the attributes shared by any card
    /// @author: Ahmed Alsadiq
    /// @updated: 5/25/18
    /// </summary>
    public interface ICard: ISimpleIntrest
    {
        string CardType { get; }
        double IntrestPercentage { get; }
        double CardBalance { get; set; }
    }
}