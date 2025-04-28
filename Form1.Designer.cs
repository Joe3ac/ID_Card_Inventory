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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            AddEmployeebutton = new Button();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(662, 207);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 14);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // AddEmployeebutton
            // 
            AddEmployeebutton.Location = new Point(502, 14);
            AddEmployeebutton.Name = "AddEmployeebutton";
            AddEmployeebutton.Size = new Size(96, 41);
            AddEmployeebutton.TabIndex = 2;
            AddEmployeebutton.Text = "Add Employee";
            AddEmployeebutton.UseVisualStyleBackColor = true;
            AddEmployeebutton.Click += AddEmployeebutton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(AddEmployeebutton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(29, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 93);
            panel1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(177, 44);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(131, 31);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 453);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button AddEmployeebutton;
        private Panel panel1;
        private RichTextBox richTextBox1;
    }
}
