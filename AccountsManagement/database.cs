using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountsManagement
{
    public class Database
    {

        public List<AccountDTO> accounts;
        public List<UserDTO> users;
        public int newAccountNumber =3;
        public int newUserId = 3;

        public Database()
        {
            accounts =new List<AccountDTO>()
            {
                new AccountDTO
                {
                    AccountNumber = 1,
                    Balance ="1000000",
                    UserId =1,
                    Branch = "Delhi"
                },
                new AccountDTO
                {
                    AccountNumber = 2,
                    Balance ="1000000",
                    UserId = 2,
                }
            };
            users = new List<UserDTO>()
            {
                new UserDTO
                {
                    UserId=1,
                    UserName="Jatin"
                },
                new UserDTO
                {
                    UserId=2,
                    UserName="Shagun"
                }
            };
        }

        public List<AccountDTO> GetAllAccounts()
        {
            return accounts;
        }
        
        public List<AccountDTO> GetAccountsByUserId(int id)
        {
            return accounts.Where(x=> x.UserId == id).ToList();
        }

        public void AddAccount(AccountDTO account)
        {
            account.AccountNumber = newAccountNumber++;
            accounts.Add(account);
        }

        public void AddUser(UserDTO user)
        {
            user.UserId = newUserId++;
            users.Add(user);
        }

        public List<UserDTO> GetAllUsers()
        {
            return users;
        }


        public bool UpdateAccount(AccountDTO account, int id)
        {
            bool isUpdated = false;
            if(accounts.Any(x=>x.AccountNumber == id))
            {
                accounts[accounts.FindIndex(x => x.AccountNumber == id)] = account;
                isUpdated = true;
            }
            return isUpdated;
        }


        public bool UpdateUser(UserDTO user, int id)
        {
            bool isUpdated = false;
            if (users.Any(x => x.UserId == user.UserId))
            {
                users[accounts.FindIndex(x => x.UserId == user.UserId)] = user;
                isUpdated = true;
            }
            return isUpdated;
        }

        public void CloseAccount(int accountNumber)
        {
            accounts.RemoveAt(accounts.FindIndex(x => x.AccountNumber == accountNumber));
        }
    }
}
