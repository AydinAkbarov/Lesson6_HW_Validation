using Lesson6_asp_hw.Models;

namespace Lesson6_asp_hw.Services.Abstracts
{
    public interface IRepository
    {
        bool AddUser(User user);
        IEnumerable<User> GetUsers();
        public bool Login(string username,string password);

    }
}
