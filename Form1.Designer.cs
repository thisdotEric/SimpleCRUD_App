namespace SimpleSystem
{
    partial class Form1
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
            this.addStudent = new System.Windows.Forms.Button();
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            this.viewStudents = new System.Windows.Forms.Button();
            this.studentIdSearchTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.studentId = new System.Windows.Forms.RichTextBox();
            this.yearLevel = new System.Windows.Forms.RichTextBox();
            this.course = new System.Windows.Forms.RichTextBox();
            this.lname = new System.Windows.Forms.RichTextBox();
            this.mname = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.studentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addStudent
            // 
            this.addStudent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent.Location = new System.Drawing.Point(529, 44);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(164, 54);
            this.addStudent.TabIndex = 1;
            this.addStudent.Text = "Save Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.AllowUserToAddRows = false;
            this.studentDataGrid.AllowUserToDeleteRows = false;
            this.studentDataGrid.AllowUserToResizeColumns = false;
            this.studentDataGrid.AllowUserToResizeRows = false;
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Location = new System.Drawing.Point(12, 295);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.Size = new System.Drawing.Size(681, 230);
            this.studentDataGrid.TabIndex = 2;
            this.studentDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChooseStudent_Click);
            // 
            // viewStudents
            // 
            this.viewStudents.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStudents.Location = new System.Drawing.Point(529, 104);
            this.viewStudents.Name = "viewStudents";
            this.viewStudents.Size = new System.Drawing.Size(164, 51);
            this.viewStudents.TabIndex = 3;
            this.viewStudents.Text = "View All Students";
            this.viewStudents.UseVisualStyleBackColor = true;
            this.viewStudents.Click += new System.EventHandler(this.ViewAllStudents_Click);
            // 
            // studentIdSearchTextBox
            // 
            this.studentIdSearchTextBox.Location = new System.Drawing.Point(116, 247);
            this.studentIdSearchTextBox.Multiline = false;
            this.studentIdSearchTextBox.Name = "studentIdSearchTextBox";
            this.studentIdSearchTextBox.Size = new System.Drawing.Size(203, 27);
            this.studentIdSearchTextBox.TabIndex = 12;
            this.studentIdSearchTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchStudent_Click);
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Enabled = false;
            this.deleteStudentButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteStudentButton.Location = new System.Drawing.Point(529, 161);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(164, 51);
            this.deleteStudentButton.TabIndex = 14;
            this.deleteStudentButton.Text = "Delete Student";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentPanel);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // studentPanel
            // 
            this.studentPanel.ColumnCount = 2;
            this.studentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.7234F));
            this.studentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.2766F));
            this.studentPanel.Controls.Add(this.studentId, 1, 5);
            this.studentPanel.Controls.Add(this.yearLevel, 1, 4);
            this.studentPanel.Controls.Add(this.course, 1, 3);
            this.studentPanel.Controls.Add(this.lname, 1, 2);
            this.studentPanel.Controls.Add(this.mname, 1, 1);
            this.studentPanel.Controls.Add(this.label11, 0, 5);
            this.studentPanel.Controls.Add(this.label9, 0, 4);
            this.studentPanel.Controls.Add(this.label7, 0, 3);
            this.studentPanel.Controls.Add(this.label5, 0, 2);
            this.studentPanel.Controls.Add(this.label3, 0, 1);
            this.studentPanel.Controls.Add(this.label1, 0, 0);
            this.studentPanel.Controls.Add(this.fname, 1, 0);
            this.studentPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentPanel.Location = new System.Drawing.Point(6, 19);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.RowCount = 6;
            this.studentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.studentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.studentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.studentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.studentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.studentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.studentPanel.Size = new System.Drawing.Size(470, 185);
            this.studentPanel.TabIndex = 0;
            // 
            // studentId
            // 
            this.studentId.Location = new System.Drawing.Point(137, 153);
            this.studentId.Multiline = false;
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(330, 24);
            this.studentId.TabIndex = 16;
            this.studentId.Text = "";
            // 
            // yearLevel
            // 
            this.yearLevel.Location = new System.Drawing.Point(137, 123);
            this.yearLevel.Multiline = false;
            this.yearLevel.Name = "yearLevel";
            this.yearLevel.Size = new System.Drawing.Size(330, 24);
            this.yearLevel.TabIndex = 15;
            this.yearLevel.Text = "";
            // 
            // course
            // 
            this.course.Location = new System.Drawing.Point(137, 93);
            this.course.Multiline = false;
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(330, 24);
            this.course.TabIndex = 14;
            this.course.Text = "";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(137, 63);
            this.lname.Multiline = false;
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(330, 24);
            this.lname.TabIndex = 13;
            this.lname.Text = "";
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(137, 33);
            this.mname.Multiline = false;
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(330, 24);
            this.mname.TabIndex = 12;
            this.mname.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 35);
            this.label11.TabIndex = 10;
            this.label11.Text = "Student Id";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 30);
            this.label9.TabIndex = 8;
            this.label9.Text = "Year Level";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Course";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Middle Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(137, 3);
            this.fname.Multiline = false;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(330, 24);
            this.fname.TabIndex = 11;
            this.fname.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 537);
            this.Controls.Add(this.deleteStudentButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentIdSearchTextBox);
            this.Controls.Add(this.viewStudents);
            this.Controls.Add(this.studentDataGrid);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.DataGridView studentDataGrid;
        private System.Windows.Forms.Button viewStudents;
        private System.Windows.Forms.RichTextBox studentIdSearchTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel studentPanel;
        private System.Windows.Forms.RichTextBox studentId;
        private System.Windows.Forms.RichTextBox yearLevel;
        private System.Windows.Forms.RichTextBox course;
        private System.Windows.Forms.RichTextBox lname;
        private System.Windows.Forms.RichTextBox mname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox fname;
    }
}

