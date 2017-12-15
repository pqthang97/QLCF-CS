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
using QLCF.Repository;

namespace QLCF
{
    public partial class OrderFrm : DevExpress.XtraEditors.XtraForm
    {
        OrderRepository OrderRepo = new OrderRepository();
        public OrderFrm()
        {
            InitializeComponent();
        }

        private void LoadOrder()
        {
            gridControl1.DataSource = OrderRepo.FindAll();
        }

        private void OrderFrm_Load(object sender, EventArgs e)
        {
            this.LoadOrder();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            int[] arrRowID = gridView1.GetSelectedRows();
            foreach (int RowID in arrRowID)
            {
                Order order;
                order = gridView1.GetRow(RowID) as Order;

                gridControl2.DataSource = order.OrderInfoes;
            }
        }
    }
}