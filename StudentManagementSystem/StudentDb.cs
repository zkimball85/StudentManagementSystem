
using Microsoft.Data.SqlClient;

namespace StudentManagementSystem
{
    static class StudentDb
    {

        /// <summary>
        /// Adds a student to the database.
        /// </summary>
        /// <param name="s">Student to be added</param>
        public static void Add(Student s)
        {
            // Establish a connection to the database
            SqlConnection con = new SqlConnection("Data Source=ZACS_WINDOWS;Initial Catalog=SMS;Integrated Security=True;");

            // Prepare an SQL INSERT statement to add the student record
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            // Parameterized query to prevent SQL injection
            insertCmd.CommandText = "INSERT INTO Student(FName, LName, DateOfBirth)" +
                "VALUES (@FName, @LName, @DateOfBirth)";
            insertCmd.Parameters.AddWithValue("@FName", s.FirstName);
            insertCmd.Parameters.AddWithValue("@LName", s.LastName);
            insertCmd.Parameters.AddWithValue("@DateOfBirth", s.DateOfBirth);

            // Open the database connection
            con.Open();

            // Execute the SQL command to insert the student data
            insertCmd.ExecuteNonQuery();

            // Close the database connection
            con.Close();


        }

        public static List<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public static void Update(Student s)
        {
            throw new NotImplementedException();
        }

        public static void Delete(Student s)
        {
            throw new NotImplementedException();
        }

        public static void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public static Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
