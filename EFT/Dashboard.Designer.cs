namespace EFT
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnFunds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPOS
            // 
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPOS.Image = global::EFT.Properties.Resources.cashier_machine;
            this.btnPOS.Location = new System.Drawing.Point(580, 154);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(145, 105);
            this.btnPOS.TabIndex = 5;
            this.btnPOS.Text = "Order";
            this.btnPOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Image = global::EFT.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(357, 154);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(145, 105);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnFunds
            // 
            this.btnFunds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFunds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFunds.Image = global::EFT.Properties.Resources.money_bag1;
            this.btnFunds.Location = new System.Drawing.Point(137, 154);
            this.btnFunds.Name = "btnFunds";
            this.btnFunds.Size = new System.Drawing.Size(145, 105);
            this.btnFunds.TabIndex = 3;
            this.btnFunds.Text = "Funds";
            this.btnFunds.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFunds.UseVisualStyleBackColor = true;
            this.btnFunds.Click += new System.EventHandler(this.btnFunds_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 569);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnFunds);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnFunds;
    }
}