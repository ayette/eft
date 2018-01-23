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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnFunds_Click(object sender, EventArgs e)
        {
            FundsManagement sd = new FundsManagement();
            sd.MdiParent = this.MdiParent;
            sd.Show(); 
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuMain canteen = new MenuMain();
            canteen.MdiParent = this.MdiParent;
            canteen.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {            
            Order order = new Order();
            order.MdiParent = this.MdiParent;
            order.Show();
        }
    }
}
