namespace FormFlow.UI
{
    public partial class UC_MyRoomDetail : UserControl
    {
        private int studentId;

        public UC_MyRoomDetail(int id)
        {
            InitializeComponent();
            this.studentId = id;
            // Add your logic here to fetch room from database using this.studentId
        }
    }
}
