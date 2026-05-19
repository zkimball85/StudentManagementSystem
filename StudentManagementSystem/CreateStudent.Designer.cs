namespace StudentManagementSystem
{
    partial class CreateStudent
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
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtDateOfBirth = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnCreateStudent = new Button();
            SuspendLayout();
            // 
            // txtFName
            // 
            txtFName.Location = new Point(197, 46);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(200, 39);
            txtFName.TabIndex = 0;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(197, 128);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(200, 39);
            txtLName.TabIndex = 1;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(197, 212);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(200, 39);
            txtDateOfBirth.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 50);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 135);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 219);
            label3.Name = "label3";
            label3.Size = new Size(63, 32);
            label3.TabIndex = 5;
            label3.Text = "DOB";
            // 
            // BtnCreateStudent
            // 
            BtnCreateStudent.Location = new Point(47, 316);
            BtnCreateStudent.Name = "BtnCreateStudent";
            BtnCreateStudent.Size = new Size(350, 70);
            BtnCreateStudent.TabIndex = 6;
            BtnCreateStudent.Text = "Create Student";
            BtnCreateStudent.UseVisualStyleBackColor = true;
            BtnCreateStudent.Click += BtnCreateStudent_Click;
            // 
            // CreateStudent
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 420);
            Controls.Add(BtnCreateStudent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Name = "CreateStudent";
            Text = "CreateStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtDateOfBirth;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnCreateStudent;
    }
}