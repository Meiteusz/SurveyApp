using Models;
using Models.Entities.Interfaces;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

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

        public ResponseData<string> EncryptPassword(string Password)
        {
            ResponseData<string> response = new ResponseData<string>();

            string key = "b14ca5898a4e4133bbce2ea2315a1916";
            byte[] iv = new byte[16];
            byte[] array;

            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key);
                    aes.IV = iv;

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                            {
                                streamWriter.Write(Password);
                            }

                            array = memoryStream.ToArray();

                            response.Success = true;
                            response.Data = Convert.ToBase64String(array);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public ResponseData<string> DecryptPassword(string EncryptedPassword)
        {
            ResponseData<string> response = new ResponseData<string>();

            string key = "b14ca5898a4e4133bbce2ea2315a1916";
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(EncryptedPassword);

            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key);
                    aes.IV = iv;
                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    using (MemoryStream memoryStream = new MemoryStream(buffer))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader streamReader = new StreamReader(cryptoStream))
                            {
                                response.Success = true;
                                response.Data = streamReader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public ResponseData<User> LoginUser(User user)
        {
            var userLogged = _User.LoginUser(user);

            if (userLogged.Data != null)
                UserSetting.SetLoggedUser(userLogged.Data); //improving

            return userLogged;
        }

        public Response Insert(User user)
        {
            Response response = user.UserValidate();

            if (response.Success)
            {
                user.Password = EncryptPassword(user.Password).Data;
                return _User.Insert(user);
            }
            else
                return response;
        }

        public Response Update(User user)
        {
            Response response = user.UserValidate();

            if (response.Success)
            {
                user.Password = EncryptPassword(user.Password).Data;
                return _User.Update(user);
            }
            else
                return response;
        }

        public ResponseData<List<User>> GetAll()
        {
            return _User.GetAll();
        }

        public Array GetUserTypes() => Enum.GetValues(typeof(UserTypes));

        public string GetNameOfUserType(byte userType) => Enum.GetName(typeof(UserTypes), userType);
    }
}
