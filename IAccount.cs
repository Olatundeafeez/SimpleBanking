using SimpleBanking.DTOs;

internal interface IAccount
{
    object CreateAccount(AccountCreationDTO newAcct);
}