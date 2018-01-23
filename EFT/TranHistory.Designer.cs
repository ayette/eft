namespace EFT
{
    partial class TranHistory
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
            this.olvTranHistory = new BrightIdeasSoftware.ObjectListView();
            this.Title = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Code = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Quantity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Price = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvTranHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // olvTranHistory
            // 
            this.olvTranHistory.AllColumns.Add(this.Title);
            this.olvTranHistory.AllColumns.Add(this.Code);
            this.olvTranHistory.AllColumns.Add(this.Description);
            this.olvTranHistory.AllColumns.Add(this.Quantity);
            this.olvTranHistory.AllColumns.Add(this.Price);
            this.olvTranHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Code,
            this.Description,
            this.Quantity,
            this.Price});
            this.olvTranHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvTranHistory.Location = new System.Drawing.Point(0, 0);
            this.olvTranHistory.Name = "olvTranHistory";
            this.olvTranHistory.ShowGroups = false;
            this.olvTranHistory.Size = new System.Drawing.Size(1015, 590);
            this.olvTranHistory.TabIndex = 1;
            this.olvTranHistory.UseAlternatingBackColors = true;
            this.olvTranHistory.UseCompatibleStateImageBehavior = false;
            this.olvTranHistory.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.AspectName = "Title";
            this.Title.CellPadding = null;
            this.Title.IsVisible = false;
            this.Title.ShowTextInHeader = false;
            this.Title.Text = "Title";
            this.Title.Width = 0;
            // 
            // Code
            // 
            this.Code.AspectName = "Code";
            this.Code.CellPadding = null;
            this.Code.Groupable = false;
            this.Code.Text = "Code";
            this.Code.Width = 160;
            // 
            // Description
            // 
            this.Description.AspectName = "Description";
            this.Description.AspectToStringFormat = "";
            this.Description.CellPadding = null;
            this.Description.Groupable = false;
            this.Description.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Description.Text = "Description";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Description.Width = 94;
            // 
            // Quantity
            // 
            this.Quantity.AspectName = "Quantity";
            this.Quantity.AspectToStringFormat = "{0:d}";
            this.Quantity.CellPadding = null;
            this.Quantity.Groupable = false;
            this.Quantity.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.Width = 150;
            // 
            // Price
            // 
            this.Price.AspectName = "Price";
            this.Price.CellPadding = null;
            this.Price.Groupable = false;
            this.Price.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 85;
            // 
            // TranHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 590);
            this.Controls.Add(this.olvTranHistory);
            this.Name = "TranHistory";
            this.Text = "TranHistory";
            this.Load += new System.EventHandler(this.TranHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvTranHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvTranHistory;
        private BrightIdeasSoftware.OLVColumn Code;
        private BrightIdeasSoftware.OLVColumn Description;
        private BrightIdeasSoftware.OLVColumn Quantity;
        private BrightIdeasSoftware.OLVColumn Price;
        private BrightIdeasSoftware.OLVColumn Title;
    }
}