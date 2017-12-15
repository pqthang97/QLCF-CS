using QLCF.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLCF.Repository
{
    class TableRepository : ITableRepository
    {
        private QLCFEntities db = DBContext.Instance.GetEntities();
        public List<Table> FindAll()
        {
            return db.Tables.ToList();
        }

        public IEnumerable<Table> FindAvailable()
        {
            throw new NotImplementedException();
        }

        public Table FindBy(int id)
        {
            return db.Tables.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Save(Table table)
        {
            db.Tables.Add(table);
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }

        public void Update(Table table)
        {
            db.Tables.Attach(table);
            db.Entry(table).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Table table)
        {
            db.Tables.Remove(table);
            db.SaveChanges();
        }
    }
}
