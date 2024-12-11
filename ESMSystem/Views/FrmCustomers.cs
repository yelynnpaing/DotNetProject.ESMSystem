using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESMSystem.Views
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        SqlConnection consql;
        string str;
        DataSet Dset;

        private void Connection()
        {
            string str = "Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=ElectronicsDb;" +
                "Persist Security Info=True;User ID=sa;Password=sasa@123";
            consql = new SqlConnection(str);
            consql.Open();
        }

        private void Clear()
        {
            txtCusID.Text = "";
            txtCusName.Text = "";
            cboGender.Text = "";
            txtCusPhone.Text = "";
            txtCusID.Focus();
        }

        private void FillGender()
        {
            string query = "SELECT Id, GenderType FROM TblGenders";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dataSet = new DataSet();
            DataTable dt = new DataTable();
            adapter.Fill(dataSet, "genders");
            dt = dataSet.Tables["genders"];
            cboGender.DataSource = dt;

            cboGender.DisplayMember = dt.Columns["GenderType"].ToString();
            cboGender.ValueMember = dt.Columns["Id"].ToString();
        }

        private void AutoId()
        {
            string CName;
            int CID;
            string query = "SELECT CustomerId FROM TblCustomers ORDER BY CustomerId";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "customers");

            if (ds.Tables["customers"].Rows.Count > 0)
            {
                CName = ds.Tables["customers"].Rows[ds.Tables["customers"].Rows.Count - 1][0].ToString();
                CID = int.Parse(CName.Substring(1, (CName.Length - 1)));
                txtCusID.Text = "C" + (CID + 1).ToString("0000");
            }
            else
            {
                txtCusID.Text = "C0001";
            }
        }

        private void FillData()
        {
            string query = "SELECT CustomerId, CustomerName, TblGenders.GenderType, CustomerPhone FROM TblCustomers " +
                "INNER JOIN TblGenders ON TblCustomers.GenderId = TblGenders.Id";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            Dset = new DataSet();
            adapter.Fill(Dset, "customers");

            dgCustomerList.DataSource = Dset.Tables["customers"];
            dgCustomerList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            Connection();
            Clear();
            FillGender();
            FillData();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            Clear();
            AutoId();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO TblCustomers VALUES ('" + txtCusID.Text + "', '" + txtCusName.Text + "', " +
                "'" + cboGender.SelectedValue + "', '" + txtCusPhone.Text + "')";
                SqlCommand cmd = new SqlCommand(query, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Customer create is success.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                FillData();
            }
            catch
            {
                MessageBox.Show("Something wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgCustomerList_Click(object sender, EventArgs e)
        {
            int i;
            i = dgCustomerList.CurrentRow.Index;
            txtCusID.Text = Dset.Tables["customers"].Rows[i][0].ToString();
            txtCusName.Text = Dset.Tables["customers"].Rows[i][1].ToString();
            cboGender.Text = Dset.Tables["customers"].Rows[i][2].ToString();
            txtCusPhone.Text = Dset.Tables["customers"].Rows[i][3].ToString();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE TblCustomers SET CustomerName='" + txtCusName.Text + "'," +
                " GenderId = '" + cboGender.SelectedValue + "', CustomerPhone = '" + txtCusPhone.Text + "' " +
                "WHERE CustomerId = '" + txtCusID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer update is success.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                FillData();
            }
            catch
            {
                MessageBox.Show("Something wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM TblCustomers WHERE CustomerId = '" + txtCusID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer delete is success.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                FillData();
            }
            catch
            {
                MessageBox.Show("Something wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
