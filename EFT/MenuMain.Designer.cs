namespace EFT
{
    partial class MenuMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMain));
            this.dgMenu = new System.Windows.Forms.DataGridView();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbAddMenu = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMenu
            // 
            this.dgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMenu.Location = new System.Drawing.Point(0, 0);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.Size = new System.Drawing.Size(1086, 708);
            this.dgMenu.TabIndex = 2;
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddMenu});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1086, 25);
            this.tsMenu.TabIndex = 3;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbAddMenu
            // 
            this.tsbAddMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddMenu.Image")));
            this.tsbAddMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddMenu.Name = "tsbAddMenu";
            this.tsbAddMenu.Size = new System.Drawing.Size(23, 22);
            this.tsbAddMenu.Text = "Add Menu";
            // 
            // MenuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 708);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.dgMenu);
            this.Name = "MenuMain";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMenu;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbAddMenu;
    }
}