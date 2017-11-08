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
    public partial class frmCars : Form
    {
        DataSet dataSet = new DataSet();
        int currentRow = 0;
        String strConnect = @"Data Source=JOHN\SQLEXPRESS;Initial Catalog=Hire;Integrated Security=True;";

        public frmCars()
        {
            InitializeComponent();
            this.Text = "John Murphy - Task A - " + DateTime.Now.ToShortDateString();
        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(strConnect))
                {
                    if(sqlConnection.State== ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "select * from tblCar";
                    sqlCommand.Connection = sqlConnection;
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dataSet);

                    if(dataSet.Tables[0].Rows.Count > 0)
                    {
                        displayThisRow();
                    }
                    else
                    {
                        MessageBox.Show("There are no records in the database.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayThisRow()
        {
            txtVehicleRegNo.Text = Convert.ToString(dataSet.Tables[0].Rows[currentRow]["VehicleRegNo"]);
            txtMake.Text = Convert.ToString(dataSet.Tables[0].Rows[currentRow]["Make"]);
            txtEngineSize.Text = Convert.ToString(dataSet.Tables[0].Rows[currentRow]["EngineSize"]);
            txtDateRegistered.Text = Convert.ToDateTime(dataSet.Tables[0].Rows[currentRow]["DateRegistered"]).ToString("dd-MM-yyyy");
            txtRentalPerDay.Text = "€"+ Convert.ToString(dataSet.Tables[0].Rows[currentRow]["RentalPerDay"]);
            chkAvailable.Checked = Convert.ToBoolean(dataSet.Tables[0].Rows[currentRow]["Available"]);
            checkRecordCount();
        }

        private void checkRecordCount()
        {
            if (currentRow == 0)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            else if(currentRow >= (dataSet.Tables[0].Rows.Count - 1))
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            txtRecordCount.Text = "" + (currentRow + 1) + " of " + (dataSet.Tables[0].Rows.Count);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection sqlConnect=new SqlConnection(strConnect))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = sqlConnect;
                    command.CommandText = "UPDATE tblCar SET VehicleRegNo = @VehicleRegNo, Make = @Make, EngineSize = @EngineSize," +
                        "DateRegistered=@DateRegistered,RentalPerDay=@RentalPerDay,Available=@Available " +
                        "WHERE VehicleRegNo = @OldVehicleRegNo";
                    command.Parameters.AddWithValue("@VehicleRegNo", SqlDbType.NVarChar).Value = txtVehicleRegNo.Text.Trim();
                    command.Parameters.AddWithValue("@Make", SqlDbType.NVarChar).Value = txtMake.Text.Trim();
                    command.Parameters.AddWithValue("@EngineSize", SqlDbType.NVarChar).Value = txtEngineSize.Text.Trim();
                    command.Parameters.AddWithValue("@DateRegistered", SqlDbType.Date).Value = Convert.ToDateTime(txtDateRegistered.Text);
                    command.Parameters.AddWithValue("@RentalPerDay", SqlDbType.SmallMoney).Value = txtRentalPerDay.Text.Trim();
                    command.Parameters.AddWithValue("@Available", SqlDbType.Bit).Value = chkAvailable.Checked;

                    command.Parameters.AddWithValue("@OldVehicleRegNo", SqlDbType.NVarChar).Value = 
                        Convert.ToString(dataSet.Tables[0].Rows[currentRow]["VehicleRegNo"]);

                    sqlConnect.Open();
                    command.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("Vehicle Details Updated in Database.");
                }
                dataSet.Reset();
                frmCars_Load(null, null);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection sqlConnect = new SqlConnection(strConnect))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = sqlConnect;
                    command.CommandText = "INSERT INTO tblCar (VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available) " +
                        "VALUES (@VehicleRegNo, @Make, @EngineSize, @DateRegistered, @RentalPerDay, @Available)";

                    command.Parameters.AddWithValue("@VehicleRegNo", txtVehicleRegNo.Text.Trim());
                    command.Parameters.AddWithValue("@Make", txtMake.Text.Trim());
                    command.Parameters.AddWithValue("@EngineSize", txtMake.Text.Trim());
                    command.Parameters.AddWithValue("@DateRegistered", Convert.ToDateTime(txtDateRegistered.Text));
                    command.Parameters.AddWithValue("@RentalPerDay", txtRentalPerDay.Text.Trim());
                    command.Parameters.AddWithValue("@Available", chkAvailable.Checked);

                    sqlConnect.Open();
                    command.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("New Vehicle Record Added to Database");
                }
                dataSet.Reset();
                frmCars_Load(null, null);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult warningDR = MessageBox.Show(null, "Are you sure you want to delete this record?", "WARNING!", MessageBoxButtons.YesNo);
            if (warningDR == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection sqlConnect = new SqlConnection(strConnect))
                    {
                        SqlCommand command = new SqlCommand();
                        command.Connection = sqlConnect;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "DELETE from tblCar WHERE VehicleRegNo = @VehicleRegNo";
                        command.Parameters.AddWithValue("@VehicleRegNo", txtVehicleRegNo.Text.Trim());

                        sqlConnect.Open();
                        command.ExecuteNonQuery();
                        sqlConnect.Close();
                    }
                    dataSet.Reset();
                    frmCars_Load(null, null);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch();
            search.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes cancelled");
            dataSet.Reset();
            frmCars_Load(null,null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentRow = 0;
            displayThisRow();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentRow--;
            displayThisRow();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentRow++;
            displayThisRow();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentRow = (dataSet.Tables[0].Rows.Count) - 1;
            displayThisRow();
        }
    }
}
