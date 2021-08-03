namespace Models.Entities.Interfaces
{
    public interface IUser
    {
        ResponseData<User> LoginUser(User user);
        public bool UserIsAdmin(User user);
    }
}
