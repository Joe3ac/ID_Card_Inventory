using System.Configuration;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Office.Interop.Publisher;
using Microsoft.VisualBasic;
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
            //loadData(); // Load initial data into the DataGridView
            // Load initial data with empty search text and no department selected    
            ApplyLiveFilter(); // Load initial data
            configureImageBox(); // Configure the PictureBox for displaying images
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

                    using (SqlCommand sqlCommand = new SqlCommand("selectEmployeeInfoDetails", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure; // Assuming you are using a stored procedure
                        sqlCommand.Parameters.AddWithValue("@DeptId", (object?)DeptID ?? DBNull.Value); // Use DBNull.Value if no value is selected
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
        private void loadData()
        {
            try
            {
                // Trim whitespace from the search text
                using SqlConnection sqlConnection = new SqlConnection(connectionString); // Ensure ConnectionString is defined in your project
                sqlConnection.Open();
                try
                {

                    using (SqlCommand Command = new SqlCommand("LoadInfotoView", sqlConnection))
                    {
                        Command.CommandType = CommandType.StoredProcedure; // Assuming you are using a stored procedure


                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Command);

                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        iDdataGridView.AutoGenerateColumns = true; // Disable auto-generation of columns
                        iDdataGridView.DataSource = dataTable; // Bind the DataTable to the DataGridView
                        iDdataGridView.Columns["Id"].Visible = false;                                       //iDdataGridView.Columns["Id"].Visible = false; // Adjust column header text as needed
                        iDdataGridView.Columns["ID Photo"].Visible = false;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void ClearFilterbutton_Click(object sender, EventArgs e)
        {
            loadData(); // Reload the data without any filters
        }

        private void iDdataGridView_Click(object sender, EventArgs e)
        {
            // Handle the click event for the DataGridView if needed
            // For example, you can show details of the selected employee or perform other actions
            if (iDdataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = iDdataGridView.SelectedRows[0];
                var idCardImage = selectedRow.Cells["ID Photo"].Value as byte[]; // Assuming "ID Photo" is the column name for the image
                if (idCardImage != null && idCardImage.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(idCardImage))
                    {
                        idPicBox.Image = Image.FromStream(ms); // Display the image in the PictureBox
                    }
                }
                else
                {
                    idPicBox.Image = null; // Clear the PictureBox if no image is available
                }
                // You can access the data in the selected row here
            }

        }

        private void iDdataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Optional: Select the cell that was right-clicked
                iDdataGridView.ClearSelection();
                iDdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                // Optional: Show a context menu (if you have one)
                contextMenuStrip1.Show(Cursor.Position);
            }


        }
        private void configureImageBox()
        {
            // Configure the PictureBox to display images
            idPicBox.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust the size mode as needed
            idPicBox.BorderStyle = BorderStyle.FixedSingle; // Optional: Add a border to the PictureBox
            idPicBox.BackColor = Color.LightGray; // Optional: Set a background color for better visibility
        }
        private void interactionBoxViewConfigure(Interaction interactionBox)
        {

        }

        private void printStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
         

    

 }
}
