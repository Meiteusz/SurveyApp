using Models;

namespace Controllers
{
    public abstract class UserSetting
    {
        public static User LoggedUser { get; private set; }

        public static void SetLoggedUser(User user)
        {
            LoggedUser = user;
        }
    }
}
