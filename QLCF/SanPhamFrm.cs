using DevExpress.XtraEditors;
using QLCF.FormInterface;
using QLCF.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
{
    public partial class SanPhamFrm : XtraForm, IActionForm
    {
        ProductRepository ProductRepo = new ProductRepository();
        CategoryRepository CategoryRepo = new CategoryRepository();
        Product curProduct;

        public SanPhamFrm()
        {
            InitializeComponent();
            
            GlobalV.frmActive = this.Name;
        }

        private void loadCategory()
        {
            List<Category> ListCategory = CategoryRepo.FindAll() as List<Category>;
            lueCategory.Properties.ValueMember = "Id";
            lueCategory.Properties.DisplayMember = "Name";
            lueCategory.Properties.DataSource = ListCategory;
            if(ListCategory.Count > 0)
                lueCategory.EditValue = ListCategory[0].Id;
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

        private  void LoadSP()
        {
            gridCtrlProduct.DataSource = ProductRepo.FindAll();
        }
        

        public void Luu()
        {
            if(curProduct == null)
            {
                ProductRepo.Save(new Product
                {
                    Name = txtTenSP.Text,
                    CategoryId = int.Parse(lueCategory.EditValue.ToString()),
                    Cost = int.Parse(txtCost.Text),
                    Description = txtDescription.Text
                });
                this.LoadSP();
            } 
            else
            {
                curProduct.Name = txtTenSP.Text;
                curProduct.CategoryId = int.Parse(lueCategory.EditValue.ToString());
                curProduct.Cost = int.Parse(txtCost.Text);
                curProduct.Description = txtDescription.Text;
                ProductRepo.Update(curProduct);
                this.LoadSP();
            }
        }

        public void ThemMoi()
        {
            txtTenSP.Text = null;
            txtCost.Text = "0";
            txtDescription.Text = null;
            curProduct = null;
        }

        public void Xoa()
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                ProductRepo.Delete(curProduct);
                this.LoadSP();
                this.ThemMoi();
            }
        }

        private void SanPhamForm_Load(object sender, EventArgs e)
        {
            this.LoadSP();
            this.loadCategory();
        }

        private void gridCtrlProduct_Click(object sender, EventArgs e)
        {
            int[] arrRowID = gridVProduct.GetSelectedRows();
            foreach (int RowID in arrRowID)
            {
                Product product;
                product = gridVProduct.GetRow(RowID) as Product;

                txtTenSP.Text = product.Name;
                txtCost.Text = product.Cost.ToString();
                txtDescription.Text = product.Description;
                lueCategory.EditValue = product.CategoryId;
                curProduct = product;
            }
        }

        private void gridVProduct_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
