namespace Models.Entities.Interfaces
{
    public interface IUser
    {
        ResponseData<User> LoginUser(User user);
        Response Insert(User user);
    }
}
