namespace ID_Card_Inventory
{
    partial class AddEmpForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            NameTextBox = new RichTextBox();
            label2 = new Label();
            SurnameTextBox = new RichTextBox();
            label3 = new Label();
            IDNumTextBox = new RichTextBox();
            label4 = new Label();
            DeptMent_comboBox = new ComboBox();
            label7 = new Label();
            PositionTextbox = new RichTextBox();
            label8 = new Label();
            dateOfIssue = new DateTimePicker();
            label9 = new Label();
            EmploymentStatus_Combo = new ComboBox();
            label5 = new Label();
            IDpictureBox = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            openFileDialog1 = new OpenFileDialog();
            Saved_button = new Button();
            Add_Photo_Bttn = new Button();
            label10 = new Label();
            panel2 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IDpictureBox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(NameTextBox);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(SurnameTextBox);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(IDNumTextBox);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(DeptMent_comboBox);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(PositionTextbox);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(dateOfIssue);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(EmploymentStatus_Combo);
            flowLayoutPanel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(55, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(219, 377);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.TabStop = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(3, 20);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(174, 29);
            NameTextBox.TabIndex = 4;
            NameTextBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 52);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 1;
            label2.Text = "Surname:";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(3, 72);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(174, 29);
            SurnameTextBox.TabIndex = 5;
            SurnameTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 104);
            label3.Name = "label3";
            label3.Size = new Size(127, 17);
            label3.TabIndex = 2;
            label3.Text = "Employee Number:";
            // 
            // IDNumTextBox
            // 
            IDNumTextBox.Location = new Point(3, 124);
            IDNumTextBox.Name = "IDNumTextBox";
            IDNumTextBox.Size = new Size(174, 29);
            IDNumTextBox.TabIndex = 6;
            IDNumTextBox.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 156);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 3;
            label4.Text = "Department:";
            // 
            // DeptMent_comboBox
            // 
            DeptMent_comboBox.FormattingEnabled = true;
            DeptMent_comboBox.Location = new Point(3, 176);
            DeptMent_comboBox.Name = "DeptMent_comboBox";
            DeptMent_comboBox.Size = new Size(174, 25);
            DeptMent_comboBox.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 204);
            label7.Name = "label7";
            label7.Size = new Size(63, 17);
            label7.TabIndex = 7;
            label7.Text = "Position:";
            // 
            // PositionTextbox
            // 
            PositionTextbox.Location = new Point(3, 224);
            PositionTextbox.Name = "PositionTextbox";
            PositionTextbox.Size = new Size(174, 29);
            PositionTextbox.TabIndex = 8;
            PositionTextbox.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 256);
            label8.Name = "label8";
            label8.Size = new Size(93, 17);
            label8.TabIndex = 9;
            label8.Text = "Date of Issue:";
            // 
            // dateOfIssue
            // 
            dateOfIssue.Format = DateTimePickerFormat.Short;
            dateOfIssue.Location = new Point(3, 276);
            dateOfIssue.Name = "dateOfIssue";
            dateOfIssue.Size = new Size(174, 25);
            dateOfIssue.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 304);
            label9.Name = "label9";
            label9.Size = new Size(132, 17);
            label9.TabIndex = 11;
            label9.Text = "Employment Status:";
            // 
            // EmploymentStatus_Combo
            // 
            EmploymentStatus_Combo.FormattingEnabled = true;
            EmploymentStatus_Combo.Location = new Point(3, 324);
            EmploymentStatus_Combo.Name = "EmploymentStatus_Combo";
            EmploymentStatus_Combo.Size = new Size(174, 25);
            EmploymentStatus_Combo.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(336, 48);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 4;
            label5.Text = "ID Photo:";
            // 
            // IDpictureBox
            // 
            IDpictureBox.Location = new Point(327, 68);
            IDpictureBox.Name = "IDpictureBox";
            IDpictureBox.Size = new Size(214, 229);
            IDpictureBox.TabIndex = 5;
            IDpictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 45);
            panel1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(218, 19);
            label6.Name = "label6";
            label6.Size = new Size(185, 24);
            label6.TabIndex = 7;
            label6.Text = "Employee Details";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "\"Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif\"";
            openFileDialog1.Title = "Select Image:";
            // 
            // Saved_button
            // 
            Saved_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Saved_button.Location = new Point(292, 389);
            Saved_button.Name = "Saved_button";
            Saved_button.Size = new Size(120, 39);
            Saved_button.TabIndex = 7;
            Saved_button.Text = "Save Changes";
            Saved_button.UseVisualStyleBackColor = true;
            Saved_button.Click += Saved_button_Click;
            // 
            // Add_Photo_Bttn
            // 
            Add_Photo_Bttn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Photo_Bttn.Location = new Point(179, 8);
            Add_Photo_Bttn.Name = "Add_Photo_Bttn";
            Add_Photo_Bttn.Size = new Size(120, 31);
            Add_Photo_Bttn.TabIndex = 8;
            Add_Photo_Bttn.Text = "Add Photo";
            Add_Photo_Bttn.UseVisualStyleBackColor = true;
            Add_Photo_Bttn.Click += Add_Photo_Bttn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 18);
            label10.Name = "label10";
            label10.Size = new Size(151, 15);
            label10.TabIndex = 9;
            label10.Text = "Click Here to Upload Photo";
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(Add_Photo_Bttn);
            panel2.Location = new Point(292, 303);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 51);
            panel2.TabIndex = 10;
            // 
            // AddEmpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(627, 450);
            Controls.Add(panel2);
            Controls.Add(Saved_button);
            Controls.Add(panel1);
            Controls.Add(IDpictureBox);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEmpForm";
            Text = "Empolyee Details Form";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IDpictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox DeptMent_comboBox;
        private RichTextBox NameTextBox;
        private RichTextBox SurnameTextBox;
        private RichTextBox IDNumTextBox;
        private Label label5;
        private PictureBox IDpictureBox;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private RichTextBox PositionTextbox;
        private Label label8;
        private DateTimePicker dateOfIssue;
        private Label label9;
        private ComboBox EmploymentStatus_Combo;
        private OpenFileDialog openFileDialog1;
        private Button Saved_button;
        private Button Add_Photo_Bttn;
        private Label label10;
        private Panel panel2;
    }
}