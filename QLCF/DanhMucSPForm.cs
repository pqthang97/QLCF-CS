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
    public partial class DanhMucSPForm : DevExpress.XtraEditors.XtraForm, IActionForm
    {
        ProductRepository ProductRepo = new ProductRepository();
        CategoryRepository CategoryRepo = new CategoryRepository();
        Category curCategory;
        public DanhMucSPForm()
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
            gridCtrlCategory.DataSource = CategoryRepo.FindAll();
        }

        public void Luu()
        {
            if(curCategory == null)
            {
                Category category = new Category
                {
                    Name = txtTenSP.Text,
                    Description = txtDes.Text,
                };
                CategoryRepo.Save(category);
            } else
            {
                curCategory.Name = txtTenSP.Text;
                curCategory.Description = txtDes.Text;
                CategoryRepo.Update(curCategory);
            }
            this.LoadDMSP();
        }

        public void ThemMoi()
        {
            txtTenSP.Text = null;
            txtDes.Text = null;
            curCategory = null;
        }

        public void Xoa()
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này?", "Thông báo", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                CategoryRepo.Delete(curCategory);
                this.LoadDMSP();
                this.ThemMoi();
            }
        }

        private void DanhMucSPForm_Load(object sender, EventArgs e)
        {
            this.LoadDMSP();
        }

        private void gridCtrlCategory_Click(object sender, EventArgs e)
        {
            int[] arrRowID = gridVCategory.GetSelectedRows();
            foreach (int RowID in arrRowID)
            {
                Category category;
                category = gridVCategory.GetRow(RowID) as Category;

                txtTenSP.Text = category.Name;
                txtDes.Text = category.Description;

                curCategory = category;
            }
        }
    }
}