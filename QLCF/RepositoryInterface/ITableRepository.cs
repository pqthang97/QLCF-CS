
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.RepositoryInterface
{
    interface ITableRepository
    {
        List<Table> FindAll();
        IEnumerable<Table> FindAvailable();
        Table FindBy(int id);
        void Save(Table order);
    }
}
