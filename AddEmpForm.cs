using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; // Assuming you are using SQL Server for database operations
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates; // Assuming you are using SQL Server for database operations
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ID_Card_Inventory.Properties; // Assuming you have a class named ConfigureControls with the method ConfigureDatagridview
 using Microsoft.Data.SqlClient; // Assuming you are using SQL Server for database operations
using static Class1.ConfigureControls;
using static Class1.ComboBoxEventHub;
namespace ID_Card_Inventory
{
    public partial class AddEmpForm : Form
    {
        public int employeeId { get; set; } // Assuming this is the ID of the employee being edited
        private string connectionString = ConfigurationManager.ConnectionStrings["InventoryDB"].ConnectionString; // Replace with your actual connection string
        public AddEmpForm()
        {
            InitializeComponent();
            OnComboBoxDataChanged += () =>
            {
                selectItemstoCombobox(DeptMent_comboBox, 1); // Assuming 1 is the typeID for departments
                selectItemstoCombobox(costCenter, 2); // Assuming 2 is the typeID for cost centers
                selectItemstoCombobox(EmploymentStatus_Combo, 3); // Assuming 3 is the typeID for employment statuses
            };
            // Subscribe to the event to load combobox items when the form is initialized
             //TriggerComboBoxDataChanged(); // Load combobox items when the form is initialized
            configureImageBox();
            LoadCombox(); // Load the combobox items when the form is initialized
        }
        private void LoadCombox()
        { 
           
           
            isButtonActive(true); // Enable the buttons when the form is initialized
        }
        private void configureImageBox()
        {
            // Configure the PictureBox to display images
            IDpictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust the size mode as needed
            IDpictureBox.BorderStyle = BorderStyle.FixedSingle; // Optional: Add a border to the PictureBox
            IDpictureBox.BackColor = Color.LightGray; // Optional: Set a background color for better visibility
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



            if (string.IsNullOrEmpty(NameTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(SurnameTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(IDNumTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(DeptMent_comboBox.SelectedValue?.ToString()) ||
                string.IsNullOrEmpty(PositionTextbox.Text.Trim()) ||
                string.IsNullOrEmpty(dateOfIssue.Value.ToString("yyyy-MM-dd")) ||
                string.IsNullOrEmpty(costCenter.SelectedValue?.ToString()) ||
                string.IsNullOrEmpty(EmploymentStatus_Combo.SelectedValue?.ToString()))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            if (!int.TryParse(DeptMent_comboBox.SelectedValue.ToString(), out int departmentId) ||
                !int.TryParse(costCenter.SelectedValue.ToString(), out int costcenter) ||
                !int.TryParse(EmploymentStatus_Combo.SelectedValue?.ToString(), out int EmplStat))
            {
                MessageBox.Show("Please select a valid department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            int isCondepartment = Convert.ToInt32(departmentId);
            int conCostCenter = Convert.ToInt32(costcenter);
            int isConEmplStat = Convert.ToInt32(EmplStat);
            string nameInput = NameTextBox.Text.Trim();
            string surnameInput = SurnameTextBox.Text.Trim();
            string idNumInput = IDNumTextBox.Text.Trim();
            string positionInput = PositionTextbox.Text.Trim();

            Image image = IDpictureBox.Image; // Assuming you want to store the photo as an Image object
            if (image == null)
            {
                  image = Resources.icons8_no_image_50; // Use a default image if no photo is provided
                IDpictureBox.Image = image; // Set the default image in the PictureBox

            }
            string dateOfIssueInput = dateOfIssue.Value.ToString("yyyy-MM-dd"); // Assuming dateOfIssue is a DateTimePicker
            // Create an instance of ID_CardInventory_CLass with the provided inputs
            ID_CardInventory_CLass idCard = new ID_CardInventory_CLass(nameInput, surnameInput, idNumInput, departmentId, positionInput, dateOfIssueInput, image, costcenter, EmplStat);


            return idCard;
        }

        private void Saved_button_Click(object sender, EventArgs e)
        {
            var idCard = isInputsValid();
            if (idCard != null)
            {                 // Assuming you have a method to save the ID_CardInventory_CLass instance

                ExecuteSQLQuery("AddDetails");

                // SaveIDCard(idCard);
                MessageBox.Show("Employee details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after saving
                //Form1 mainForm = (Form1)this.Owner; // Assuming this form is opened from Form1
                //mainForm.loadData(); // Refresh the DataGridView in Form1 after saving
            }
            else
            {
                MessageBox.Show("Failed to save employee details. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExecuteSQLQuery(string Procedure)
        {
            // This method is not implemented in the provided code snippet.
            // It seems to be a placeholder for future functionality.
            // You can implement it to execute the SQL query against your database.
            // For example, you might use ADO.NET or Entity Framework to execute the query.

            var idCard = isInputsValid();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Add this namespace to resolve the SqlConnection type
                try
                {
                    // Add the following using directive at the top of the file to resolve the CS1069 error.
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(Procedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure; // Assuming you are using a stored procedure
                        command.Parameters.AddWithValue("@FName", idCard.Name);
                        command.Parameters.AddWithValue("@SName", idCard.Surnmae);
                        command.Parameters.AddWithValue("@EmployeeNum", idCard.ID_Number);
                        command.Parameters.AddWithValue("@DepartmentID", idCard.Department);
                        command.Parameters.AddWithValue("@Position", idCard.Position);
                        command.Parameters.AddWithValue("@dateofissue", idCard.Date_Of_Issue); // Assuming dateOfIssue is a DateTimePicker
                        command.Parameters.AddWithValue("@costCenter", idCard.costCenter); // Assuming costCenter is an integer
                        command.Parameters.AddWithValue("@EmploymentstatusID", idCard.employementStatus); // Assuming employementStatus is an integer
                        if (Procedure=="EditDetails")
                        {
                            command.Parameters.AddWithValue("@ID",employeeId); // Assuming ID_Number is the unique identifier for the employee
                        }


                        if (IDpictureBox.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                using (Bitmap bmp = new Bitmap(IDpictureBox.Image))
                                {
                                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                }

                                byte[] imageBytes = ms.ToArray();
                                command.Parameters.AddWithValue("@IDPhoto", imageBytes);
                            }
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@IDPhoto", DBNull.Value);
                        }
                         
                        command.ExecuteNonQuery(); // Execute the query

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing SQL query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private void ClearFormFields()
        {
            // This method is not implemented in the provided code snippet.
            // It seems to be a placeholder for future functionality.
            // You can implement it to clear the form fields after saving or editing employee details.
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            IDNumTextBox.Clear();
            DeptMent_comboBox.SelectedIndex = -1; // Clear the selected item in the combobox
            PositionTextbox.Clear();
            dateOfIssue.Value = DateTime.Now; // Reset to current date
            costCenter.SelectedIndex = -1; // Clear the selected item in the combobox
            EmploymentStatus_Combo.SelectedIndex = -1; // Clear the selected item in the combobox
            IDpictureBox.Image = null; // Clear the image
        }
        public void PopulateFormWithSelectedEmployee(DataGridViewRow dRow)
        {
             
            // This method is not implemented in the provided code snippet.
            // It seems to be a placeholder for future functionality.
            // You can implement it to populate the form with the selected employee's details.
            ClearFormFields();
            isButtonActive(false);
            if ( dRow != null)
            {
                try
                {
                    employeeId = Convert.ToInt32(dRow.Cells["Id"].Value);
                    NameTextBox.Text = dRow.Cells["First Name"].Value.ToString();
                    SurnameTextBox.Text = dRow.Cells["Surname"].Value.ToString();
                    IDNumTextBox.Text = dRow.Cells["Employee Number"].Value.ToString();
                    DeptMent_comboBox.SelectedValue = Convert.ToInt32(dRow.Cells["DepartmentID"].Value);
                    PositionTextbox.Text = dRow.Cells["Position"].Value.ToString();
                    dateOfIssue.Value = Convert.ToDateTime(dRow.Cells["Date Of Issue"].Value);
                    costCenter.SelectedValue = Convert.ToInt32(dRow.Cells["CostCenter"].Value);
                    EmploymentStatus_Combo.SelectedValue = Convert.ToInt32(dRow.Cells["EmploymentStatusID"].Value);
                    // Assuming you have a method to load the image from a byte array
                    if (dRow.Cells["ID Photo"].Value != DBNull.Value)
                    {
                        try
                        {
                            byte[] imageBytes = (byte[])dRow.Cells["ID Photo"].Value;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                IDpictureBox.Image = Image.FromStream(ms);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            IDpictureBox.Image = Properties.Resources.icons8_no_image_50; // Use a default image if loading fails
                        }
                    }
                    else
                    {
                        Image defaultImage = Properties.Resources.icons8_no_image_50; // Use a default image if no photo is provided
                        IDpictureBox.Image = defaultImage; // Handle case where no photo is provided
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error populating form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void isButtonActive(bool isActive)
        {
            // This method is not implemented in the provided code snippet.
            // It seems to be a placeholder for future functionality.
            // You can implement it to enable or disable buttons based on the isActive parameter.
            Saved_button.Enabled = isActive;
            //Add_Photo_Bttn.Enabled = isActive;
            isEditbutton.Enabled = !isActive;

        }

        private void isEditbutton_Click(object sender, EventArgs e)
        {
            var isValidForUpdate = isInputsValid();
            if (isValidForUpdate != null)
            {
                ExecuteSQLQuery("EditDetails");
                MessageBox.Show("Employee details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Failed to update employee details. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
