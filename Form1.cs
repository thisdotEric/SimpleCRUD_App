using FluentValidation.Results;
using SimpleSystem.Validators;
using StudentDataAccess.Implementation;
using StudentDataAccess.Interface;
using StudentDataAccess.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SimpleSystem
{
    public partial class Form1 : Form
    {
        private readonly IStudentRepository studentRepository;
        private string _studentId;

        public Form1()
        {
            InitializeComponent();

            /*
                This dependecies should be remove, this project should only depend on the interfaces in StudentDomain project not on its specific implementation.
                But for demonstration purposes, this would do the job. Also have a look with IOC Containers, as they're commonly used in this situations.
             */

            this.studentRepository = new DapperSQLServerStudentRepository();
            //this.studentRepository = new SQLServerStudentRepository();
            //this.studentRepository = new SQLIteStudentRepository();
        }

        private async void AddStudent_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(yearLevel.Text, out _))
            {
                MessageBox.Show("Year Level must be a Number");

                return;
            }

            var studentDetails = CreateStudent();

            // Validation 
            StudentValidator studentValidator = new StudentValidator(this.studentRepository);
            ValidationResult validationResults = await studentValidator.ValidateAsync(studentDetails);
            if (!validationResults.IsValid)
            {
                var errorMessage = validationResults.Errors.First().ErrorMessage;

                MessageBox.Show(errorMessage);
                return;
            }


            await studentRepository.AddNewStudent(studentDetails);

            MessageBox.Show("New Student Added");
            ClearTextBoxes();

            this.studentDataGrid.DataSource = await studentRepository.GetAllStudents();
        }

        private IStudent CreateStudent()
        {
            return new Student()
            {
                StudentId = studentId.Text,
                FirstName = fname.Text,
                MiddleName = mname.Text,
                LastName = lname.Text,
                Course = course.Text,
                YearLevel = Convert.ToInt32(yearLevel.Text)
            };
        }

        private void ClearTextBoxes()
        {
            foreach (Control control in studentPanel.Controls)
            {
                if (control is RichTextBox textBox)
                    textBox.Text = string.Empty;
            }
        }

        private async void ViewAllStudents_Click(object sender, EventArgs e)
        {
            this.studentDataGrid.DataSource = await studentRepository.GetAllStudents();
        }

        private async void SearchStudent_Click(object sender, EventArgs e)
        {
            var student = await studentRepository.GetIndividualStudent(studentIdSearchTextBox.Text);

            if (student is null)
            {
                MessageBox.Show("Student Not Found");
                return;
            }

            MessageBox.Show("Student Found");
        }

        private void ChooseStudent_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = studentDataGrid.Rows[e.RowIndex];

            var student = new Student()
            {
                StudentId = row.Cells[0].Value.ToString(),
                FirstName = row.Cells[1].Value.ToString(),
                MiddleName = row.Cells[2].Value.ToString(),
                LastName = row.Cells[3].Value.ToString(),
                Course = row.Cells[4].Value.ToString(),
                YearLevel = Convert.ToInt32(row.Cells[5].Value.ToString())
            };

            _studentId = student.StudentId;

            PopulateTextBoxes(student);
            deleteStudentButton.Enabled = true;
        }

        private async void deleteStudentButton_Click(object sender, EventArgs e)
        {
            await studentRepository.DeleteStudent(_studentId);
            studentDataGrid.DataSource = await studentRepository.GetAllStudents();

            deleteStudentButton.Enabled = false;
        }


        private void PopulateTextBoxes(IStudent student)
        {
            studentId.Text = student.StudentId;
            fname.Text = student.FirstName;
            mname.Text = student.MiddleName;
            lname.Text = student.LastName;
            course.Text = student.Course;
            yearLevel.Text = student.YearLevel.ToString();
        }
    }
}
