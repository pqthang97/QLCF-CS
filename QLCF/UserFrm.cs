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
using QLCF.FormInterface;
using QLCF.Repository;

namespace QLCF
{
    public partial class UserFrm : DevExpress.XtraEditors.XtraForm, IActionForm
    {
        
        UserRepository UserRepo = new UserRepository();
        User curUser;
        public UserFrm()
        {
            InitializeComponent();
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            GlobalV.frmActive = this.Name;
        }
        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            GlobalV.frmActive = null;
        }

        private void LoadDMSP()
        {
            gridCtrlTable.DataSource = UserRepo.FindAll();
        }

        public void Luu()
        {
            if(curUser == null)
            {
                User category = new User
                {
                    name = txtName.Text,
                    username = txtUsername.Text,
                    password = txtPassword.Text,
                    role = cbbRole.Text
                };
                UserRepo.Save(category);
            } else
            {
                curUser.name = txtName.Text;
                curUser.username = txtUsername.Text;
                curUser.password = txtPassword.Text;
                curUser.role = cbbRole.Text;
                UserRepo.Update(curUser);
            }
            this.LoadDMSP();
        }

        public void ThemMoi()
        {
            txtName.Text = null;
            txtUsername.Text = null;
            txtPassword.Text = null;
            cbbRole.Text = null;

            curUser = null;
        }

        public void Xoa()
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này?", "Thông báo", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                UserRepo.Delete(curUser);
                this.ThemMoi();
                this.LoadDMSP();
            }
        }

        private void DanhMucSPForm_Load(object sender, EventArgs e)
        {
            this.LoadDMSP();
        }

        private void gridCtrlCategory_Click(object sender, EventArgs e)
        {
            int[] arrRowID = gridVTable.GetSelectedRows();
            foreach (int RowID in arrRowID)
            {
                User user;
                user = gridVTable.GetRow(RowID) as User;

                txtName.Text = user.name;
                cbbRole.Text = user.role;
                txtUsername.Text = user.username;
                txtPassword.Text = user.password;

                curUser = user;
            }
        }
    }
}