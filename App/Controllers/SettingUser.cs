using Models;

namespace Controllers
{
    public abstract class SettingUser
    {
        public static User LoggedUser { get; private set; }

        public static void SetLoggedUser(User user)
        {
            LoggedUser = user;
        }
    }
}
