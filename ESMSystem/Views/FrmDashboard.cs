using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESMSystem.Views
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadForm(object form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void pboxLogo_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmDashboard());
        }

        private void LogoLabel_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmDashboard());
        }

        private void SidebarItemsPic_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmItems());
        }

        private void SidebarItems_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmItems());
        }

        private void SidebarCategoriesPic_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmCategories());
        }

        private void SidebarCategories_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmCategories());
        }

        private void LogoutPicture_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void SidebarCustomerPic_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmCustomers());
        }

        private void SidebarCustomer_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmCustomers());
        }

        private void SidebarBillingPic_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmBilling());
        }

        private void SidebarBilling_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmBilling());
        }
    }
}
