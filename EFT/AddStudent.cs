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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
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
            else
            {
                // Save to database
                using (var db = new Database())
                {
                    Student stud = new Student();

                    stud.Number = txtStudentNumber.Text;
                    stud.FirstName = txtFirstName.Text;
                    stud.LastName = txtLastName.Text;
                    stud.Amount = numFunds.Value;

                    db.Students.Add(stud);
                    db.SaveChanges();
                }

                this.Close();
            }
        }

        public bool CheckDuplicateStudentNo(string studentNo)
        {
            using (var db = new Database())
            {
                var stud = db.Students.Where(x => x.Number == studentNo).ToList();
                return stud.Count > 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

