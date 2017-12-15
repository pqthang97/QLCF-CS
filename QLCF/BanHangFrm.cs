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
using QLCF.CustomControl;

using QLCF.Repository;
using QLCF.ViewModel;
using QLCF.XtraReport;
using QLCF.ReportObject;
using DevExpress.XtraReports.UI;

namespace QLCF
{
    public partial class MainFrm : DevExpress.XtraEditors.XtraForm
    {
        TableRepository TableRepo = new TableRepository();
        CategoryRepository CategoryRepo = new CategoryRepository();
        ProductRepository ProductRepo = new ProductRepository();
        OrderRepository OrderRepo = new OrderRepository();
        OrderReport report = new OrderReport();

        Order CurrentOrder = null;
        Table CurrentTable = null;
        public MainFrm()
        {
            InitializeComponent();

            initTable();
            
            splitContainer.SplitterPosition = Screen.PrimaryScreen.Bounds.Width * 2 / 5;
        }

        private void initTable()
        {
            
            List<Table> ListTable = TableRepo.FindAll();
            
            foreach(var item in ListTable)
            {
                flowLayout1.Controls.Add(this.createButton(item));
            }

            
            gridCtrlCategory.DataSource = CategoryRepo.FindAll();
        }

        private PButton createButton(Table table)
        {
            PButton btn = new PButton();
            
            btn.Text = table.Name;
            btn.TableID = table.Id;
            btn.Order = OrderRepo.FindByTable(table.Id);
            btn.Visible = true;
            btn.Left = 20;
            btn.Click += Btn_Click;
            
            return btn;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            PButton btn = sender as PButton;
            
            this.LoadTableOrder(btn.TableID);
            CurrentTable = TableRepo.FindBy(btn.TableID);
            lbCurrentTable.Text = CurrentTable.Name;
        }

        private void LoadTableOrder(int TableID)
        {
            CurrentOrder = OrderRepo.FindByTable(TableID);
            gridCtrlTable.DataSource = OrderRepo.OrderInfoFindByTable(TableID);
            if(CurrentOrder != null)
            {
                txtSubTotal.Text = CurrentOrder.Price.ToString();
            }
            else
            {
                txtSubTotal.Text = "0";
            }
            this.CalcTotal();
        }

        private void gridCtrlCategory_Click(object sender, EventArgs e)
        {
            int[] arrRowID = gridVCategory.GetSelectedRows();
            foreach (int RowID in arrRowID)
            {
                Category row;
                row = gridVCategory.GetRow(RowID) as Category;
                this.LoadProduct(row.Id);
            }
        }

        private void LoadProduct(int CatID)
        {
            gridCtrlProduct.DataSource = ProductRepo.FindByCatID(CatID);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int[] arrRowID = gridVProduct.GetSelectedRows();
            foreach (int RowID in arrRowID)
            {
                Product product;
                product = gridVProduct.GetRow(RowID) as Product;
                Order order = OrderRepo.FindByTable(CurrentTable.Id);
                if(order == null)
                {
                    order = OrderRepo.Save(new Order
                    {
                        TableID = CurrentTable.Id,
                        Price = 0,
                        Status = "received",
                        CreatedAt = DateTime.Now,
                    });
                }

                int intSoLuong = int.Parse(txtSoLuong.Text);
                if(intSoLuong > 0)
                {
                    OrderRepo.AddProductToOrderInfo(intSoLuong, product, order);
                    this.LoadTableOrder(CurrentTable.Id);
                    

                }
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int[] arrRowID = gridVTable.GetSelectedRows();
            foreach (int RowID in arrRowID)
            {
                ProductOrder product;
                product = gridVTable.GetRow(RowID) as ProductOrder;
                Order order = OrderRepo.FindByTable(CurrentTable.Id);
                OrderRepo.RemoveProduct(product.ProductID, order);
                this.LoadTableOrder(CurrentTable.Id);
            }
        }

        private void txtDiscountPrice_TextChanged(object sender, EventArgs e)
        {
            this.CalcTotal();
        }

        private void CalcTotal()
        {
            if (CurrentOrder == null || CurrentTable == null)
                return;
            int Total = int.Parse(txtSubTotal.Text) - int.Parse(txtDiscountPrice.Text);
            Total = Total > 0 ? Total : 0;
            txtTotal.Text = Total.ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (CurrentOrder == null || CurrentTable == null)
                return;
            OrderRepo.Payment(CurrentOrder, int.Parse(txtDiscountPrice.Text), int.Parse(txtTotal.Text));
            this.LoadTableOrder(CurrentTable.Id);
            

            List<OrderReportObject> obj = new List<OrderReportObject>();
            obj.Add(new OrderReportObject
            {
                Order = CurrentOrder,
                Products = OrderRepo.OrderInfoFindByTable(CurrentTable.Id),
            });
            report.DataSource = obj;
            report.ShowPreviewDialog();
        }

        private void gridVTable_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridVProduct_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridVCategory_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}