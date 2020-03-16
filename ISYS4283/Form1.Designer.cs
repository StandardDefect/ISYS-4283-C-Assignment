namespace ISYS4283
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
            this.cboxStudent = new System.Windows.Forms.ComboBox();
            this.lboxCourse = new System.Windows.Forms.ListBox();
            this.dgvRegistration = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textSection = new System.Windows.Forms.TextBox();
            this.textCollege = new System.Windows.Forms.TextBox();
            this.textCreditHours = new System.Windows.Forms.TextBox();
            this.textCourseName = new System.Windows.Forms.TextBox();
            this.textMajor = new System.Windows.Forms.TextBox();
            this.textSex = new System.Windows.Forms.TextBox();
            this.textDateofBirth = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textStartDate = new System.Windows.Forms.TextBox();
            this.textEndDate = new System.Windows.Forms.TextBox();
            this.textTime = new System.Windows.Forms.TextBox();
            this.textClassSize = new System.Windows.Forms.TextBox();
            this.textOnline = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxStudent
            // 
            this.cboxStudent.FormattingEnabled = true;
            this.cboxStudent.Location = new System.Drawing.Point(12, 33);
            this.cboxStudent.Name = "cboxStudent";
            this.cboxStudent.Size = new System.Drawing.Size(121, 21);
            this.cboxStudent.TabIndex = 0;
            this.cboxStudent.SelectedIndexChanged += new System.EventHandler(this.cboxStudent_SelectedIndexChanged);
            // 
            // lboxCourse
            // 
            this.lboxCourse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lboxCourse.FormattingEnabled = true;
            this.lboxCourse.Location = new System.Drawing.Point(177, 33);
            this.lboxCourse.Name = "lboxCourse";
            this.lboxCourse.Size = new System.Drawing.Size(179, 95);
            this.lboxCourse.TabIndex = 1;
            // 
            // dgvRegistration
            // 
            this.dgvRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistration.Location = new System.Drawing.Point(423, 33);
            this.dgvRegistration.Name = "dgvRegistration";
            this.dgvRegistration.Size = new System.Drawing.Size(318, 150);
            this.dgvRegistration.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(854, 33);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 52);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(935, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 52);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.Location = new System.Drawing.Point(773, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 52);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(903, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 52);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(804, 373);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 52);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Class Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Section";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Online?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Major";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Date of Birth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Credit Hours";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(420, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Start Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(227, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "College";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Course Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Sex";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "First Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(420, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Registration List:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(174, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Select Course:";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(66, 212);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(100, 20);
            this.textFirstName.TabIndex = 26;
            // 
            // textSection
            // 
            this.textSection.Location = new System.Drawing.Point(481, 209);
            this.textSection.Name = "textSection";
            this.textSection.Size = new System.Drawing.Size(100, 20);
            this.textSection.TabIndex = 27;
            // 
            // textCollege
            // 
            this.textCollege.Location = new System.Drawing.Point(275, 270);
            this.textCollege.Name = "textCollege";
            this.textCollege.Size = new System.Drawing.Size(100, 20);
            this.textCollege.TabIndex = 28;
            // 
            // textCreditHours
            // 
            this.textCreditHours.Location = new System.Drawing.Point(275, 241);
            this.textCreditHours.Name = "textCreditHours";
            this.textCreditHours.Size = new System.Drawing.Size(100, 20);
            this.textCreditHours.TabIndex = 29;
            // 
            // textCourseName
            // 
            this.textCourseName.Location = new System.Drawing.Point(275, 209);
            this.textCourseName.Name = "textCourseName";
            this.textCourseName.Size = new System.Drawing.Size(100, 20);
            this.textCourseName.TabIndex = 30;
            // 
            // textMajor
            // 
            this.textMajor.Location = new System.Drawing.Point(66, 331);
            this.textMajor.Name = "textMajor";
            this.textMajor.Size = new System.Drawing.Size(100, 20);
            this.textMajor.TabIndex = 31;
            // 
            // textSex
            // 
            this.textSex.Location = new System.Drawing.Point(66, 300);
            this.textSex.Name = "textSex";
            this.textSex.Size = new System.Drawing.Size(100, 20);
            this.textSex.TabIndex = 32;
            // 
            // textDateofBirth
            // 
            this.textDateofBirth.Location = new System.Drawing.Point(66, 270);
            this.textDateofBirth.Name = "textDateofBirth";
            this.textDateofBirth.Size = new System.Drawing.Size(100, 20);
            this.textDateofBirth.TabIndex = 33;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(66, 241);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(100, 20);
            this.textLastName.TabIndex = 34;
            // 
            // textStartDate
            // 
            this.textStartDate.Location = new System.Drawing.Point(481, 241);
            this.textStartDate.Name = "textStartDate";
            this.textStartDate.Size = new System.Drawing.Size(100, 20);
            this.textStartDate.TabIndex = 35;
            // 
            // textEndDate
            // 
            this.textEndDate.Location = new System.Drawing.Point(481, 270);
            this.textEndDate.Name = "textEndDate";
            this.textEndDate.Size = new System.Drawing.Size(100, 20);
            this.textEndDate.TabIndex = 36;
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(481, 300);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(100, 20);
            this.textTime.TabIndex = 37;
            // 
            // textClassSize
            // 
            this.textClassSize.Location = new System.Drawing.Point(481, 331);
            this.textClassSize.Name = "textClassSize";
            this.textClassSize.Size = new System.Drawing.Size(100, 20);
            this.textClassSize.TabIndex = 38;
            // 
            // textOnline
            // 
            this.textOnline.Location = new System.Drawing.Point(275, 300);
            this.textOnline.Name = "textOnline";
            this.textOnline.Size = new System.Drawing.Size(100, 20);
            this.textOnline.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 474);
            this.Controls.Add(this.textOnline);
            this.Controls.Add(this.textClassSize);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.textEndDate);
            this.Controls.Add(this.textStartDate);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textDateofBirth);
            this.Controls.Add(this.textSex);
            this.Controls.Add(this.textMajor);
            this.Controls.Add(this.textCourseName);
            this.Controls.Add(this.textCreditHours);
            this.Controls.Add(this.textCollege);
            this.Controls.Add(this.textSection);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvRegistration);
            this.Controls.Add(this.lboxCourse);
            this.Controls.Add(this.cboxStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxStudent;
        private System.Windows.Forms.ListBox lboxCourse;
        private System.Windows.Forms.DataGridView dgvRegistration;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textSection;
        private System.Windows.Forms.TextBox textCollege;
        private System.Windows.Forms.TextBox textCreditHours;
        private System.Windows.Forms.TextBox textCourseName;
        private System.Windows.Forms.TextBox textMajor;
        private System.Windows.Forms.TextBox textSex;
        private System.Windows.Forms.TextBox textDateofBirth;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textStartDate;
        private System.Windows.Forms.TextBox textEndDate;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.TextBox textClassSize;
        private System.Windows.Forms.TextBox textOnline;
    }
}

