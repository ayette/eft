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
    public partial class FundsManagement : Form
    {

        

        public FundsManagement()
        {
            InitializeComponent();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

            RefreshGrid();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl1.SelectedIndex == 1)
            // {
            //     // Focus cursor for barcode reader
            //     txtStudentNumber.Focus();
            // }
        }

        private void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentNumber_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    using (var db = new Database())
            //    {

            //        var s = db.Students.Where(x => x.Number == txtStudentNumber.Text).SingleOrDefault();

            //        if (s != null)
            //        {
            //            studentId = s.Id;
            //            txtName.Text = s.LastName + " " + s.FirstName;
            //        }
            //    }
            //}
        }

        private void btnAddFunds_Click(object sender, EventArgs e)
        {
            //using (var db = new Database())
            //{
            //    var result = db.Students.SingleOrDefault(b => b.Id == studentId);
            //    if (result != null)
            //    {
            //        result.Amount = result.Amount + numAmount.Value;
            //        db.SaveChanges();

            //        MessageBox.Show("Successfuly funds updated.");
            //        txtName.Text = string.Empty;
            //        txtStudentNumber.Text = string.Empty;
            //        numAmount.Value = 0;
            //        studentId = 0;
            //        txtStudentNumber.Focus();
            //        RefreshGrid();
            //    }
            //}
        }

        private void RefreshGrid()
        {
            using (var db = new Database())
            {
                dgStudent.DataSource = db.Students.ToList();
            }
        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent();
            add.ShowDialog();
            RefreshGrid();
        }

        private void tbAddFunds_Click(object sender, EventArgs e)
        {
            AddFunds add = new AddFunds();
            add.ShowDialog();
            RefreshGrid();
        }

        private void dgStudent_DoubleClick(object sender, EventArgs e)
        {
            if (dgStudent.CurrentRow.Index >= 0)
            {
                long id = Convert.ToInt64(dgStudent.Rows[dgStudent.CurrentRow.Index].Cells["Id"].Value);

                EditStudent obj = new EditStudent();

                obj.StudentId = id;
                obj.ShowDialog();
                RefreshGrid();

            }
        }

        private void tsbViewTransactions_Click(object sender, EventArgs e)
        {
            if (dgStudent.CurrentRow.Index >= 0)
            {
                long id = Convert.ToInt64(dgStudent.Rows[dgStudent.CurrentRow.Index].Cells["Id"].Value);

                TranHistory obj = new TranHistory();

                obj.StudentId = id;
                obj.ShowDialog();
                
            }
        }
    }
}
