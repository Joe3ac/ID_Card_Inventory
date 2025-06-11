namespace ID_Card_Inventory
{
    partial class ItemsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsWindow));
            typeCombolistBox = new ListBox();
            OptionValuedataGridView = new DataGridView();
            typelabel = new Label();
            AddValuebutton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            delToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)OptionValuedataGridView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // typeCombolistBox
            // 
            typeCombolistBox.FormattingEnabled = true;
            typeCombolistBox.ItemHeight = 30;
            typeCombolistBox.Location = new Point(71, 204);
            typeCombolistBox.Name = "typeCombolistBox";
            typeCombolistBox.Size = new Size(247, 424);
            typeCombolistBox.TabIndex = 0;
            typeCombolistBox.Click += typeCombolistBox_Click;
            // 
            // OptionValuedataGridView
            // 
            OptionValuedataGridView.AllowUserToAddRows = false;
            OptionValuedataGridView.AllowUserToDeleteRows = false;
            OptionValuedataGridView.AllowUserToOrderColumns = true;
            OptionValuedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OptionValuedataGridView.Location = new Point(404, 223);
            OptionValuedataGridView.Name = "OptionValuedataGridView";
            OptionValuedataGridView.ReadOnly = true;
            OptionValuedataGridView.RowHeadersWidth = 72;
            OptionValuedataGridView.Size = new Size(592, 405);
            OptionValuedataGridView.TabIndex = 1;
            OptionValuedataGridView.CellMouseClick += OptionValuedataGridView_CellMouseClick;
            // 
            // typelabel
            // 
            typelabel.AutoSize = true;
            typelabel.Location = new Point(404, 176);
            typelabel.Name = "typelabel";
            typelabel.Size = new Size(68, 30);
            typelabel.TabIndex = 2;
            typelabel.Text = "label1";
            // 
            // AddValuebutton
            // 
            AddValuebutton.Location = new Point(633, 649);
            AddValuebutton.Name = "AddValuebutton";
            AddValuebutton.Size = new Size(176, 59);
            AddValuebutton.TabIndex = 3;
            AddValuebutton.Text = "Add Record";
            AddValuebutton.UseVisualStyleBackColor = true;
            AddValuebutton.Click += AddValuebutton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(28, 28);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { delToolStripMenuItem, editToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(271, 114);
            // 
            // delToolStripMenuItem
            // 
            delToolStripMenuItem.Name = "delToolStripMenuItem";
            delToolStripMenuItem.Size = new Size(270, 36);
            delToolStripMenuItem.Text = "Delete ";
            delToolStripMenuItem.Click += delToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(270, 36);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // ItemsWindow
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 905);
            Controls.Add(AddValuebutton);
            Controls.Add(typelabel);
            Controls.Add(OptionValuedataGridView);
            Controls.Add(typeCombolistBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1246, 969);
            Name = "ItemsWindow";
            Text = "Item Collection Edit";
            Load += ItemsWindow_Load;
            ((System.ComponentModel.ISupportInitialize)OptionValuedataGridView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox typeCombolistBox;
        private DataGridView OptionValuedataGridView;
        private Label typelabel;
        private Button AddValuebutton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem delToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}