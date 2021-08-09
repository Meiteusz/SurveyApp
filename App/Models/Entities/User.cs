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

        #region Constructors
        public User() { }

        public User(string p_login, string p_password)
        {
            Login = p_login;
            Password = p_password;
        }

        public User(string p_Name, byte p_UserType, string p_Cpf, string p_Login, string p_Email, string p_Password)
        {
            Name = p_Name;
            UserType = p_UserType;
            Cpf = p_Cpf;
            Login = p_Login;
            Email = p_Email;
            Password = p_Password;
        }
        #endregion

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
                    response.Messege = "User not finded";
                }

            }
            catch (Exception ex)
            {
                response.Messege = ex.Message;
            }
            return response;
        }

        public Response Insert(User user)
        {
            Response response = new Response();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    context.Users.Add(user);
                    context.SaveChanges();

                    response.Success = true;
                    response.Messege = "User Registered succeffuly";
                }
            }
            catch (Exception ex)
            {
                response.Messege = ex.Message;
            }
            return response;
        }
    }
}
