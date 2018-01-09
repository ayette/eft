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
    public partial class Pay : Form
    {

        long studentId = 0;
        public decimal TotalAmount { get; set; }
        public Pay()
        {
            InitializeComponent();
        }

        private void txtStudentNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                using (var db = new Database())
                {

                    var s = db.Students.Where(x => x.Number == txtStudentNumber.Text).SingleOrDefault();

                    if (s != null)
                    {
                        studentId = s.Id;
                        lblName.Text = s.LastName + " " + s.FirstName;
                    }
                }
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

            decimal ded = 0;
            decimal amount = 0;

            using (var db = new Database())
            {
                var result = db.Students.SingleOrDefault(b => b.Id == studentId);
                if (result != null)
                {
                    amount = Convert.ToDecimal(lblAmount.Text);
                    ded = result.Amount - amount;

                    if (ded <0)
                    {
                        MessageBox.Show("Insufficient fund.");
                        return;

                    }                  
                    else
                    {
                        result.Amount = result.Amount - amount;
                        db.SaveChanges();
                    }
                }
            }

            lblName.Text = string.Empty;
            lblAmount.Text = "0.00";
            this.Hide();
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            lblAmount.Text = TotalAmount.ToString();
        }
    }
}
