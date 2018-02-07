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

        public List<OrderItem> Items = new List<OrderItem>();

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

                    if (ded < 0)
                    {
                        MessageBox.Show("Insufficient fund.");
                        return;

                    }                  
                    else
                    {
                        result.Amount = result.Amount - amount;
                        db.SaveChanges();

                        // add to transaction history
                        List<TranDetail> tranDetails = new List<TranDetail>();

                        foreach (OrderItem item in Items)
                        {
                            TranDetail trand = new TranDetail();
                            
                            trand.Code = item.Code;
                            trand.Quantity = item.Quantity;
                            trand.Description = item.Description;
                            trand.Price = item.Price;

                            tranDetails.Add(trand);
                        }

                        Transaction tran = new Transaction();
                        tran.StudentId = studentId;
                        tran.Date = DateTime.Now;
                        tran.Amount = amount;
                        tran.TranDetails = tranDetails;

                        db.Transactions.Add(tran);
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
