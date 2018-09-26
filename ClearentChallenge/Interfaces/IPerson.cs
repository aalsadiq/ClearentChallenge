namespace ClearentChallenge
{
    /// <summary>
    /// This Interface will hold the attributes shared by any itteration of Person
    /// @author: Ahmed Alsadiq
    /// @updated: 5/25/18
    /// </summary>
    interface IPerson :IGetPersonTotalIntrest
    {
        double TotalPersonIntrest { get; set; }
        IWallet[] Wallets { get; set; }
    }
}
