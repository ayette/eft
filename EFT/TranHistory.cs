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
    public partial class TranHistory : Form
    {
        public long StudentId { get; set; }
        public TranHistory()
        {
            InitializeComponent();
        }

        private void TranHistory_Load(object sender, EventArgs e)
        {
            using (var db = new Database())
            {

                //var s = db.Transactions.Where(x => x.Id == StudentId).SingleOrDefault();

                var results = from tran in db.Transactions
                              join details in db.TranDetails on tran.Id equals details.TransactionId
                              where (tran.StudentId == StudentId)
                              select new {
                                  Code = details.Code,
                                  Description = details.Description,
                                  Quantity = details.Quantity,
                                  Price = details.Price,
                                  Title = tran.Date.ToString() + " Amount: " +  tran.Amount.ToString()
                              };


                olvTranHistory.ShowGroups = true;
                olvTranHistory.SetObjects(results.ToList());
                


            }
        }

        private string FormatGroup (DateTime date, decimal amount)
        {
            return "Test";
        }
    }
}
