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
    public partial class EFTPortal : Form
    {
        public EFTPortal()
        {
            InitializeComponent();
        }

        private void btnFunds_Click(object sender, EventArgs e)
        {
            FundsManagement sd = new FundsManagement();

            
            sd.Show(); // Multiple window
            // sd.ShowDialog(); // Single Window window
        }
    }
}
