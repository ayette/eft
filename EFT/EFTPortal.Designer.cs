namespace EFT
{
    partial class EFTPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EFTPortal));
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnFunds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::EFT.Properties.Resources.pork_roast;
            this.btnMenu.Location = new System.Drawing.Point(40, 113);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(145, 71);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Canteen";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnFunds
            // 
            this.btnFunds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFunds.Image = global::EFT.Properties.Resources.money_bag;
            this.btnFunds.Location = new System.Drawing.Point(40, 26);
            this.btnFunds.Name = "btnFunds";
            this.btnFunds.Size = new System.Drawing.Size(145, 71);
            this.btnFunds.TabIndex = 0;
            this.btnFunds.Text = "Funds Management";
            this.btnFunds.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFunds.UseVisualStyleBackColor = true;
            this.btnFunds.Click += new System.EventHandler(this.btnFunds_Click);
            // 
            // EFTPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 229);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnFunds);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EFTPortal";
            this.Text = "EFT Portal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFunds;
        private System.Windows.Forms.Button btnMenu;
    }
}

