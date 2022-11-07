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
    public partial class SignUp : Form
    {
        AccountService acs = new AccountService();
        public SignUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Create_Click_1(object sender, EventArgs e)
        {
            if (tbt_Password.Text == tbt_RePassword.Text)
            {
                if (acs.CheckAccAxists(tbt_Username.Text))
                {
                    MessageBox.Show("Tài khoản đã tồn tại. Mời bạn tạo với username khác");
                    tbt_Username.Text = "";

                }
                else
                {
                    MessageBox.Show(acs.CreateAccount(tbt_Username.Text, tbt_Password.Text));
                }

                MessageBox.Show(acs.CreateAccount(tbt_Username.Text, tbt_Password.Text));
            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu không đúng");
            }
        }
    }
}
