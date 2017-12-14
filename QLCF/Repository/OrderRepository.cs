using QLCF.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLCF.Repository
{
    class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> FindAvailable()
        {
            throw new NotImplementedException();
        }

        public Order FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
