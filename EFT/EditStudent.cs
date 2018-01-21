using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFT
{
    public partial class EditStudent : Form
    {
        public long StudentId { get; set; }

        public EditStudent()
        {
            InitializeComponent();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            using (var db = new Database())
            {

                var s = db.Students.Where(x => x.Id == StudentId).SingleOrDefault();

                if (s != null)
                {
                    txtFirstName.Text = s.FirstName;
                    txtLastName.Text = s.LastName;
                    txtStudentNumber.Text = s.Number;
                    numFunds.Value = s.Amount;                    
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check duplicate student
            if (CheckDuplicateStudentNo(txtStudentNumber.Text))
            {
                MessageBox.Show("Duplicate Student Number.", "Error", MessageBoxButtons.OK);
            }
            // Check if Firstname is blank
            else if (txtFirstName.Text == string.Empty)
            {
                MessageBox.Show("First name is required.", "Error", MessageBoxButtons.OK);
            }
            else if (txtLastName.Text == string.Empty)
            {
                MessageBox.Show("Last name is required.", "Error", MessageBoxButtons.OK);
            }
            else if (numFunds.Value > 10000)
            {
                MessageBox.Show("Invalid value.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                // Save to database
                using (var db = new Database())
                {
                    var stud = db.Students.Where(x => x.Id == StudentId).SingleOrDefault();

                    stud.Number = txtStudentNumber.Text;
                    stud.FirstName = txtFirstName.Text;
                    stud.LastName = txtLastName.Text;
                    stud.Amount = numFunds.Value;
                    
                    db.SaveChanges();
                }

                this.Close();
            }
        }

        public bool CheckDuplicateStudentNo(string studentNo)
        {
            using (var db = new Database())
            {
                var stud = db.Students.Where(x => x.Number == studentNo && x.Id != StudentId).ToList();
                return stud.Count > 0;
            }
        }
    }
}
