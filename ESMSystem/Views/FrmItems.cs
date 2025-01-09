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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ESMSystem.Views
{
    public partial class FrmItems : Form
    {
        public FrmItems()
        {
            InitializeComponent();
        }

        SqlConnection consql;
        string str;
        DataSet Dset;

        void Connection()
        {
            string str = "Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=ElectronicInventoryManagementSystemDb;Persist Security Info=True;User ID=sa;Password=sasa@123";
            consql = new SqlConnection(str);
            consql.Open();
        }

        private void Clear()
        {
            txtItemId.Text = "";
            txtItemName.Text = "";
            cboCategory.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            txtManufacturer.Text = "";
            txtItemName.Focus();
        }

        private void FillCategoryName()
        {
            string query = "SELECT CategoryId, CategoryName FROM TblCategories";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataSet, "categories");
            dataTable = dataSet.Tables["categories"];
            cboCategory.DataSource = dataTable;
            cboCategory.DisplayMember = dataTable.Columns["CategoryName"].ToString();
            cboCategory.ValueMember = dataTable.Columns["CategoryId"].ToString();
        }

        private void AutoId()
        {
            string IName;
            int IID;
            string query = "SELECT ItemId FROM TblItems ORDER BY ItemId";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "items");

            if (ds.Tables["items"].Rows.Count > 0)
            {
                IName = ds.Tables["items"].Rows[ds.Tables["items"].Rows.Count - 1][0].ToString();
                IID = int.Parse(IName.Substring(1, (IName.Length - 1)));
                txtItemId.Text = "S" + ((IID + 1).ToString("0000"));
            }
            else
            {
                txtItemId.Text = "S0001";
            }
        }

        private void FillData()
        {
            string query = "SELECT ItemId, ItemName, TblCategories.CategoryName, ItemPrice, ItemStock, ItemManufacturer " +
                "FROM TblItems INNER JOIN TblCategories ON TblItems.CategoryId = TblCategories.CategoryId;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            Dset = new DataSet();
            adapter.Fill(Dset, "items");

            dgItemList.DataSource = Dset.Tables["items"];
            dgItemList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
        }

        private void FrmItems_Load(object sender, EventArgs e)
        {
            Connection();
            Clear();
            FillCategoryName();
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
                string query = "INSERT INTO TblItems VALUES" +
                        "('" + txtItemId.Text + "', '" + txtItemName.Text + "', '" + cboCategory.SelectedValue + "'," +
                        "'" + int.Parse(txtPrice.Text) + "', '" + int.Parse(txtStock.Text) + "', '" + txtManufacturer.Text + "')";
                SqlCommand cmd = new SqlCommand(query, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Save new item is successful.", "Informartion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                FillData();
            }
            catch
            {
                MessageBox.Show("Something wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgItemList_Click(object sender, EventArgs e)
        {
            int i;
            i = dgItemList.CurrentRow.Index;
            txtItemId.Text = Dset.Tables["items"].Rows[i][0].ToString();
            txtItemName.Text = Dset.Tables["items"].Rows[i][1].ToString();
            cboCategory.Text = Dset.Tables["items"].Rows[i][2].ToString();
            txtPrice.Text = Dset.Tables["items"].Rows[i][3].ToString();
            txtStock.Text = Dset.Tables["items"].Rows[i][4].ToString();
            txtManufacturer.Text = Dset.Tables["items"].Rows[i][5].ToString();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE TblItems SET ItemName = '" + txtItemName.Text + "', CategoryId = '" + cboCategory.SelectedValue + "', " +
                "ItemPrice = '" + txtPrice.Text + "', ItemStock = '" + txtStock.Text + "', ItemManufacturer = '" + txtManufacturer.Text + "'" +
                "WHERE ItemId = '" + txtItemId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update item is successful.", "Informartion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                FillData();
            }
            catch
            {
                MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM TblItems WHERE ItemId = '" + txtItemId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleting item is successfull.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                FillData();
            }
            catch
            {
                MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
