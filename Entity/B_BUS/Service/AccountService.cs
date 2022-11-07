using Entity.A_DAL.Models;
using Entity.A_DAL.Repositories;
using Entity.A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.B_BUS.Service
{
    internal class AccountService
    {
        AccountRepos acr = new AccountRepos();
        public bool CheckEmtyDB()
        {
            return acr.GetAllAccounts() == null;
        }
        public Account CheckLogin(string username, string password)
        {
            Account ac = acr.GetAccount(username, password);
            return ac;
        }
        public string CreateAccount(string username, string password)
        {
            if (acr.CreateAccount(username, password))
            {
                return "Tạo tài khoản thành công";
            }
            return "Tạo tài khoản thất bại";
        }
        public bool CheckAccAxists(string username)
        {
            var x = acr.GetAllAccounts().Find(x => x.Username == username); // tìm account có username đó 
            if (x != null) return true; // nếu tài khoản có tồn tại
            else return false;

        }
    }
}
