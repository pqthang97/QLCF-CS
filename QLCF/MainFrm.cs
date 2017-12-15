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
        private SanPhamFrm frmSanPham;
        private DanhMucSPForm frmDanhMucSP;
        private TableFrm frmTable;
        private UserFrm frmUser;
        private OrderFrm frmOrder;
        public MainForm()
        {
            InitializeComponent();
            this.AllowControl(false);
        }

        public void AllowControl(bool isAllow)
        {
            ribbonPageBanHang.Enabled = isAllow;
            ribbonPageQuanLi.Enabled = isAllow;
            ribbonPageTacVu.Enabled = isAllow;
            barBtnLogout.Enabled = isAllow;
            barBtnLogin.Enabled = !isAllow;
            if(GlobalV.ActiveUser != null && GlobalV.ActiveUser.role == "admin")
            {
                ribbonPageQuanLi.Enabled = true;
            }
            else
            {
                ribbonPageQuanLi.Enabled = false;
            }
        }

        public bool IsExistform(Form form) //(XtraForm form)
        {
            if (form == null)
                return false;
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void barBtnBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsExistform(frmBanHang))
            {
                frmBanHang = new BanHangFrm();
                frmBanHang.MdiParent = this;
                frmBanHang.Show();
            }
        }

        private void barBtnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var mdi in MdiChildren)
            {
                if (mdi.Name == GlobalV.frmActive)
                    switch (mdi.Name)
                    {
                        case "BanHangFrm":
                            frmBanHang.ThemMoi();
                            break;

                        case "SanPhamFrm":
                            frmSanPham.ThemMoi();
                            break;

                        case "DanhMucSPForm":
                            frmDanhMucSP.ThemMoi();
                            break;

                        case "TableFrm":
                            frmTable.ThemMoi();
                            break;

                        case "UserFrm":
                            frmUser.ThemMoi();
                            break;

                        default:
                            break;
                    }
            }
        }

        private void barBtnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsExistform(frmSanPham))
            {
                frmSanPham = new SanPhamFrm();
                frmSanPham.MdiParent = this;
                frmSanPham.Show();
            }
        }

        private void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var mdi in MdiChildren)
            {
                if (mdi.Name == GlobalV.frmActive)
                    switch (mdi.Name)
                    {
                        case "BanHangFrm":
                            frmBanHang.Luu();
                            break;

                        case "SanPhamFrm":
                            frmSanPham.Luu();
                            break;

                        case "DanhMucSPForm":
                            frmDanhMucSP.Luu();
                            break;

                        case "TableFrm":
                            frmTable.Luu();
                            break;

                        case "UserFrm":
                            frmUser.Luu();
                            break;


                        default:
                            break;
                    }
            }
        }

        private void barBtnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var mdi in MdiChildren)
            {
                if (mdi.Name == GlobalV.frmActive)
                    switch (mdi.Name)
                    {
                        case "BanHangFrm":
                            frmBanHang.Xoa();
                            break;

                        case "SanPhamFrm":
                            frmSanPham.Xoa();
                            break;

                        case "DanhMucSPForm":
                            frmDanhMucSP.Xoa();
                            break;

                        case "TableFrm":
                            frmTable.Xoa();
                            break;

                        case "UserFrm":
                            frmUser.Xoa();
                            break;

                        default:
                            break;
                    }
            }
        }

        private void barBtnCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsExistform(frmDanhMucSP))
            {
                frmDanhMucSP = new DanhMucSPForm();
                frmDanhMucSP.MdiParent = this;
                frmDanhMucSP.Show();
            }
        }

        private void barBtnTable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsExistform(frmTable))
            {
                frmTable = new TableFrm();
                frmTable.MdiParent = this;
                frmTable.Show();
            }
        }

        private void barBtnUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsExistform(frmUser))
            {
                frmUser = new UserFrm();
                frmUser.MdiParent = this;
                frmUser.Show();
            }
        }

        private void barBtnOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!IsExistform(frmOrder))
            {
                frmOrder = new OrderFrm();
                frmOrder.MdiParent = this;
                frmOrder.Show();
            }
        }

        private void barBtnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoginFrm frmLogin = new LoginFrm(this);
            frmLogin.ShowDialog();
        }

        private void barBtnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GlobalV.ActiveUser = null;
            this.AllowControl(false);
            
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }
        }
    }
}
