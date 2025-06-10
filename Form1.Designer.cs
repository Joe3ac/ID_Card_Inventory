namespace ID_Card_Inventory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            iDdataGridView = new DataGridView();
            label1 = new Label();
            AddEmployeebutton = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            deptSearchcomboBox = new ComboBox();
            label2 = new Label();
            NameSearch = new RichTextBox();
            InvetoryMenu = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            ItemsToolStripMenuItem = new ToolStripMenuItem();
            addEmployeeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)iDdataGridView).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            InvetoryMenu.SuspendLayout();
            SuspendLayout();
            // 
            // iDdataGridView
            // 
            iDdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iDdataGridView.Location = new Point(37, 293);
            iDdataGridView.Margin = new Padding(5, 6, 5, 6);
            iDdataGridView.Name = "iDdataGridView";
            iDdataGridView.RowHeadersWidth = 72;
            iDdataGridView.Size = new Size(1149, 545);
            iDdataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 85);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // AddEmployeebutton
            // 
            AddEmployeebutton.Location = new Point(818, 6);
            AddEmployeebutton.Margin = new Padding(5, 6, 5, 6);
            AddEmployeebutton.Name = "AddEmployeebutton";
            AddEmployeebutton.Size = new Size(283, 82);
            AddEmployeebutton.TabIndex = 2;
            AddEmployeebutton.Text = "Add Employee";
            AddEmployeebutton.UseVisualStyleBackColor = true;
            AddEmployeebutton.Click += AddEmployeebutton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(AddEmployeebutton);
            panel1.Location = new Point(50, 44);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 200);
            panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deptSearchcomboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(NameSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(801, 154);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "SEARCH";
            // 
            // deptSearchcomboBox
            // 
            deptSearchcomboBox.FormattingEnabled = true;
            deptSearchcomboBox.Location = new Point(510, 85);
            deptSearchcomboBox.Name = "deptSearchcomboBox";
            deptSearchcomboBox.Size = new Size(258, 38);
            deptSearchcomboBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 85);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 30);
            label2.TabIndex = 4;
            label2.Text = "Department:";
            // 
            // NameSearch
            // 
            NameSearch.Location = new Point(84, 70);
            NameSearch.Margin = new Padding(5, 6, 5, 6);
            NameSearch.Name = "NameSearch";
            NameSearch.Size = new Size(279, 58);
            NameSearch.TabIndex = 3;
            NameSearch.Text = "";
            // 
            // InvetoryMenu
            // 
            InvetoryMenu.ImageScalingSize = new Size(28, 28);
            InvetoryMenu.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            InvetoryMenu.Location = new Point(0, 0);
            InvetoryMenu.Name = "InvetoryMenu";
            InvetoryMenu.Size = new Size(1222, 38);
            InvetoryMenu.TabIndex = 4;
            InvetoryMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ItemsToolStripMenuItem, addEmployeeToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(85, 34);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // ItemsToolStripMenuItem
            // 
            ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem";
            ItemsToolStripMenuItem.Size = new Size(315, 40);
            ItemsToolStripMenuItem.Text = "Items Collection";
            ItemsToolStripMenuItem.Click += ItemsToolStripMenuItem_Click;
            // 
            // addEmployeeToolStripMenuItem
            // 
            addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            addEmployeeToolStripMenuItem.Size = new Size(315, 40);
            addEmployeeToolStripMenuItem.Text = "Add Employee";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 905);
            Controls.Add(panel1);
            Controls.Add(iDdataGridView);
            Controls.Add(InvetoryMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = InvetoryMenu;
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(1246, 969);
            Name = "Form1";
            Text = "ID CARD INVENTORY";
            ((System.ComponentModel.ISupportInitialize)iDdataGridView).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            InvetoryMenu.ResumeLayout(false);
            InvetoryMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView iDdataGridView;
        private Label label1;
        private Button AddEmployeebutton;
        private Panel panel1;
        private RichTextBox NameSearch;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox deptSearchcomboBox;
        private MenuStrip InvetoryMenu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem ItemsToolStripMenuItem;
        private ToolStripMenuItem addEmployeeToolStripMenuItem;
    }
}
