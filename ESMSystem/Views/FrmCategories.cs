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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        SqlConnection consql;
        string str;
        DataSet DSet;

        void Connection()
        {
            str = "Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=ElectronicsDb;Persist Security Info=True;User ID=sa;Password=sasa@123";
            consql = new SqlConnection(str);
            consql.Open();
        }

        private void AutoID()
        {
            string CatName;
            int CatId;
            string query = "SELECT CategoryId FROM TblCategories ORDER BY CategoryId";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "categories");
            if (ds.Tables["categories"].Rows.Count > 0)
            {
                CatName = ds.Tables["categories"].Rows[ds.Tables["categories"].Rows.Count - 1][0].ToString();
                CatId = int.Parse(CatName.Substring(1, (CatName.Length - 1)));
                txtCategoryId.Text = "C" + ((CatId + 1).ToString("000"));
            }
            else
            {
                txtCategoryId.Text = "C001";
            }
        }

        private void FillData()
        {
            string query = "SELECT CategoryId, CategoryName FROM TblCategories";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DSet = new DataSet();
            adapter.Fill(DSet, "categories");
            dgCategoryList.DataSource = DSet.Tables["categories"];

            dgCategoryList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dgCategoryList.Columns[0].HeaderText = "Category ID";
            dgCategoryList.Columns[1].HeaderText = "Category Name";
        }

        private void Clear()
        {
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            Connection();
            FillData();
            Clear();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            txtCategoryName.Clear();
            AutoID();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "INSERT INTO TblCategories Values ('" + txtCategoryId.Text + "' ,'" + txtCategoryName.Text + "')";
                SqlCommand cmd = new SqlCommand(strInsert, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Creating Category is Successfull.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCategoryId.Text = "";
                txtCategoryName.Text = "";
                FillData();
            }
            catch
            {
                MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "UPDATE TblCategories SET CategoryName = '" + txtCategoryName.Text + "' WHERE CategoryId = '" + txtCategoryId.Text + "'";
                SqlCommand cmd = new SqlCommand(str, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updating Category is Successfull.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData();
                Clear();
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
                string str = "DELETE FROM TblCategories WHERE CategoryId = '" + txtCategoryId.Text + "' ";
                SqlCommand cmd = new SqlCommand(str, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleting Category is Successfull.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData();
                Clear();
            }
            catch
            {
                MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgCategoryList_Click(object sender, EventArgs e)
        {
            int i;
            i = dgCategoryList.CurrentRow.Index;
            txtCategoryId.Text = DSet.Tables[0].Rows[i][0].ToString();
            txtCategoryName.Text = DSet.Tables[0].Rows[i][1].ToString();
        }
    }
}
