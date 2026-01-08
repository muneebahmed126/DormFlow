using FormFlow.Model.Users;       // To see the User types
using FormFlow.DL.Interfaces;     // To see the DL Interfaces
using FormFlow.DL.Repositories;   // To see the DL Logic
using FormFlow.BL.validators;     // To see your Validation logic
using FormFlow.BL.Interfaces;

namespace FormFlow.BL.services
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
            // Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Username and Password are required.");
            }

            // Call DL to check database
            User user = userDL.SignIn(username, password);

            if (user == null)
            {
                throw new Exception("Invalid Username or Password.");
            }

            return user;
        }
    }
}
