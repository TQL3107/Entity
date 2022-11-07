using Entity.A_DAL.Models;
using Entity.B_BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity.C_GUI.View
{
    public partial class Login : Form
    {
        AccountService acs = new AccountService();
        public Login()
        {
            InitializeComponent();
        }
        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            if (acs.CheckEmtyDB())
            {
                MessageBox.Show("There is no Account exists in database, please create a new one");
            }
            else
            {
                Account ac = acs.CheckLogin(tbt_Username.Text, tbt_Password.Text);
                if (ac == null) MessageBox.Show("The Account does not exists!");
                else
                {
                    CarManager cm = new CarManager();
                    cm.AC = ac;
                    cm.ShowDialog();
                }
            }
        }
        private void lb_Create_Click_1(object sender, EventArgs e)
        {
            SignUp sn = new SignUp();
            sn.ShowDialog();
        }

       
    }
}
