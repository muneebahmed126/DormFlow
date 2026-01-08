using System;
using FormFlow.Model.Users;

namespace FormFlow.BL.validators
{
    public static class UserValidator
    {
        public static void Validate(User user, string username, string password)
        {
            if (user == null)
                throw new Exception("User object is null");

            if (string.IsNullOrWhiteSpace(user.Name))
                throw new Exception("Name is required");

            if (string.IsNullOrWhiteSpace(user.CNIC))
                throw new Exception("CNIC is required");
            if (user.CNIC.Length != 13)
            {
                throw new Exception("CNIC must be exactly 13 characters long.");
            }
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Username is required");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password is required");
            
            if (password.Length < 6)
                throw new Exception("Password must be at least 6 characters");
        }
    }
}
