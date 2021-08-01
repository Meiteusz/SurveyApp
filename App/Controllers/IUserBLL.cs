using Models;
using Models.Entities.Interfaces;

namespace Controllers
{
    public interface IUserBLL
    {
        User Create(string Login, string Password);
        Response LoginUser(User user);
    }
}
