namespace APILab2WF
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
            btnAdd = new Button();
            comSup = new ComboBox();
            comDept = new ComboBox();
            numAge = new NumericUpDown();
            label6 = new Label();
            txtAdd = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtLName = new TextBox();
            label2 = new Label();
            txtFName = new TextBox();
            label1 = new Label();
            dvgStudents = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgStudents).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightBlue;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(503, 347);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 41);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // comSup
            // 
            comSup.FormattingEnabled = true;
            comSup.Location = new Point(792, 239);
            comSup.Margin = new Padding(4, 5, 4, 5);
            comSup.Name = "comSup";
            comSup.Size = new Size(222, 28);
            comSup.TabIndex = 16;
            // 
            // comDept
            // 
            comDept.FormattingEnabled = true;
            comDept.Location = new Point(792, 140);
            comDept.Margin = new Padding(4, 5, 4, 5);
            comDept.Name = "comDept";
            comDept.Size = new Size(222, 28);
            comDept.TabIndex = 17;
            // 
            // numAge
            // 
            numAge.Location = new Point(792, 55);
            numAge.Margin = new Padding(4, 5, 4, 5);
            numAge.Name = "numAge";
            numAge.Size = new Size(88, 27);
            numAge.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(680, 242);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 7;
            label6.Text = "Supervisor";
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(206, 240);
            txtAdd.Margin = new Padding(4, 5, 4, 5);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(244, 27);
            txtAdd.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(680, 143);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 8;
            label5.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 243);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Address";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(206, 145);
            txtLName.Margin = new Padding(4, 5, 4, 5);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(244, 27);
            txtLName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 148);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 10;
            label2.Text = "Last Name";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(206, 52);
            txtFName.Margin = new Padding(4, 5, 4, 5);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(244, 27);
            txtFName.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 11;
            label1.Text = "First Name";
            // 
            // dvgStudents
            // 
            dvgStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgStudents.Location = new Point(47, 434);
            dvgStudents.Margin = new Padding(4, 5, 4, 5);
            dvgStudents.Name = "dvgStudents";
            dvgStudents.RowHeadersWidth = 51;
            dvgStudents.RowTemplate.Height = 29;
            dvgStudents.Size = new Size(1067, 263);
            dvgStudents.TabIndex = 6;
            dvgStudents.CellContentClick += dvgStudents_CellContentClick_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(680, 57);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 19;
            label4.Text = "Age";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 711);
            Controls.Add(label4);
            Controls.Add(btnAdd);
            Controls.Add(comSup);
            Controls.Add(comDept);
            Controls.Add(numAge);
            Controls.Add(label6);
            Controls.Add(txtAdd);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtLName);
            Controls.Add(label2);
            Controls.Add(txtFName);
            Controls.Add(label1);
            Controls.Add(dvgStudents);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ComboBox comSup;
        private ComboBox comDept;
        private NumericUpDown numAge;
        private Label label6;
        private TextBox txtAdd;
        private Label label5;
        private Label label3;
        private TextBox txtLName;
        private Label label2;
        private TextBox txtFName;
        private Label label1;
        private DataGridView dvgStudents;
        private Label label4;
    }
}