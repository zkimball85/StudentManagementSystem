namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Test Code
            Student stu = new Student("Zac", "Kimball", new DateTime(1985, 11, 26));
        }
    }
}
