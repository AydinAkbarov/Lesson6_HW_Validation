using Lesson6_asp_hw.Models;
using Lesson6_asp_hw.Services.Abstracts;

namespace Lesson6_asp_hw.Services.Concretes
{
    public class UserRepository : IRepository
    {
        public List<User> Users =Database.users;
        public bool AddUser(User user)
        {
            var isExist=Users.Any(u => u.Email == user.Email);
            if (!isExist)
            {
                Users.Add(user);
                return true;
            }
            return false;
        }

        public IEnumerable<User> GetUsers()
        {
            return Users;
        }
        public bool Login(string email,string password)
        {
            var findUser=Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (findUser != null)
            {
                return true;
            }
            return false;
        }
    }
}
