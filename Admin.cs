namespace FormFlow.Model.Users
{
    public class Admin : User
    {
        // Empty constructor for the SignUp form
        public Admin() { }

        // Constructor with 3 arguments (Fixes your 1st error)
        public Admin(int userId, string name, string cnic)
        {
            this.UserId = userId;
            this.Name = name;
            this.CNIC = cnic;
        }

        public override string GetRole() => "Admin";
    }
}