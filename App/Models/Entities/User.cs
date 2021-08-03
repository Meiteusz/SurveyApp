using Models.Entities.Interfaces;
using System;
using System.Linq;

namespace Models
{
    public class User : IUser
    {
        #region Properties
        public int Id { get; set; }
        public byte UserType { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        #endregion

        public User() { }

        public User(string p_login, string p_password)
        {
            Login = p_login;
            Password = p_password;
        }

        public ResponseData<User> LoginUser(User user)
        {
            ResponseData<User> response = new ResponseData<User>();
            User LoggedUser = new User();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    LoggedUser = context.Users.SingleOrDefault(u => u.Login.Equals(user.Login) && u.Password.Equals(user.Password));
                }

                if (LoggedUser != null)
                {
                    response.Success = true;
                    response.Messege = "User logged";
                    response.GetData = LoggedUser;
                }
                else
                {
                    response.Success = false;
                    response.Messege = "User not finded";
                }

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Messege = ex.Message;
            }
            return response;
        }

        public bool UserIsAdmin(User user)
        {
            if (user.UserType.Equals(0))
                return true;
            return false;
        }
    }
}
