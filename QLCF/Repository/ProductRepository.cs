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
        public IEnumerable<Product> FindAll()
        {
            throw new NotImplementedException();
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

        public void Save(Product order)
        {
            throw new NotImplementedException();
        }
    }
}
