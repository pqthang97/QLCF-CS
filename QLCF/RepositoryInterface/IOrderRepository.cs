
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.RepositoryInterface
{
    interface IOrderRepository
    {
        IEnumerable<Order> FindAll();
        IEnumerable<Order> FindAvailable();
        Order FindBy(int id);
        void Save(Order order);
    }
}
