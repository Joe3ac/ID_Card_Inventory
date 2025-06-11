using System.Configuration;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;
using System.Data;
using static Class1;

namespace ID_Card_Inventory
{
    public partial class Form1 : Form
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["InventoryDB"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            InitializeControls();
            ApplyLiveFilter(); // Load initial data
        }
        private void InitializeControls()
        {
            ConfigureControls.ConfigureDatagridview(iDdataGridView);
            ConfigureControls.selectItemstoCombobox(deptSearchcomboBox, 1); // Assuming 0 is the default typeID, adjust as necessary
        }

        private void AddEmployeebutton_Click(object sender, EventArgs e)
        {




        }
        private void getDataFromSql(string searchText, int? DeptID)
        {
            try
            {
                // Trim whitespace from the search text
                using SqlConnection sqlConnection = new SqlConnection(connectionString); // Ensure ConnectionString is defined in your project
                sqlConnection.Open();
                try
                {

                    using (SqlCommand sqlCommand = new SqlCommand("selectEmployeeInfo", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure; // Assuming you are using a stored procedure
                        sqlCommand.Parameters.AddWithValue("@DeptId", DeptID.Value); // Use DBNull.Value if no value is selected
                        sqlCommand.Parameters.AddWithValue("@NameSearch", string.IsNullOrEmpty(searchText) ? DBNull.Value : searchText); // Use Trim to remove any leading/trailing whitespace


                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        iDdataGridView.DataSource = dataTable; // Bind the DataTable to the DataGridView
                        //iDdataGridView.Columns["Id"].Visible = false; // Adjust column header text as needed
                    }


                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidOperationException invOpEx)
                {
                    MessageBox.Show($"Invalid Operation: {invOpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ApplyLiveFilter()
        {
            string searchText = NameSearch.Text.Trim(); // Trim whitespace from the search text
            int? deptId = deptSearchcomboBox.SelectedValue != null ? (int?)Convert.ToInt32(deptSearchcomboBox.SelectedValue) : null; // Get selected department ID or null if not selected
            getDataFromSql(searchText, deptId);
        }

        private void ItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemsWindow itemsWindow = new ItemsWindow();
            itemsWindow.Show();

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmpForm addEmpForm = new AddEmpForm();
            addEmpForm.ShowDialog();

        }

        private void NameSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyLiveFilter(); // Call the method to filter data based on the search text
        }

        private void deptSearchcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyLiveFilter(); // Call the method to filter data based on the selected department
        }

        private void deptSearchcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ApplyLiveFilter();
        }
    }
}
