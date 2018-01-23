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
    public partial class Order : Form
    {
        List<OrderItem> items = new List<OrderItem>();
        int count = 0;
        public Order()
        {
            InitializeComponent();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                using (var db = new Database())
                {

                    var m = db.Menus.Where(x => x.Code == txtCode.Text).SingleOrDefault();

                    if (m != null)
                    {
                        numPrice.Value = m.Amount;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new Database())
            {

                var m = db.Menus.Where(x => x.Code == txtCode.Text).SingleOrDefault();

                if (m != null)
                {


                    OrderItem item = new OrderItem();
                    count++;
                    item.Id = count;
                    item.Code = txtCode.Text;
                    item.Description = m.Description;
                    item.Price = m.Amount;
                    item.Quantity = (int)numQuantity.Value;

                    items.Add(item);
                }
            }

            RefreshGrid();
            ClearValue();
            ComputeTotal();
        }

        private void ClearValue()
        {
            txtCode.Text = string.Empty;
            numPrice.Value = 0;
            numQuantity.Value = 1;
            txtCode.Focus();
        }

        private void ComputeTotal()
        {
            decimal total = 0;

            foreach (var x in items)
            {
                total += (x.Price * x.Quantity);
            }



            lblTotal.Text = total.ToString("#.00");

        }

        private void RefreshGrid()
        {
            dgOrder.DataSource = items.ToList();
            dgOrder.Update();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.TotalAmount = Convert.ToDecimal(lblTotal.Text);
            pay.Items = items;
            pay.ShowDialog();

            txtCode.Text = string.Empty;
            lblTotal.Text = "0.00";
            numQuantity.Value = 1;
            numPrice.Value = 0;
            dgOrder.DataSource = null;
            items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgOrder.SelectedRows.Count > 0)
            {
                long id = Convert.ToInt64(dgOrder.Rows[dgOrder.CurrentRow.Index].Cells["Id"].Value);

                var data = items.Where(x => x.Id == id).Single();

                if (data != null)
                {
                    items.Remove(data);
                    RefreshGrid();
                    ComputeTotal();
                }
            }
        }
    }
}
