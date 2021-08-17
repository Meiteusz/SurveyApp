using Models;
using Models.Entities.Interfaces;
using Models.Enums;
using System;

namespace Controllers
{
    public class UserBLL : IUserBLL
    {
        private readonly IUser _User;

        public UserBLL(IUser user)
        {
            _User = user;
        }

        public User Create() => new User();

        public User Create(string Login, string Password) => new User(Login, Password);

        public User Create(string Name, byte UserType, string Cpf, string Login, string Email, string Password) => new User(Name, UserType, Cpf, Login, Email, Password);

        public ResponseData<User> LoginUser(User user)
        {
            var userLogged = _User.LoginUser(user);

            if (userLogged != null)
                UserSetting.SetLoggedUser(userLogged.Data); //improving

            return userLogged;
        }

        public Response Insert(User user)
        {
            return _User.Insert(user);
        }

        public Array GetUserTypes() => Enum.GetValues(typeof(UserTypes));
    }
}
