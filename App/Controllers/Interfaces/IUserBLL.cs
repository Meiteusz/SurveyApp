using Models;
using System;
using System.Collections.Generic;

namespace Controllers
{
    public interface IUserBLL
    {
        User Create();
        User Create(string Login, string Password);
        User Create(string Name,  byte UserType, string Cpf, string Login, string Email, string Password);
        ResponseData<string> EncryptPassword(string Password);
        ResponseData<string> DecryptPassword(string EncryptedPassword);
        ResponseData<User> LoginUser(User user);
        Response Insert(User user);
        Response Update(User user);
        ResponseData<List<User>> GetAll();
        Array GetUserTypes();
    }
}
