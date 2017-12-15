
using QLCF.ViewModel;
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
        Order FindByTable(int TableID);
        IEnumerable<ProductOrder> OrderInfoFindByTable(int TableID);
        Order Save(Order order);
        bool AddProductToOrderInfo(int count, Product product, Order order);
        bool RemoveProduct(int ProductID, Order order);
        bool Payment(Order order, int discount, int total);
    }
}
