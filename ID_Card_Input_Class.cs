using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates; // Assuming you are using SQL Server for database operations
using Microsoft.Data.SqlClient; // Assuming you are using SQL Server for database operations
using System.Data;


public class Class1
{
	public string connectionString = ConfigurationManager.ConnectionStrings["InventoryDB"].ConnectionString; // Replace with your actual connection string
    public Class1()
	{
	}
	public void loadComboboxItems(ComboBox boxName) 
	{
		using SqlConnection con = new SqlConnection(connectionString);
		con.Open();
		string query = "SELECT DepartmentName FROM Departments"; // Adjust the query based on your database schema

    }
	public static class   ConfigureControls
	{
       static  string ConnectionString = ConfigurationManager.ConnectionStrings["InventoryDB"].ConnectionString; // Replace with your actual connection string

        public static void ConfigureDatagridview(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridView.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            dataGridView.RowHeadersVisible = true;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridView.RowPostPaint += (sender, e) => 
            {
                using (var brush = new System.Drawing.SolidBrush(dataGridView.RowHeadersDefaultCellStyle.ForeColor))
                {
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(), dataGridView.RowHeadersDefaultCellStyle.Font, brush, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
                }
            };


            // Add more columns as needed
        }
       public static void selectItemstoCombobox(ComboBox comboBox, int typeID)
        {
            // This method is not implemented in the provided code snippet.
            // It seems to be a placeholder for future functionality.
            // You can implement it to load values into the DataGridView or perform some other logic.
            try
            {
                using SqlConnection con = new SqlConnection(ConnectionString);
                {
                    con.Open();

                    using SqlCommand cmd = new SqlCommand("ItemsLoadCombobox", con); // Adjust the query based on your database schema
                    {
                        cmd.CommandType = CommandType.StoredProcedure; // Assuming you are using a stored procedure

                        cmd.Parameters.AddWithValue("@TypeId", typeID);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        comboBox.DisplayMember = "ComboValues";  // What user sees
                        comboBox.ValueMember = "OptionID";       // Internal value
                        comboBox.DataSource = dt;

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public static class ComboBoxDataProvider
    {
        public static DataTable ComboBoxData { get; private set; }

        // Declare the event
        public static event EventHandler DataChanged;

        public static void LoadData()
        {
            // Load or reload your data here
            ComboBoxData = new DataTable();
             ConfigureControls.selectItemstoCombobox(new ComboBox(), 1); // Assuming 1 is the typeID you want to use
            DataChanged?.Invoke(null, EventArgs.Empty);
        }
    }

}
