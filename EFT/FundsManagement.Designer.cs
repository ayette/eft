namespace EFT
{
    partial class FundsManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FundsManagement));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbAdd = new System.Windows.Forms.ToolStripButton();
            this.tbAddFunds = new System.Windows.Forms.ToolStripButton();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transactions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tsbViewTransactions = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbAdd,
            this.tbAddFunds,
            this.tsbViewTransactions});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(859, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbAdd
            // 
            this.tbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAdd.Image = global::EFT.Properties.Resources.users;
            this.tbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(23, 22);
            this.tbAdd.Text = "Add Student";
            this.tbAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // tbAddFunds
            // 
            this.tbAddFunds.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAddFunds.Image = global::EFT.Properties.Resources.coins__3_;
            this.tbAddFunds.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAddFunds.Name = "tbAddFunds";
            this.tbAddFunds.Size = new System.Drawing.Size(23, 22);
            this.tbAddFunds.Text = "Add Funds";
            this.tbAddFunds.Click += new System.EventHandler(this.tbAddFunds_Click);
            // 
            // dgStudent
            // 
            this.dgStudent.AllowUserToAddRows = false;
            this.dgStudent.AllowUserToDeleteRows = false;
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Number,
            this.LastName,
            this.FirstName,
            this.Amount,
            this.Transactions});
            this.dgStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStudent.Location = new System.Drawing.Point(0, 25);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.ReadOnly = true;
            this.dgStudent.Size = new System.Drawing.Size(859, 496);
            this.dgStudent.TabIndex = 1;
            this.dgStudent.DoubleClick += new System.EventHandler(this.dgStudent_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Funds";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Transactions
            // 
            this.Transactions.DataPropertyName = "Transactions";
            this.Transactions.HeaderText = "Transactions";
            this.Transactions.Name = "Transactions";
            this.Transactions.ReadOnly = true;
            this.Transactions.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lesson.png");
            this.imageList1.Images.SetKeyName(1, "coins (1).png");
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = false;
            // 
            // tsbViewTransactions
            // 
            this.tsbViewTransactions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbViewTransactions.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewTransactions.Image")));
            this.tsbViewTransactions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewTransactions.Name = "tsbViewTransactions";
            this.tsbViewTransactions.Size = new System.Drawing.Size(105, 22);
            this.tsbViewTransactions.Text = "View Transactions";
            this.tsbViewTransactions.Click += new System.EventHandler(this.tsbViewTransactions_Click);
            // 
            // FundsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 521);
            this.Controls.Add(this.dgStudent);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FundsManagement";
            this.Text = "Funds Management";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transactions;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbAdd;
        private System.Windows.Forms.ToolStripButton tbAddFunds;
        private System.Windows.Forms.ToolStripButton tsbViewTransactions;
    }
}