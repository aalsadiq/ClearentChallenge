namespace ClearentChallenge
{
    /// <summary>
    ///  This Interface will hold the contracts for Wallet generated Intrest
    /// @author: Ahmed Alsadiq
    /// @updated: 5/25/18
    /// </summary>
    /// 
    public interface IGetWalletTotalIntrest
    {
        double TotalCardsIntrest(ICard[] cards);
        double TotalCardsIntrest();
    }
}