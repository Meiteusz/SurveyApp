using Models;
using Models.Entities.Interfaces;

namespace Controllers
{
    public interface IUserBLL
    {
        User Create();
        User Create(string Login, string Password);
        ResponseData<User> LoginUser(User user);
        public bool UserIsAdmin(User user);
    }
}
