namespace FormFlow.UI
{
    public partial class UC_MyFees : UserControl
    {
        private int studentId;

        public UC_MyFees(int id)
        {
            InitializeComponent();
            this.studentId = id;
            // Logic: SELECT * FROM Fees WHERE StudentId = @id
        }
    }
}