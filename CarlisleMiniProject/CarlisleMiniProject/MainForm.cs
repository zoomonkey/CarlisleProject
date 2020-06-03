using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        string dbconn = CarlisleMiniProject.Properties.Settings.Default.MyDBConnectionString;

        public MainForm()
        {
            InitializeComponent();
           
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshGridFromDB();
            EnableFields(false);
        }

        #region Form Helpers
        private void FormatControls()
        {
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["GrossSalesAmount"].DefaultCellStyle.Format = "c";
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            dtpReqShipDate.CustomFormat = "yyyyMMdd";
        }
        private void EnableFields(bool istrue)
        {
            dtpReqShipDate.Enabled = istrue;
            txtQuantity.Enabled = istrue;
            ddlFreightTerms.Enabled = istrue;
            ddlOrderStatus.Enabled = istrue;
            btnSaveRefresh.Enabled = istrue;
        }
        private void ClearFields()
        {
            dtpReqShipDate.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            ddlOrderStatus.SelectedIndex = 0;
            ddlFreightTerms.SelectedIndex = 0;
            lblOrderNumber.Text = string.Empty;
        }
        private bool IsFormValid()
        {
            bool isValid = true;
            string ordernumber = dataGridView1.SelectedRows[0].Cells["OrderNumber"].Value.ToString();
            string orderStatus = dataGridView1.SelectedRows[0].Cells["OrderStatus"].Value.ToString();
            string requestedShipDate = dtpReqShipDate.Text;
            string qty = txtQuantity.Text;
            string freightTerms = ddlFreightTerms.Text;

            if (!orderStatus.Equals("open", StringComparison.InvariantCultureIgnoreCase))
            {
                MessageBox.Show("You can only save open orders.");
                return false;
            }
            if (ddlOrderStatus.Text.Trim().Length == 0)
            {
                MessageBox.Show("You must pick a valid Order Status.");
                return false;
            }
            if (ordernumber.Trim().Length == 0)
            {
                MessageBox.Show("Invalid Order Number");
                return false;
            }
            if (requestedShipDate.Trim().Length != 8)
            {
                MessageBox.Show("Invalid Requested Ship Date");
                return false;
            }
            if (qty.Trim().Length == 0)
            {
                MessageBox.Show("Invalid Quantity");
                return false;
            }
            if (freightTerms.Trim().Length == 0)
            {
                MessageBox.Show("Invalid Freight Terms");
                return false;
            }

            return isValid;
        }
        #endregion

        #region User Events
        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            RefreshGridFromDB();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string orderStatus = dataGridView1.Rows[e.RowIndex].Cells["OrderStatus"].Value.ToString();

                if (orderStatus.Equals("open", StringComparison.InvariantCultureIgnoreCase))
                {
                    var newDate = DateTime.ParseExact(dataGridView1.Rows[e.RowIndex].Cells["RequestedShipDate"].Value.ToString(),
                                  "yyyyMMdd",
                                   CultureInfo.InvariantCulture);

                    dtpReqShipDate.Value = newDate;
                    txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                    ddlFreightTerms.Text = dataGridView1.Rows[e.RowIndex].Cells["FreightTerms"].Value.ToString();
                    ddlOrderStatus.Text = orderStatus;
                    lblOrderNumber.Text = dataGridView1.Rows[e.RowIndex].Cells["OrderNumber"].Value.ToString();
                    EnableFields(true);
                }
                else
                {
                    ClearFields();
                    EnableFields(false);
                }
                //do work
            }
            else
            {
                EnableFields(false);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtQuantity.Text = txtQuantity.Text.Remove(txtQuantity.Text.Length - 1);
            }
        }

        private void btnSaveRefresh_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void cbOpenOrdersOnly_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGridFromDB();
            EnableFields(false);
        }
        #endregion
        
        #region Data Drivers
        private void LoadDataGrid()
        {
            string x = dtpReqShipDate.Text;
            try
            {
                if (IsFormValid())
                {
                    string ordernumber = dataGridView1.SelectedRows[0].Cells["OrderNumber"].Value.ToString();
                    string requestedShipDate = dtpReqShipDate.Text;
                    string qty = txtQuantity.Text;
                    string freightTerms = ddlFreightTerms.Text;
                    string orderStatus = ddlOrderStatus.Text;

                    using (var conn = new SqlConnection(dbconn))
                    {
                        conn.Open();
                        var cmd = new SqlCommand("UpdateOrderDetail", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@OrderNumber", ordernumber));
                        cmd.Parameters.Add(new SqlParameter("@RequestedShipDate", requestedShipDate));
                        cmd.Parameters.Add(new SqlParameter("@Quantity", qty));
                        cmd.Parameters.Add(new SqlParameter("@OrderStatus", orderStatus));
                        cmd.Parameters.Add(new SqlParameter("@FreightTerms", freightTerms));

                        cmd.ExecuteNonQuery();
                    }
                    RefreshGridFromDB();
                    EnableFields(false);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (ordernumber.Trim().Equals(row.Cells["OrderNumber"].Value))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void RefreshGridFromDB()
        {
            var dt = new DataTable();

            using (var myConn = new SqlConnection(dbconn))
            {
                myConn.Open();
                var myCmd = new SqlCommand("MainSelect", myConn);
                myCmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(myCmd);

                da.Fill(dt);
                
                var dv = new DataView(dt);

                

                dataGridView1.DataSource = dv;

                // this really shouldn't be here it violates the single responsibility model and puts logic in here
                if (cbOpenOrdersOnly.Checked)
                {
                    dv.RowFilter = "OrderStatus = 'Open'"; // query example = "id = 10"
                    dataGridView1.ClearSelection(); // we want the user to pick something after this
                }
            }
            FormatControls();
            ClearFields();
        }
        #endregion
    }
}
