﻿using System;
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

        private void tsbAddMenu_Click(object sender, EventArgs e)
        {
            AddMenu addMenu = new AddMenu();
            addMenu.ShowDialog();
            RefreshGrid();
        }
    }
}
