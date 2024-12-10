namespace ESMSystem.Views
{
    partial class FrmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItems));
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.SidebarItems = new System.Windows.Forms.Label();
            this.SidebarItemsPic = new System.Windows.Forms.PictureBox();
            this.ItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidebarItemsPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.Controls.Add(this.SidebarItems);
            this.ItemsPanel.Controls.Add(this.SidebarItemsPic);
            this.ItemsPanel.Location = new System.Drawing.Point(438, 248);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(218, 46);
            this.ItemsPanel.TabIndex = 3;
            // 
            // SidebarItems
            // 
            this.SidebarItems.AutoSize = true;
            this.SidebarItems.Location = new System.Drawing.Point(42, 12);
            this.SidebarItems.Name = "SidebarItems";
            this.SidebarItems.Size = new System.Drawing.Size(48, 16);
            this.SidebarItems.TabIndex = 3;
            this.SidebarItems.Text = "ITEMS";
            // 
            // SidebarItemsPic
            // 
            this.SidebarItemsPic.Image = ((System.Drawing.Image)(resources.GetObject("SidebarItemsPic.Image")));
            this.SidebarItemsPic.Location = new System.Drawing.Point(3, 3);
            this.SidebarItemsPic.Name = "SidebarItemsPic";
            this.SidebarItemsPic.Size = new System.Drawing.Size(33, 39);
            this.SidebarItemsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SidebarItemsPic.TabIndex = 0;
            this.SidebarItemsPic.TabStop = false;
            // 
            // FrmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 787);
            this.Controls.Add(this.ItemsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmItems";
            this.Text = "FrmItems";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidebarItemsPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.Label SidebarItems;
        private System.Windows.Forms.PictureBox SidebarItemsPic;
    }
}