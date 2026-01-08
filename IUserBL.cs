using FormFlow.Model.Users;

namespace FormFlow.BL.Interfaces
{
    public interface IUserBL
    {
        void SignUp(User user, string username, string password);
        User SignIn(string username, string password);
    }
}
