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
    public partial class EditMenu : Form
    {
        public long  ItemId { get; set; }
        public EditMenu()
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
                    var menu = db.Menus.Where(x => x.Id == ItemId).SingleOrDefault();

                    menu.Code = txtCode.Text;
                    menu.Description = txtDescription.Text;
                    menu.Amount = numAmount.Value;
                    db.SaveChanges();
                }

                this.Close();
            }
        }

        public bool CheckDuplicateItemCode(string itemCode)
        {
            using (var db = new Database())
            {
                var menu = db.Menus.Where(x =>  x.Code == txtCode.Text && x.Id != ItemId).ToList();
                return menu.Count > 0;
            }
        }

        private void EditMenu_Load(object sender, EventArgs e)
        {
            using (var db = new Database())
            {

                var s = db.Menus.Where(x => x.Id == ItemId).SingleOrDefault();

                if (s != null)
                {
                    txtCode.Text = s.Code;
                    txtDescription.Text = s.Description;                    
                    numAmount.Value = s.Amount;
                }
            }
        }
    }
}
