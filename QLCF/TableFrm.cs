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
    public partial class TableFrm : DevExpress.XtraEditors.XtraForm, IActionForm
    {
        ProductRepository ProductRepo = new ProductRepository();
        TableRepository TableRepo = new TableRepository();
        Table curTable;
        public TableFrm()
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
            gridCtrlTable.DataSource = TableRepo.FindAll();
        }

        public void Luu()
        {
            if(curTable == null)
            {
                Table category = new Table
                {
                    Name = txtTenSP.Text,
                    Description = txtDes.Text
                };
                TableRepo.Save(category);
            } else
            {
                curTable.Name = txtTenSP.Text;
                curTable.Description = txtDes.Text;
                TableRepo.Update(curTable);
            }
            this.LoadDMSP();
        }

        public void ThemMoi()
        {
            txtTenSP.Text = null;
            txtDes.Text = null;
            curTable = null;
        }

        public void Xoa()
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này?", "Thông báo", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                TableRepo.Delete(curTable);
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
            int[] arrRowID = gridVTable.GetSelectedRows();
            foreach (int RowID in arrRowID)
            {
                Table table;
                table = gridVTable.GetRow(RowID) as Table;

                txtTenSP.Text = table.Name;
                txtDes.Text = table.Description;
                curTable = table;
            }
        }
    }
}