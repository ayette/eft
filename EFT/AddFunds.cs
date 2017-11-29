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
    public partial class AddFunds : Form
    {
        long studentId = 0;
        public AddFunds()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new Database())
            {
                var result = db.Students.SingleOrDefault(b => b.Id == studentId);
                if (result != null)
                {
                    result.Amount = result.Amount + numAmount.Value;
                    db.SaveChanges();

                    MessageBox.Show("Successfuly funds updated.");
                    txtName.Text = string.Empty;
                    txtStudentNumber.Text = string.Empty;
                    numAmount.Value = 0;
                    studentId = 0;                    
                }
            }

            this.Close();
        }

        private void txtStudentNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                using (var db = new Database())
                {

                    var s = db.Students.Where(x => x.Number == txtStudentNumber.Text).SingleOrDefault();

                    if (s != null)
                    {
                        studentId = s.Id;
                        txtName.Text = $"{s.FirstName} {s.LastName}";
                    }
                }
            }
        }

        private void AddFunds_Load(object sender, EventArgs e)
        {
            txtStudentNumber.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
