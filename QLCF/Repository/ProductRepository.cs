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

        public void Save(Product order)
        {
            throw new NotImplementedException();
        }
    }
}
