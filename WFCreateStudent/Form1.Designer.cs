namespace WFCreateStudent
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
            label1 = new Label();
            btnCreate = new Button();
            txtName = new TextBox();
            txtPname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtMname = new TextBox();
            dtpDatetime = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            label6 = new Label();
            txtCareer = new TextBox();
            label7 = new Label();
            nudAverage = new NumericUpDown();
            LblStudent = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAverage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "NAME";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(609, 252);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(167, 55);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(12, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(328, 34);
            txtName.TabIndex = 2;
            // 
            // txtPname
            // 
            txtPname.Font = new Font("Segoe UI", 12F);
            txtPname.Location = new Point(348, 55);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(192, 34);
            txtPname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(348, 22);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 4;
            label2.Text = "PATER`S LAST NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(546, 22);
            label3.Name = "label3";
            label3.Size = new Size(216, 28);
            label3.TabIndex = 6;
            label3.Text = "MOTHER`S LAST NAME";
            // 
            // txtMname
            // 
            txtMname.Font = new Font("Segoe UI", 12F);
            txtMname.Location = new Point(546, 55);
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(216, 34);
            txtMname.TabIndex = 5;
            // 
            // dtpDatetime
            // 
            dtpDatetime.Font = new Font("Segoe UI", 12F);
            dtpDatetime.Format = DateTimePickerFormat.Short;
            dtpDatetime.Location = new Point(12, 136);
            dtpDatetime.Name = "dtpDatetime";
            dtpDatetime.Size = new Size(188, 34);
            dtpDatetime.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(144, 28);
            label4.TabIndex = 8;
            label4.Text = "DATE OF BIRTH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(231, 104);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 10;
            label5.Text = "ID STUDENT";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.Location = new Point(231, 137);
            txtId.Name = "txtId";
            txtId.Size = new Size(238, 34);
            txtId.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(477, 104);
            label6.Name = "label6";
            label6.Size = new Size(170, 28);
            label6.TabIndex = 12;
            label6.Text = "STUDENT CAREER";
            // 
            // txtCareer
            // 
            txtCareer.Font = new Font("Segoe UI", 12F);
            txtCareer.Location = new Point(477, 137);
            txtCareer.Name = "txtCareer";
            txtCareer.Size = new Size(285, 34);
            txtCareer.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(477, 181);
            label7.Name = "label7";
            label7.Size = new Size(95, 28);
            label7.TabIndex = 13;
            label7.Text = "AVERAGE";
            // 
            // nudAverage
            // 
            nudAverage.AccessibleDescription = "nudAverage";
            nudAverage.Font = new Font("Segoe UI", 12F);
            nudAverage.Location = new Point(477, 212);
            nudAverage.Name = "nudAverage";
            nudAverage.Size = new Size(150, 34);
            nudAverage.TabIndex = 14;
            // 
            // LblStudent
            // 
            LblStudent.AutoSize = true;
            LblStudent.Font = new Font("Segoe UI", 12F);
            LblStudent.Location = new Point(31, 279);
            LblStudent.Name = "LblStudent";
            LblStudent.Size = new Size(0, 28);
            LblStudent.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblStudent);
            Controls.Add(nudAverage);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtCareer);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(dtpDatetime);
            Controls.Add(label3);
            Controls.Add(txtMname);
            Controls.Add(label2);
            Controls.Add(txtPname);
            Controls.Add(txtName);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudAverage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCreate;
        private TextBox txtName;
        private TextBox txtPname;
        private Label label2;
        private Label label3;
        private TextBox txtMname;
        private DateTimePicker dtpDatetime;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private Label label6;
        private TextBox txtCareer;
        private Label label7;
        private NumericUpDown nudAverage;
        private Label LblStudent;
    }
}
