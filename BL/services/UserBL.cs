using DormFlow_Project.BL.Interfaces;
using DormFlow_Project.BL.validators;
using DormFlow_Project.DL.Interfaces;
using DormFlow_Project.Model_Layer.Users;

namespace DormFlow_Project.BL.Services
{
    public class UserBL : IUserBL
    {
        private readonly IUserDL userDL;

        public UserBL(IUserDL userDL)
        {
            this.userDL = userDL;
        }

        public void SignUp(User user, string username, string password)
        {
            UserValidator.Validate(user, username, password);
            userDL.SignUp(user, username, password);
        }

        public User SignIn(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            return userDL.SignIn(username, password);
        }
    }
}
