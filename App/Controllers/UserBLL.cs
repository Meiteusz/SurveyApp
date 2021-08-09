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

        public User Create() => new User();

        public User Create(string Login, string Password) => new User(Login, Password);

        public User Create(string Name, byte UserType, string Cpf, string Login, string Email, string Password) => new User(Name, UserType, Cpf, Login, Email, Password);
        
        public ResponseData<User> LoginUser(User user)
        {
            return _User.LoginUser(user);
        }

        public Response Insert(User user)
        {
            return _User.Insert(user);
        }
    }
}
