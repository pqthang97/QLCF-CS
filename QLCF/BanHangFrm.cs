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

namespace QLCF
{
    public partial class BanHangFrm : DevExpress.XtraEditors.XtraForm
    {
        public BanHangFrm()
        {
            InitializeComponent();

            initTable();
            
            splitContainer.SplitterPosition = Screen.PrimaryScreen.Bounds.Width * 2 / 5;
        }

        private void initTable()
        {
            TableRepository TableRepo = new TableRepository();
            List<Table> ListTable = TableRepo.FindAll();
            
            foreach(var item in ListTable)
            {
                flowLayout1.Controls.Add(this.createButton(item.Name));
            }
            
        }

        private PButton createButton(string text)
        {
            PButton btn = new PButton();
            btn.Size = new Size(100, 50);
            btn.Text = text;
            btn.Visible = true;
            btn.Left = 20;

            return btn;
        }
    }
}