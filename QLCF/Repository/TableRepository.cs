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
            throw new NotImplementedException();
        }

        public void Save(Table order)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
