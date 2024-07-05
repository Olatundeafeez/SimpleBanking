using SimpleBanking.Controllers.Model;
using SimpleBanking.Controllers.Service.Interface;
using SimpleBanking.DTOs;

namespace SimpleBanking.Repository
{
    public class AccountRepository : IAccount
    {
        public Account CreateAccount(AccountCreationDTO newAccount)
        {
            try
            {
                var new_Account = new Account()
                {
                    Id = new Guid(),
                    AccountName = newAccount.Name,
                    Email = newAccount.Email,
                    AccountNumber = newAccount.AccountNumber,
                    AccountBalance = newAccount.AccountBalance
                };
                return new_Account;
            }
            catch (Exception ex) 
            { 
                throw new Exception(ex.Message);
            }
        }

        object IAccount.CreateAccount(AccountCreationDTO newAcct)
        {
            throw new NotImplementedException();
        }
    }
}
