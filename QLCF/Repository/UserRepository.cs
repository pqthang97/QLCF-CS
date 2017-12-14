using QLCF.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLCF.Repository
{
    class UserRepository : IUserRepository
    {
        public IEnumerable<User> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> FindAvailable()
        {
            throw new NotImplementedException();
        }

        public User FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(User order)
        {
            throw new NotImplementedException();
        }
    }
}
