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
 using Microsoft.Data.SqlClient; // Assuming you are using SQL Server for database operations
using System.Configuration; // Assuming you are using SQL Server for database operations
  
namespace ID_Card_Inventory
{
    public partial class AddEmpForm : Form
    {
        private string connectionString =  ConfigurationManager.ConnectionStrings["InventoryDB"].ConnectionString; // Replace with your actual connection string
        public AddEmpForm()
        {
            InitializeComponent();
        }

        private void Add_Photo_Bttn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    IDpictureBox.Image = Image.FromFile(filePath);
                    IDpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    try
                    {
                        // Display the image
                        IDpictureBox.Image = Image.FromFile(filePath);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }

                }
            }
        }
        private ID_CardInventory_CLass isInputsValid()
        {
            // This method is not implemented in the provided code snippet.
            // It seems to be a placeholder for future functionality.
            // You can implement it to return an instance of ID_CardInventory_CLass or perform some other logic.

            string nameInput = NameTextBox.Text.Trim();
            string surnameInput = SurnameTextBox.Text.Trim();
            string idNumInput = IDNumTextBox.Text.Trim();
            string departmentInput = DeptMent_comboBox.SelectedValue?.ToString().Trim();
            string positionInput = PositionTextbox.Text.Trim();
            string dateOfIssueInput = dateOfIssue.Value.ToString("yyyy-MM-dd"); // Assuming dateOfIssue is a DateTimePicker
            if (string.IsNullOrEmpty(nameInput) || string.IsNullOrEmpty(surnameInput) || string.IsNullOrEmpty(idNumInput) ||
                string.IsNullOrEmpty(departmentInput) || string.IsNullOrEmpty(positionInput) || string.IsNullOrEmpty(dateOfIssueInput))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            // Create an instance of ID_CardInventory_CLass with the provided inputs
            ID_CardInventory_CLass idCard = new ID_CardInventory_CLass(nameInput, surnameInput, idNumInput, departmentInput, positionInput, dateOfIssueInput);


            return idCard;
        }

        private void Saved_button_Click(object sender, EventArgs e)
        {
            var idCard = isInputsValid();
            if (idCard != null)
            {                 // Assuming you have a method to save the ID_CardInventory_CLass instance
                string query = $"INSERT INTO EmployeeDetails (Name, Surname, ID_Number, Department, Position, Date_Of_Issue) " +
                               $"VALUES (@name,@surname,@idnumber,@department,@position, )";
                ExecuteSQLQuery(query);

                // SaveIDCard(idCard);
                MessageBox.Show("Employee details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after saving
            }
            else
            {
                MessageBox.Show("Failed to save employee details. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExecuteSQLQuery(string query)
        {
            // This method is not implemented in the provided code snippet.
            // It seems to be a placeholder for future functionality.
            // You can implement it to execute the SQL query against your database.
            // For example, you might use ADO.NET or Entity Framework to execute the query.
             
          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Add this namespace to resolve the SqlConnection type
                try
                {
                    // Add the following using directive at the top of the file to resolve the CS1069 error.
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing SQL query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }
    }
}
