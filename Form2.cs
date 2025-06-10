using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices; // Assuming you are using SQL Server for database operations
using static Class1; // Assuming you have a Class1 with necessary methods
using Microsoft.VisualBasic; // Assuming you are using SQL Server for database operations
namespace ID_Card_Inventory
{
    public partial class ItemsWindow : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["InventoryDB"].ConnectionString; // Replace with your actual connection string
        public ItemsWindow()
        {
            InitializeComponent();
            ConfigureControls.ConfigureDatagridview(OptionValuedataGridView);
            LoadValuesToDataGridView(0); // Assuming 0 is the default typeID, adjust as necessary
            LoadValuestoListBox();
            isButtonEnable(true); // Disable the AddValue button initially
        }

        private void ItemsWindow_Load(object sender, EventArgs e)
        {

        }
        private void LoadValuesToDataGridView(int typeID)
        {
            // This method is not implemented in the provided code snippet.
            // It seems to be a placeholder for future functionality.
            // You can implement it to load values into the DataGridView or perform some other logic.
            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                {
                    con.Open();




                    using SqlCommand cmd = new SqlCommand("ItemsLoadCombobox", con); // Adjust the query based on your database schema
                    {
                        cmd.CommandType = CommandType.StoredProcedure; // Assuming you are using a stored procedure

                        cmd.Parameters.AddWithValue("@TypeId", typeID);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter();
                        DataTable data = new DataTable();
                        dataAdapter.Fill(data);
                        OptionValuedataGridView.AutoGenerateColumns = true;


                        cmd.ExecuteNonQuery();
                        OptionValuedataGridView.DataSource = data;
                        OptionValuedataGridView.Columns["OptionID"].Visible = false;
                        OptionValuedataGridView.Columns["ComboTypeID"].Visible = false;

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form if an error occurs

            }
        }
        private void LoadValuestoListBox()
        {



            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("ComboTypeLoad", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try 
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        typeCombolistBox.DisplayMember = "ComboValues"; // What the user sees
                        typeCombolistBox.ValueMember = "OptionID";     // The ID you want to get
                        typeCombolistBox.DataSource = dt;
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("SQL Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close(); // Close the form if an error occurs
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close(); // Close the form if an error occurs
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form if an error occurs
            }
        }


        private void typeCombolistBox_Click(object sender, EventArgs e)
        {
            isButtonEnable(false); // Enable the AddValue button when a type is selected
            if (typeCombolistBox.SelectedValue != null)
            {
                int selectedId = Convert.ToInt32(typeCombolistBox.SelectedValue);
                LoadValuesToDataGridView(selectedId); // Load values based on the selected typeID
                typelabel.Text = typeCombolistBox.SelectedItem.ToString(); // Display the selected type in the label
            }
        }
        private void isButtonEnable(bool enable)
        {
            if (enable == true)
            {
                OptionValuedataGridView.ClearSelection();
                AddValuebutton.Hide();


            }
             


        }

        private void AddValuebutton_Click(object sender, EventArgs e)
        {
            var addrecord = Interaction.InputBox("Enter the value to add:", "Add Value", "", -1, -1);
            if (addrecord != null)
            {
                if (!string.IsNullOrWhiteSpace(addrecord))
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand("insertComboOption", con)) // Adjust the stored procedure name as needed
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@ComboValue", addrecord);
                                cmd.Parameters.AddWithValue("@CombotypeId", typeCombolistBox.SelectedValue); // Assuming you have a ComboTypeID parameter
                                cmd.ExecuteNonQuery();
                            }
                        }
                        LoadValuesToDataGridView(Convert.ToInt32(typeCombolistBox.SelectedValue)); // Reload the DataGridView
                        MessageBox.Show("Value added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while adding the value: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
