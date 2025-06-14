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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            iDdataGridView = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            ClearFilterbutton = new Button();
            groupBox1 = new GroupBox();
            isRefreshbutton = new Button();
            deptSearchcomboBox = new ComboBox();
            label2 = new Label();
            NameSearch = new RichTextBox();
            idPicBox = new PictureBox();
            InvetoryMenu = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            ItemsToolStripMenuItem = new ToolStripMenuItem();
            addEmployeeToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            viewToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            printStatusToolStripMenuItem = new ToolStripMenuItem();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)iDdataGridView).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idPicBox).BeginInit();
            InvetoryMenu.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // iDdataGridView
            // 
            iDdataGridView.AllowUserToDeleteRows = false;
            iDdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iDdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iDdataGridView.Location = new Point(37, 293);
            iDdataGridView.Margin = new Padding(5, 6, 5, 6);
            iDdataGridView.Name = "iDdataGridView";
            iDdataGridView.ReadOnly = true;
            iDdataGridView.RowHeadersWidth = 72;
            iDdataGridView.Size = new Size(1149, 545);
            iDdataGridView.TabIndex = 0;
            iDdataGridView.CellMouseClick += iDdataGridView_CellMouseClick;
            iDdataGridView.Click += iDdataGridView_Click;
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
            // panel1
            // 
            panel1.Controls.Add(ClearFilterbutton);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(14, 50);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 216);
            panel1.TabIndex = 3;
            // 
            // ClearFilterbutton
            // 
            ClearFilterbutton.Location = new Point(225, 163);
            ClearFilterbutton.Name = "ClearFilterbutton";
            ClearFilterbutton.Size = new Size(192, 50);
            ClearFilterbutton.TabIndex = 5;
            ClearFilterbutton.Text = "Clear Filter";
            ClearFilterbutton.UseVisualStyleBackColor = true;
            ClearFilterbutton.Click += ClearFilterbutton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(isRefreshbutton);
            groupBox1.Controls.Add(deptSearchcomboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(NameSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(801, 154);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "SEARCH";
            // 
            // isRefreshbutton
            // 
            isRefreshbutton.Location = new Point(603, -3);
            isRefreshbutton.Name = "isRefreshbutton";
            isRefreshbutton.Size = new Size(192, 50);
            isRefreshbutton.TabIndex = 6;
            isRefreshbutton.Text = "Refresh ";
            isRefreshbutton.UseVisualStyleBackColor = true;
            isRefreshbutton.Click += isRefreshbutton_Click;
            // 
            // deptSearchcomboBox
            // 
            deptSearchcomboBox.FormattingEnabled = true;
            deptSearchcomboBox.Location = new Point(510, 85);
            deptSearchcomboBox.Name = "deptSearchcomboBox";
            deptSearchcomboBox.Size = new Size(258, 38);
            deptSearchcomboBox.TabIndex = 5;
            deptSearchcomboBox.SelectedIndexChanged += deptSearchcomboBox_SelectedIndexChanged;
            deptSearchcomboBox.SelectedValueChanged += deptSearchcomboBox_SelectedValueChanged;
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
            NameSearch.TextChanged += NameSearch_TextChanged;
            // 
            // idPicBox
            // 
            idPicBox.Location = new Point(876, 39);
            idPicBox.Name = "idPicBox";
            idPicBox.Size = new Size(283, 211);
            idPicBox.TabIndex = 6;
            idPicBox.TabStop = false;
            // 
            // InvetoryMenu
            // 
            InvetoryMenu.ImageScalingSize = new Size(28, 28);
            InvetoryMenu.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            InvetoryMenu.Location = new Point(0, 0);
            InvetoryMenu.Name = "InvetoryMenu";
            InvetoryMenu.Size = new Size(1222, 44);
            InvetoryMenu.TabIndex = 4;
            InvetoryMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ItemsToolStripMenuItem, addEmployeeToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(100, 40);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // ItemsToolStripMenuItem
            // 
            ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem";
            ItemsToolStripMenuItem.Size = new Size(319, 44);
            ItemsToolStripMenuItem.Text = "Items Collection";
            ItemsToolStripMenuItem.Click += ItemsToolStripMenuItem_Click;
            // 
            // addEmployeeToolStripMenuItem
            // 
            addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            addEmployeeToolStripMenuItem.Size = new Size(319, 44);
            addEmployeeToolStripMenuItem.Text = "Add Employee";
            addEmployeeToolStripMenuItem.Click += addEmployeeToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(28, 28);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, printStatusToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(192, 148);
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(191, 36);
            viewToolStripMenuItem.Text = "View";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(191, 36);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(191, 36);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // printStatusToolStripMenuItem
            // 
            printStatusToolStripMenuItem.Name = "printStatusToolStripMenuItem";
            printStatusToolStripMenuItem.Size = new Size(191, 36);
            printStatusToolStripMenuItem.Text = "Print Status";
            printStatusToolStripMenuItem.Click += printStatusToolStripMenuItem_Click;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 905);
            Controls.Add(idPicBox);
            Controls.Add(panel1);
            Controls.Add(iDdataGridView);
            Controls.Add(InvetoryMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = InvetoryMenu;
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(1246, 969);
            Name = "Form1";
            Text = "ID CARD INVENTORY";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)iDdataGridView).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idPicBox).EndInit();
            InvetoryMenu.ResumeLayout(false);
            InvetoryMenu.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView iDdataGridView;
        private Label label1;
        private Panel panel1;
        private RichTextBox NameSearch;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox deptSearchcomboBox;
        private MenuStrip InvetoryMenu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem ItemsToolStripMenuItem;
        private ToolStripMenuItem addEmployeeToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem printStatusToolStripMenuItem;
        private Button ClearFilterbutton;
        private PictureBox idPicBox;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button isRefreshbutton;
    }
}
