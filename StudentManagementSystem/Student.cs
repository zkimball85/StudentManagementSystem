
namespace StudentManagementSystem
{
    /// <summary>
    /// Represents a Student with properties such as StudentId,
    /// FirstName, LastName, FullName, and DateOfBirth.
    /// </summary>
    internal class Student
    {
        // Fully implemented C# property
        private int _studentId;

        /// <summary>
        /// Creates a student with the specified name and date of birth.
        /// </summary>
        /// <param name="fName">The student's first name.</param>
        /// <param name="lName">The student's last name.</param>
        /// <param name="dob">The student's date of birth.</param>
        public Student(string fName, string lName, DateTime dob) 
        {
            FirstName = fName;
            LastName = lName;
            DateOfBirth = dob;
        }

        /// <summary>
        /// The student's unique ID number.
        /// </summary>
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
        /// <summary>
        /// Legal First Name of the student. This property is required and cannot be null or empty.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Legal Last Name of the student. This property is required and cannot be null or empty.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The students first and last name formatted as "FirstName LastName".
        /// </summary>
        public string FullName 
        { 
            get
            {
                return FirstName + " " + LastName;
            } 
        }

        /// <summary>
        /// The student's date of birth. This property is required and must be a valid date in the past.
        /// Time is ignored.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        public byte GetAge()
        { 
            int yearBorn = DateOfBirth.Year;
            int currentYear = DateTime.Now.Year;

            return (byte)(currentYear - yearBorn);
        }
    }
}
