
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Repository
{
    class DBContext
    {
        private static DBContext dbContext;
        private static QLCFEntities _Entities;
        public static DBContext Instance
        {
            get
            {
                if (dbContext == null)
                {
                    dbContext = new DBContext();
                }
                return dbContext;
            }
        }

        public QLCFEntities GetEntities()
        {
            if(_Entities == null)
            {
                _Entities = new QLCFEntities();
            }
            return _Entities;
        }
    }
}
