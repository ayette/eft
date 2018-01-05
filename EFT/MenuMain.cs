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
    public partial class MenuMain : Form
    {
        public MenuMain()
        {
            InitializeComponent();
        }

        private void RefreshGrid()
        {
            using (var db = new Database())
            {
                dgMenu.DataSource = db.Menus.ToList();
            }
        }

        private void MenuMain_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
