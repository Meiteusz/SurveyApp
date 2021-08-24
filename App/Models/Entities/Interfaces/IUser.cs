using System.Collections.Generic;

namespace Models.Entities.Interfaces
{
    public interface IUser
    {
        ResponseData<User> LoginUser(User user);
        Response Insert(User user);
        Response Update(User user);
        ResponseData<List<User>> GetAll();
    }
}
