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
        private void AddNewComboOption()
        {
            // Insert new data into ComboBoxOptions table
            

            // Notify all forms to reload their ComboBoxes
            ComboBoxEventHub.TriggerComboBoxDataChanged();
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
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable data = new DataTable();
                        dataAdapter.Fill(data);
                        OptionValuedataGridView.AutoGenerateColumns = true;
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
                        typeCombolistBox.DisplayMember = "ComboboxName"; // What the user sees
                        typeCombolistBox.ValueMember = "ComboTypeID";     // The ID you want to get
                        typeCombolistBox.DataSource = dt;
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("SQL Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Close the form if an error occurs
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Close the form if an error occurs
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Close the form if an error occurs
            }
        }
        private void typeCombolistBox_Click(object sender, EventArgs e)
        {
            isButtonEnable(false); // Enable the AddValue button when a type is selected
            if (typeCombolistBox.SelectedValue != null && int.TryParse(typeCombolistBox.SelectedValue.ToString(), out int typeID))
            {

                typeID = Convert.ToInt32(typeCombolistBox.SelectedValue);
                LoadValuesToDataGridView(typeID); // Load values based on the selected typeID
                string name = typeCombolistBox.Text; // This is the DisplayMember
                string id = typeCombolistBox.SelectedValue?.ToString(); // This is the ValueMember

                typelabel.Text = $"{id}:{name}";

            }
        }
        private void isButtonEnable(bool enable)
        {
            if (enable == true)
            {
                OptionValuedataGridView.ClearSelection();
                AddValuebutton.Hide();


            }
            if (enable == false)
            {
                AddValuebutton.Show();
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
                        AddNewComboOption(); // Call the method to add a new combo option
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

        private void OptionValuedataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Optional: Select the cell that was right-clicked
                OptionValuedataGridView.ClearSelection();
                OptionValuedataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                // Optional: Show a context menu (if you have one)
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int optionID = Convert.ToInt32(OptionValuedataGridView.SelectedRows[0].Cells["OptionID"].Value);
            if (MessageBox.Show("Are you sure you want to delete this value?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ExecuteDeleteQuery(optionID);

            }
        }
        private void ExecuteDeleteQuery(int optionID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteComboOption", con)) // Adjust the stored procedure name as needed
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@OptionId", optionID);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadValuesToDataGridView(Convert.ToInt32(typeCombolistBox.SelectedValue)); // Reload the DataGridView
                MessageBox.Show("Value deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddNewComboOption(); // Call the method to add a new combo option
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the value: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editBox = Interaction.InputBox("Enter the new value:", "Edit Value", OptionValuedataGridView.SelectedRows[0].Cells["ComboValues"].Value?.ToString(), -1, -1);
            AddNewComboOption();
        }
    }
}
