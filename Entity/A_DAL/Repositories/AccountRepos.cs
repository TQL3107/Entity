using Entity.A_DAL.Models;
using Entity.A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.A_DAL.Repositories
{
    internal class AccountRepos
    {
       _17332_ADOContext context = new _17332_ADOContext();
        public List<Account> GetAllAccounts()
        {
            return context.Accounts.ToList(); // lấy tất cả cá entity từ DBset => list 
        }
        public Account GetAccount(string username, string password)
        {
            Account account = context.Accounts.FirstOrDefault(x => x.Username == username && x.Password == password);
            return account;
        }
        public bool CreateAccount(string username, string password)
        {
            try
            {
                Account ac = new Account();
                ac.Username = username;
                ac.Password = password;
                context.Accounts.Add(ac);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }
}
