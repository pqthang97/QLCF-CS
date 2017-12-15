using QLCF.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Repository
{
    class CategoryRepository : ICategoryRepository
    {
        private QLCFEntities db = DBContext.Instance.GetEntities();

        public void Delete(Category category)
        {
            db.Categories.Remove(category);
            db.SaveChanges();
        }

        public IEnumerable<Category> FindAll()
        {
            return db.Categories.ToList();
        }

        public IEnumerable<Category> FindAvailable()
        {
            throw new NotImplementedException();
        }

        public Category FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Update(Category category)
        {
            db.Categories.Attach(category);
            db.Entry(category).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
