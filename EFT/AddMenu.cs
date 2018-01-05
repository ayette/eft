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
    public partial class AddMenu : Form
    {
        public AddMenu()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check duplicate student
            if (CheckDuplicateItemCode(txtCode.Text))
            {
                MessageBox.Show("Duplicate Item code", "Error", MessageBoxButtons.OK);
            }
            // Check if Firstname is blank
            else if (txtDescription.Text == string.Empty)
            {
                MessageBox.Show("Description is required.", "Error", MessageBoxButtons.OK);
            }            
            else
            {
                // Save to database
                using (var db = new Database())
                {
                    Menu menu = new EFT.Menu();

                    menu.Code = txtCode.Text;
                    menu.Description = txtDescription.Text;
                    menu.Amount = numAmount.Value;                    
                    db.Menus.Add(menu);
                    db.SaveChanges();
                }

                this.Close();
            }
        }

        public bool CheckDuplicateItemCode(string itemCode)
        {
            using (var db = new Database())
            {
                var menu = db.Menus.Where(x => x.Code == itemCode).ToList();
                return menu.Count > 0;
            }
        }
    }
}
