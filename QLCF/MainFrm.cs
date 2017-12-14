using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCF
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private BanHangFrm frmBanHang;
        public MainForm()
        {
            InitializeComponent();
        }

        private void barBtnBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmBanHang == null)
            {
                frmBanHang = new BanHangFrm();
                frmBanHang.MdiParent = this;
                frmBanHang.Show();
            }
        }
    }
}
