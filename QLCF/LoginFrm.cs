using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCF.RepositoryInterface;
using QLCF.Repository;

namespace QLCF
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        private MainForm frmMain;
        IUserRepository UserRepo = new UserRepository();
        public LoginFrm()
        {
            InitializeComponent();
        }

        public LoginFrm(MainForm frmMain)
        {
            this.frmMain = frmMain;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = UserRepo.Login(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                GlobalV.ActiveUser = user;
                frmMain.AllowControl(true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");
            }
        }
    }
}