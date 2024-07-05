using SimpleBanking.Controllers.Model;
using SimpleBanking.DTOs;

namespace SimpleBanking.Controllers.Service.Interface
{
    public interface IAccount
    {
        Account CreateAccount(AccountCreationDTO newAccount);
    }
}
