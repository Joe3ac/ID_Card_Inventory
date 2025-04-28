using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID_Card_Inventory
{
    public partial class AddEmpForm : Form
    {
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

        private void Saved_button_Click(object sender, EventArgs e)
        {
            string nameInput = NameTextBox.Text;
            string surnameInput = SurnameTextBox.Text;
            string idNumInput = IDNumTextBox.Text;
            bool isNameValid = !string.IsNullOrWhiteSpace(nameInput);
            bool isSurnameValid = !string.IsNullOrWhiteSpace(surnameInput);
            bool isIDNumValid = !string.IsNullOrWhiteSpace(idNumInput);
            if (isNameValid && isSurnameValid && isIDNumValid)
            {
               //string EmP_Name = string.IsNullOrEmpty(nameInput);
                string.IsNullOrEmpty(surnameInput);
                string.IsNullOrEmpty(idNumInput);
                bool isSourceValid = !string.IsNullOrEmpty(sourceInput) && sourceInput != "-- Select --";
                // Check if all inputs are valid
                string departmentInput = DeptMent_comboBox.SelectedValue?.ToString().Trim();
                ID_CardInventory_CLass idCard = new ID_CardInventory_CLass(nameInput, surnameInput, idNumInput, departmentInput, positionInput, dateOfIssueInput);
                // Save the ID card information to a database or file here
                MessageBox.Show("Employee information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        
    }
}
