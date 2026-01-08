namespace FormFlow.Model.Users
{
    public class Student : User
    {
        public Student() { }

        // Constructor for Student 
        
        public Student(int userId, string name, string cnic, string extra1 = "", string extra2 = "")
        {
            this.UserId = userId;
            this.Name = name;
            this.CNIC = cnic;
        }

        public override string GetRole() => "Student";
    }
}