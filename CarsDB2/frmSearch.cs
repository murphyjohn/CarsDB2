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

namespace CarsDB2
{
    public partial class frmSearch : Form
    {
        String strConnect = @"Data Source=JOHN\SQLEXPRESS;Initial Catalog=Hire;Integrated Security=True;";
        DataSet dataSet = new DataSet();

        public frmSearch()
        {
            InitializeComponent();
            this.Text = "Task A Search - John Murphy - " + DateTime.Now.ToShortDateString();

            //populate cboField
            cboField.Items.Add("Make");
            cboField.Items.Add("EngineSize");
            cboField.Items.Add("RentalPerDay");
            cboField.Items.Add("Available");

            //populate cboOperator
            cboOperator.Items.Add(" = ");
            cboOperator.Items.Add(" > ");
            cboOperator.Items.Add(" >= ");
            cboOperator.Items.Add(" < ");
            cboOperator.Items.Add(" <= ");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            dataSet.Reset();
            string strField = cboField.SelectedItem.ToString();
            string strOperator = cboOperator.SelectedItem.ToString();
            string strValue = txtValue.Text.Trim();
            string strSearch = "" + strField + " " + strOperator + " " + "'"+strValue+"'";

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(strConnect))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM tblCar WHERE "+@strSearch;

                    SqlDataAdapter searchAdapter = new SqlDataAdapter(cmd);
                    searchAdapter.Fill(dataSet);
                    dgvSearchResults.DataSource = dataSet.Tables[0];
                    sqlConn.Close();

                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            

        }
    }
}
