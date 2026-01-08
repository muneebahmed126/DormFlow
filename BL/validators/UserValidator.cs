using System;
using DormFlow_Project.Model_Layer.Users;

namespace DormFlow_Project.BL.Validators
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

            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Username is required");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password is required");

            if (password.Length < 6)
                throw new Exception("Password must be at least 6 characters");
        }
    }
}
