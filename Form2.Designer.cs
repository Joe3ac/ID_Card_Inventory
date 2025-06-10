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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsWindow));
            typeCombolistBox = new ListBox();
            OptionValuedataGridView = new DataGridView();
            typelabel = new Label();
            AddValuebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)OptionValuedataGridView).BeginInit();
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
            OptionValuedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OptionValuedataGridView.Location = new Point(404, 223);
            OptionValuedataGridView.Name = "OptionValuedataGridView";
            OptionValuedataGridView.RowHeadersWidth = 72;
            OptionValuedataGridView.Size = new Size(476, 405);
            OptionValuedataGridView.TabIndex = 1;
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
            // ItemsWindow
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 919);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox typeCombolistBox;
        private DataGridView OptionValuedataGridView;
        private Label typelabel;
        private Button AddValuebutton;
    }
}