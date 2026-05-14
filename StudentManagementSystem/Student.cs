
namespace StudentManagementSystem
{
    internal class Student
    {
        // Fully implemented C# property
        private int _studentId;

        public int StudentId
        {
            get
            {
                return _studentId;
            }
            set
            {
                _studentId = value;
            }
        }

        // Auto-implemented property
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        

    }
}
