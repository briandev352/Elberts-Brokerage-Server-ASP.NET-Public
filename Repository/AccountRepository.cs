using Contracts;
using Entities;
using Entities.Extensions;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Account> AccountsByOwner(Guid ownerId)
        {
            return FindByCondition(a => a.OwnerId.Equals(ownerId));
        }

        public void CreateAccount(Account account)
        {
            account.Id = Guid.NewGuid();
            Create(account);
            Save();
        }

        public void DeleteAccount(Account account)
        {
            Delete(account);
            Save();
        }

        public Account GetAccountById(Guid accountId)
        {
            return FindByCondition(account => account.Id.Equals(accountId))
                    .DefaultIfEmpty(new Account())
                    .FirstOrDefault();
        }

        public void UpdateAccount(Account dbAccount, Account account)
        {
            dbAccount.Map(account);
            Update(dbAccount);
            Save();
        }
    }
}