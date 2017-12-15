
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.RepositoryInterface
{
    interface ICategoryRepository
    {
        IEnumerable<Category> FindAll();
        IEnumerable<Category> FindAvailable();
        Category FindBy(int id);
        void Save(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
