using Microsoft.EntityFrameworkCore;
using Models.Entities.Interfaces;
using System;
using System.Collections.Generic;
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

        public User(string p_Login, string p_Password)
        {
            Login = p_Login;
            Password = p_Password;
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

        public ResponseData<User> LoginUser(User p_user)
        {
            ResponseData<User> response = new ResponseData<User>();
            User LoggedUser = new User();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    LoggedUser = context.Users.SingleOrDefault(u => u.Login.Equals(p_user.Login) && u.Password.Equals(p_user.Password));
                }

                if (LoggedUser != null)
                {
                    response.Success = true;
                    response.Message = "User logged";
                    response.Data = LoggedUser;
                }
                else
                {
                    response.Message = "User not finded";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public Response Insert(User p_user)
        {
            Response response = new Response();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    context.Users.Add(p_user);
                    context.SaveChanges();

                    response.Success = true;
                    response.Message = "User Registered succeffuly";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public Response Update(User p_user)
        {
            Response response = new Response();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    context.Entry(p_user).State = EntityState.Modified;
                    context.SaveChanges();

                    response.Success = true;
                    response.Message = "User Updated";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public ResponseData<List<User>> GetAll()
        {
            ResponseData<List<User>> response = new ResponseData<List<User>>();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    var usersList = context.Users.ToList();

                    response.Success = true;
                    response.Data = usersList;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public ResponseData<User> GetById(int p_Id)
        {
            ResponseData<User> response = new ResponseData<User>();

            try
            {
                using (var context = new SurveyAppContext())
                {


                    var survey = context.Users.FirstOrDefault(u => u.Id.Equals(p_Id));

                    response.Success = true;
                    response.Data = survey;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public ResponseData<int> GetUsersCount()
        {
            ResponseData<int> response = new ResponseData<int>();

            try
            {
                using (var context = new SurveyAppContext())
                {
                    var survey = context.Users.Count();

                    response.Success = true;
                    response.Data = survey;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
