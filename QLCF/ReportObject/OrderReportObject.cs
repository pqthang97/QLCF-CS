using QLCF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.ReportObject
{
    class OrderReportObject
    {
        public IEnumerable<ProductOrder> Products { get; set; }
        public Order Order { get; set; }
    }
}
