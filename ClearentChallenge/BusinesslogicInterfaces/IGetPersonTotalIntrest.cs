namespace ClearentChallenge
{
    /// <summary>
    ///  This Interface will hold the contracts for Person generated Intrest
    /// @author: Ahmed Alsadiq
    /// @updated: 5/25/18
    /// </summary>
    /// 
    public interface IGetPersonTotalIntrest
    {
        //double[] TotalCardsIntrest(ICard[] cards);
        double TotalCardsIntrest(ICard[] cards);
        double TotalWalletIntrest(IWallet[] Wallet);
        double TotalWalletIntrest();
    }
}