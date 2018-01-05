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
    public partial class Canteen : Form
    {

        List<OrderItem> items = new List<OrderItem>();
        
        public Canteen()
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }
    }
}
