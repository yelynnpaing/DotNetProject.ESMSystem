namespace ESMSystem.Views
{
    partial class FrmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategories));
            this.CategoriesPanel = new System.Windows.Forms.Panel();
            this.SidebarCategories = new System.Windows.Forms.Label();
            this.SidebarCategoriesPic = new System.Windows.Forms.PictureBox();
            this.CategoriesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidebarCategoriesPic)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriesPanel
            // 
            this.CategoriesPanel.Controls.Add(this.SidebarCategories);
            this.CategoriesPanel.Controls.Add(this.SidebarCategoriesPic);
            this.CategoriesPanel.Location = new System.Drawing.Point(718, 299);
            this.CategoriesPanel.Name = "CategoriesPanel";
            this.CategoriesPanel.Size = new System.Drawing.Size(218, 46);
            this.CategoriesPanel.TabIndex = 5;
            // 
            // SidebarCategories
            // 
            this.SidebarCategories.AutoSize = true;
            this.SidebarCategories.Location = new System.Drawing.Point(42, 12);
            this.SidebarCategories.Name = "SidebarCategories";
            this.SidebarCategories.Size = new System.Drawing.Size(94, 16);
            this.SidebarCategories.TabIndex = 3;
            this.SidebarCategories.Text = "CATEGORIES";
            // 
            // SidebarCategoriesPic
            // 
            this.SidebarCategoriesPic.Image = ((System.Drawing.Image)(resources.GetObject("SidebarCategoriesPic.Image")));
            this.SidebarCategoriesPic.Location = new System.Drawing.Point(3, 3);
            this.SidebarCategoriesPic.Name = "SidebarCategoriesPic";
            this.SidebarCategoriesPic.Size = new System.Drawing.Size(33, 39);
            this.SidebarCategoriesPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SidebarCategoriesPic.TabIndex = 0;
            this.SidebarCategoriesPic.TabStop = false;
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 834);
            this.Controls.Add(this.CategoriesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategories";
            this.Text = "FrmCategories";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.CategoriesPanel.ResumeLayout(false);
            this.CategoriesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidebarCategoriesPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CategoriesPanel;
        private System.Windows.Forms.Label SidebarCategories;
        private System.Windows.Forms.PictureBox SidebarCategoriesPic;
    }
}