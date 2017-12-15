using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.ViewModel
{
    class ProductOrder
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> Cost { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<int> Total { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
