using Models;
using Models.Entities.Interfaces;

namespace Controllers
{
    public class UserBLL : IUserBLL
    {
        public readonly IUser _User;

        public UserBLL(IUser user)
        {
            _User = user;
        }

        public User Create(string Login, string Password) => new User(Login, Password);
        
        public Response LoginUser(User user)
        {
            return _User.LoginUser(user);
        }
    }
}
