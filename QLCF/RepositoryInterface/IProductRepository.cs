
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.RepositoryInterface
{
    interface IProductRepository
    {
        IEnumerable<Product> FindAll();
        IEnumerable<Product> FindAvailable();
        IEnumerable<Product> FindByCatID(int CatID);
        Product FindBy(int id);
        void Save(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
