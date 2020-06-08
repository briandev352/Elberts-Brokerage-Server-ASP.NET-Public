using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        IEnumerable<Account> AccountsByOwner(Guid ownerId);
        Account GetAccountById(Guid accountId);
        void CreateAccount(Account account);
        void UpdateAccount(Account dbAccount, Account account);
        void DeleteAccount(Account account);

    }
}