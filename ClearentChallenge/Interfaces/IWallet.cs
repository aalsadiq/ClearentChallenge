namespace ClearentChallenge
{
    /// <summary>
    /// This Interface will hold the attributes shared by any wallet
    /// @author: Ahmed Alsadiq
    /// @updated: 5/25/18
    /// </summary>
    public interface IWallet:IGetWalletTotalIntrest
    {
        double TotalWalletIntrest { set; get; }
        ICard[] Cards { get; set; }
    }
}
