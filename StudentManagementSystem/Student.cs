
namespace StudentManagementSystem
{
    internal class Student
    {
        // Fully implemented C# property
        private int _studentId;

        public Student(string fName, string lName, DateTime dob) 
        {
            FirstName = fName;
            LastName = lName;
            DateOfBirth = dob;
        }

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

        public string FullName 
        { 
            get
            {
                return FirstName + " " + LastName;
            } 
        }

        public DateTime DateOfBirth { get; set; }

        

    }
}
