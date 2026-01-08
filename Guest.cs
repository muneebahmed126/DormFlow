namespace FormFlow.Model.Users
{
    public class Guest : User
    {
        public Guest() { }

        // Constructor for Guest (Fixes your 3rd error - 4 arguments)
        public Guest(int userId, string name, string cnic, string extra1 = "")
        {
            this.UserId = userId;
            this.Name = name;
            this.CNIC = cnic;
        }

        public override string GetRole() => "Guest";
    }
}