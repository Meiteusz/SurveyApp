using Models;

namespace Controllers
{
    public interface IUserBLL
    {
        User Create();
        User Create(string Login, string Password);
        User Create(string Name,  byte UserType, string Cpf, string Login, string Email, string Password);
        ResponseData<User> LoginUser(User user);
        Response Insert(User user);
    }
}
