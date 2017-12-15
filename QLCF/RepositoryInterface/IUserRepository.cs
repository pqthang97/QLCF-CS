
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.RepositoryInterface
{
    interface IUserRepository
    {
        IEnumerable<User> FindAll();
        IEnumerable<User> FindAvailable();
        User FindBy(int id);
        void Save(User user);
        void Update(User user);
        void Delete(User user);

        User Login(string username, string password);
    }
}
