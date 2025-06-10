using System.Runtime.CompilerServices;
using static Class1;

namespace ID_Card_Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeControls();
        }
        private void InitializeControls()
        {
             ConfigureControls.ConfigureDatagridview(iDdataGridView);
        }

        private void AddEmployeebutton_Click(object sender, EventArgs e)
        {
            



        }

        private void ItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemsWindow itemsWindow = new ItemsWindow();
            itemsWindow.Show();
            
        }
    }
}
