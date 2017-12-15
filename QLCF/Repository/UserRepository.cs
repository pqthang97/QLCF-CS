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
        QLCFEntities db = DBContext.Instance.GetEntities();
        public void Delete(User user)
        {
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public IEnumerable<User> FindAll()
        {
            return db.Users.ToList();
        }

        public IEnumerable<User> FindAvailable()
        {
            throw new NotImplementedException();
        }

        public User FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public User Login(string username, string password)
        {
            return db.Users.Where(x => x.username == username).Where(x => x.password == password).FirstOrDefault();
        }

        public void Save(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void Update(User user)
        {
            db.Users.Attach(user);
            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
