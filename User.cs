namespace FormFlow.Model.Users
{
    public abstract class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string CNIC { get; set; }

        // This forces every child class to define its own role string
        public abstract string GetRole();
    }
}