using DormFlow_Project.Model_Layer.Users;

namespace DormFlow_Project.BL.Interfaces
{
    public interface IUserBL
    {
        void SignUp(User user, string username, string password);
        User SignIn(string username, string password);
    }
}
