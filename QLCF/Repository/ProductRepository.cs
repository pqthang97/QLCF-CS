using QLCF.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLCF.Repository
{
    class ProductRepository : IProductRepository
    {
        private QLCFEntities db = DBContext.Instance.GetEntities();

        public void Delete(Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();
        }

        public IEnumerable<Product> FindAll()
        {
            return db.Products.ToList();
        }

        public IEnumerable<Product> FindAvailable()
        {
            throw new NotImplementedException();
        }

        public Product FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> FindByCatID(int CatID)
        {
            return db.Products.Where(x => x.CategoryId == CatID).ToList();
        }

        public void Save(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void Update(Product product)
        {
            db.Products.Attach(product);
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
