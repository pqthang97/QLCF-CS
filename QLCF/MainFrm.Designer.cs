namespace QLCF
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnBanHang = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDel = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCategory = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUser = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTable = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnOrder = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageBanHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageQuanLi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageTacVu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTab = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barBtnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLogout = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnBanHang,
            this.barBtnThemMoi,
            this.barBtnSave,
            this.barBtnDel,
            this.barBtnProduct,
            this.barBtnCategory,
            this.barBtnUser,
            this.barBtnTable,
            this.barBtnOrder,
            this.barBtnLogin,
            this.barBtnLogout});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(821, 143);
            // 
            // barBtnBanHang
            // 
            this.barBtnBanHang.Caption = "Bán hàng";
            this.barBtnBanHang.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnBanHang.Glyph")));
            this.barBtnBanHang.Id = 1;
            this.barBtnBanHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnBanHang.LargeGlyph")));
            this.barBtnBanHang.Name = "barBtnBanHang";
            this.barBtnBanHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBanHang_ItemClick);
            // 
            // barBtnThemMoi
            // 
            this.barBtnThemMoi.Caption = "Thêm mới";
            this.barBtnThemMoi.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnThemMoi.Glyph")));
            this.barBtnThemMoi.Id = 2;
            this.barBtnThemMoi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnThemMoi.LargeGlyph")));
            this.barBtnThemMoi.Name = "barBtnThemMoi";
            this.barBtnThemMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThemMoi_ItemClick);
            // 
            // barBtnSave
            // 
            this.barBtnSave.Caption = "Lưu";
            this.barBtnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSave.Glyph")));
            this.barBtnSave.Id = 3;
            this.barBtnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnSave.LargeGlyph")));
            this.barBtnSave.Name = "barBtnSave";
            this.barBtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSave_ItemClick);
            // 
            // barBtnDel
            // 
            this.barBtnDel.Caption = "Xóa";
            this.barBtnDel.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnDel.Glyph")));
            this.barBtnDel.Id = 4;
            this.barBtnDel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnDel.LargeGlyph")));
            this.barBtnDel.Name = "barBtnDel";
            this.barBtnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDel_ItemClick);
            // 
            // barBtnProduct
            // 
            this.barBtnProduct.Caption = "Sản phẩm";
            this.barBtnProduct.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnProduct.Glyph")));
            this.barBtnProduct.Id = 5;
            this.barBtnProduct.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnProduct.LargeGlyph")));
            this.barBtnProduct.Name = "barBtnProduct";
            this.barBtnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnProduct_ItemClick);
            // 
            // barBtnCategory
            // 
            this.barBtnCategory.Caption = "Danh mục sản phẩm";
            this.barBtnCategory.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCategory.Glyph")));
            this.barBtnCategory.Id = 6;
            this.barBtnCategory.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnCategory.LargeGlyph")));
            this.barBtnCategory.Name = "barBtnCategory";
            this.barBtnCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCategory_ItemClick);
            // 
            // barBtnUser
            // 
            this.barBtnUser.Caption = "Quản lí nhân viên";
            this.barBtnUser.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnUser.Glyph")));
            this.barBtnUser.Id = 7;
            this.barBtnUser.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnUser.LargeGlyph")));
            this.barBtnUser.Name = "barBtnUser";
            this.barBtnUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUser_ItemClick);
            // 
            // barBtnTable
            // 
            this.barBtnTable.Caption = "Quản lí bàn";
            this.barBtnTable.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnTable.Glyph")));
            this.barBtnTable.Id = 8;
            this.barBtnTable.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnTable.LargeGlyph")));
            this.barBtnTable.Name = "barBtnTable";
            this.barBtnTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnTable_ItemClick);
            // 
            // barBtnOrder
            // 
            this.barBtnOrder.Caption = "Quản lý đơn hàng";
            this.barBtnOrder.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnOrder.Glyph")));
            this.barBtnOrder.Id = 9;
            this.barBtnOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnOrder.LargeGlyph")));
            this.barBtnOrder.Name = "barBtnOrder";
            this.barBtnOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnOrder_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageBanHang,
            this.ribbonPageQuanLi,
            this.ribbonPageTacVu,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Bán Hàng";
            // 
            // ribbonPageBanHang
            // 
            this.ribbonPageBanHang.ItemLinks.Add(this.barBtnBanHang);
            this.ribbonPageBanHang.Name = "ribbonPageBanHang";
            this.ribbonPageBanHang.Text = "Bán hàng";
            // 
            // ribbonPageQuanLi
            // 
            this.ribbonPageQuanLi.ItemLinks.Add(this.barBtnProduct);
            this.ribbonPageQuanLi.ItemLinks.Add(this.barBtnCategory);
            this.ribbonPageQuanLi.ItemLinks.Add(this.barBtnTable);
            this.ribbonPageQuanLi.ItemLinks.Add(this.barBtnOrder);
            this.ribbonPageQuanLi.ItemLinks.Add(this.barBtnUser);
            this.ribbonPageQuanLi.Name = "ribbonPageQuanLi";
            this.ribbonPageQuanLi.Text = "Quản lí";
            // 
            // ribbonPageTacVu
            // 
            this.ribbonPageTacVu.ItemLinks.Add(this.barBtnThemMoi);
            this.ribbonPageTacVu.ItemLinks.Add(this.barBtnSave);
            this.ribbonPageTacVu.ItemLinks.Add(this.barBtnDel);
            this.ribbonPageTacVu.Name = "ribbonPageTacVu";
            this.ribbonPageTacVu.Text = "Tác vụ";
            // 
            // xtraTab
            // 
            this.xtraTab.MdiParent = this;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnLogin);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnLogout);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Tài khoản";
            // 
            // barBtnLogin
            // 
            this.barBtnLogin.Caption = "Đăng nhập";
            this.barBtnLogin.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnLogin.Glyph")));
            this.barBtnLogin.Id = 10;
            this.barBtnLogin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnLogin.LargeGlyph")));
            this.barBtnLogin.Name = "barBtnLogin";
            this.barBtnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLogin_ItemClick);
            // 
            // barBtnLogout
            // 
            this.barBtnLogout.Caption = "Đăng xuất";
            this.barBtnLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnLogout.Glyph")));
            this.barBtnLogout.Id = 11;
            this.barBtnLogout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnLogout.LargeGlyph")));
            this.barBtnLogout.Name = "barBtnLogout";
            this.barBtnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLogout_ItemClick);
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 591);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Cafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageBanHang;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTab;
        private DevExpress.XtraBars.BarButtonItem barBtnBanHang;
        private DevExpress.XtraBars.BarButtonItem barBtnThemMoi;
        private DevExpress.XtraBars.BarButtonItem barBtnSave;
        private DevExpress.XtraBars.BarButtonItem barBtnDel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageTacVu;
        private DevExpress.XtraBars.BarButtonItem barBtnProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageQuanLi;
        private DevExpress.XtraBars.BarButtonItem barBtnCategory;
        private DevExpress.XtraBars.BarButtonItem barBtnUser;
        private DevExpress.XtraBars.BarButtonItem barBtnTable;
        private DevExpress.XtraBars.BarButtonItem barBtnOrder;
        private DevExpress.XtraBars.BarButtonItem barBtnLogin;
        private DevExpress.XtraBars.BarButtonItem barBtnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}

