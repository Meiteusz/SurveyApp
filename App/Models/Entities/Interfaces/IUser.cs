using System.Collections.Generic;

namespace Models.Entities.Interfaces
{
    public interface IUser
    {
        ResponseData<User> LoginUser(User p_user);
        Response Insert(User p_user);
        Response Update(User p_user);
        ResponseData<List<User>> GetAll();
        ResponseData<User> GetById(int p_Id);
    }
}
