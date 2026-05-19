using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class CreateStudent : Form
    {
        public CreateStudent()
        {
            InitializeComponent();
        }

        private void BtnCreateStudent_Click(object sender, EventArgs e)
        {
            // Assume data is valid

            string firstName = txtFName.Text;
            string lastName = txtLName.Text;
            DateTime dateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);

            Student stu = new Student(firstName, lastName, dateOfBirth);

            StudentDb.Add(stu);
            MessageBox.Show("Student added successfully!");
            Close();

        }
    }
}
