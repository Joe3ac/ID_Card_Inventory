namespace ID_Card_Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddEmployeebutton_Click(object sender, EventArgs e)
        {
            AddEmpForm addForm = new AddEmpForm();
            addForm.Show();



        }
    }
}
