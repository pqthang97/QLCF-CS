using QLCF.RepositoryInterface;
using QLCF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF.Repository
{
    class OrderRepository : IOrderRepository
    {
        private QLCFEntities db = new QLCFEntities();

        public bool AddProductToOrderInfo(int count, Product product, Order order)
        {
            try
            {
                OrderInfo info = db.OrderInfoes.Where(x => x.OrderID == order.Id).Where(x => x.ProductID == product.Id).FirstOrDefault();
                if (info == null)
                {
                 
                    info = db.OrderInfoes.Add(new OrderInfo
                    {
                        OrderID = order.Id,
                        ProductID = product.Id,
                        Count = count,
                        Total = product.Cost * count,
                        Cost = product.Cost
                    });
                    db.Entry(info).State = System.Data.Entity.EntityState.Added;

                    order.Price = info.Total;
                    db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    info.Cost = product.Cost;
                    info.Count += count;
                    info.Total = product.Cost * info.Count;
                    db.OrderInfoes.Attach(info);

                    order.Price = info.Total;
                    db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                    db.Entry(info).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                this.CalOrder(order);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return false;
        }

        private void CalOrder(Order order)
        {
           
            List<OrderInfo> ListOrderInfo = db.OrderInfoes.Where(x => x.OrderID == order.Id).ToList();

            int? total = 0;
            foreach (var info in ListOrderInfo)
            {
                total += info.Total;
            }

            order.Price = total;
            db.Orders.Attach(order);
            db.Entry(order).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Order> FindAll()
        {
            return db.Orders.OrderByDescending(x => x.Id).ToList();
        }

        public IEnumerable<Order> FindAvailable()
        {
            throw new NotImplementedException();
        }

        public Order FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public Order FindByTable(int TableID)
        {
            return db.Orders.Where(x => x.TableID == TableID).Where(x => x.Status == "received").FirstOrDefault();
        }

        public IEnumerable<ProductOrder> OrderInfoFindByTable(int TableID)
        {
            Order order = this.FindByTable(TableID);
            if (order == null)
                return null;
            return db.OrderInfoes.Where(x => x.OrderID == order.Id).Select(x => new ProductOrder
            {
                ProductName = x.Product.Name,
                Cost = x.Cost,
                Order = x.Order,
                Count = x.Count,
                OrderID = x.OrderID,
                Product = x.Product,
                ProductID = x.ProductID,
                Total = x.Total,
            }).ToList();
        }

        public Order Save(Order order)
        {
            order = db.Orders.Add(order);
            int save = db.SaveChanges();
            return order;
        }

        public bool RemoveProduct(int ProductID, Order order)
        {
            try
            {
                OrderInfo info = db.OrderInfoes.Where(x => x.OrderID == order.Id).Where(x => x.ProductID == ProductID).FirstOrDefault();
                db.OrderInfoes.Remove(info);
                db.SaveChanges();

                this.CalOrder(order);

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
            return false;
        }

        public bool Payment(Order order, int discount, int total)
        {
            try
            {
                order.Status = "completed";
                order.Discount = discount;
                order.Price = total;
                db.Orders.Attach(order);
                db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return false;
        }

        
    }
}
