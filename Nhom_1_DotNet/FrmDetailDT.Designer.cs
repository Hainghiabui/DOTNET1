namespace Nhom_1_DotNet
{
    partial class FrmDetailDT
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtName = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.detaiName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.detaiDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.detaiField = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.detaiStudent = new System.Windows.Forms.TextBox();
            this.studentName = new System.Windows.Forms.Label();
            this.teacherName = new System.Windows.Forms.Label();
            this.detaiTeacher = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.detaiFaculty = new System.Windows.Forms.ComboBox();
            this.detaiStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.detaiReward = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.detaiComment = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đề tài";
            // 
            // dtName
            // 
            this.dtName.AutoSize = true;
            this.dtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtName.Location = new System.Drawing.Point(27, 53);
            this.dtName.Name = "dtName";
            this.dtName.Size = new System.Drawing.Size(70, 25);
            this.dtName.TabIndex = 1;
            this.dtName.Text = "label2";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(777, 36);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(165, 42);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Lưu thông tin";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đề tài";
            // 
            // detaiName
            // 
            this.detaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaiName.Location = new System.Drawing.Point(32, 181);
            this.detaiName.Name = "detaiName";
            this.detaiName.Size = new System.Drawing.Size(419, 26);
            this.detaiName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mô tả";
            // 
            // detaiDesc
            // 
            this.detaiDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaiDesc.Location = new System.Drawing.Point(32, 252);
            this.detaiDesc.Name = "detaiDesc";
            this.detaiDesc.Size = new System.Drawing.Size(419, 26);
            this.detaiDesc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lĩnh vực";
            // 
            // detaiField
            // 
            this.detaiField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaiField.FormattingEnabled = true;
            this.detaiField.Location = new System.Drawing.Point(486, 181);
            this.detaiField.Name = "detaiField";
            this.detaiField.Size = new System.Drawing.Size(456, 28);
            this.detaiField.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sinh viên thực hiện";
            // 
            // detaiStudent
            // 
            this.detaiStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaiStudent.Location = new System.Drawing.Point(32, 337);
            this.detaiStudent.Name = "detaiStudent";
            this.detaiStudent.Size = new System.Drawing.Size(419, 26);
            this.detaiStudent.TabIndex = 10;
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.Location = new System.Drawing.Point(30, 366);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(135, 16);
            this.studentName.TabIndex = 11;
            this.studentName.Text = "Sinh viên thực hiện";
            this.studentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teacherName
            // 
            this.teacherName.AutoSize = true;
            this.teacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherName.Location = new System.Drawing.Point(33, 462);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(135, 16);
            this.teacherName.TabIndex = 14;
            this.teacherName.Text = "Sinh viên thực hiện";
            this.teacherName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // detaiTeacher
            // 
            this.detaiTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaiTeacher.Location = new System.Drawing.Point(34, 433);
            this.detaiTeacher.Name = "detaiTeacher";
            this.detaiTeacher.Size = new System.Drawing.Size(419, 26);
            this.detaiTeacher.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Giảng viên hướng dẫn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Khoa/Viện";
            // 
            // detaiFaculty
            // 
            this.detaiFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaiFaculty.FormattingEnabled = true;
            this.detaiFaculty.Location = new System.Drawing.Point(34, 528);
            this.detaiFaculty.Name = "detaiFaculty";
            this.detaiFaculty.Size = new System.Drawing.Size(419, 28);
            this.detaiFaculty.TabIndex = 16;
            // 
            // detaiStatus
            // 
            this.detaiStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaiStatus.FormattingEnabled = true;
            this.detaiStatus.Location = new System.Drawing.Point(486, 250);
            this.detaiStatus.Name = "detaiStatus";
            this.detaiStatus.Size = new System.Drawing.Size(456, 28);
            this.detaiStatus.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(485, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Trạng thái đề tài";
            // 
            // detaiReward
            // 
            this.detaiReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaiReward.FormattingEnabled = true;
            this.detaiReward.Location = new System.Drawing.Point(486, 335);
            this.detaiReward.Name = "detaiReward";
            this.detaiReward.Size = new System.Drawing.Size(456, 28);
            this.detaiReward.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(485, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Giải thưởng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(485, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Nhận xét";
            // 
            // detaiComment
            // 
            this.detaiComment.Location = new System.Drawing.Point(486, 433);
            this.detaiComment.Name = "detaiComment";
            this.detaiComment.Size = new System.Drawing.Size(456, 123);
            this.detaiComment.TabIndex = 23;
            this.detaiComment.Text = "";
            // 
            // FrmDetailDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 599);
            this.Controls.Add(this.detaiComment);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.detaiReward);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.detaiStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.detaiFaculty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.teacherName);
            this.Controls.Add(this.detaiTeacher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.detaiStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.detaiField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.detaiDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.detaiName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dtName);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetailDT";
            this.Text = "FrmDetailDT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dtName;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox detaiName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox detaiDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox detaiField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox detaiStudent;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label teacherName;
        private System.Windows.Forms.TextBox detaiTeacher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox detaiFaculty;
        private System.Windows.Forms.ComboBox detaiStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox detaiReward;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox detaiComment;
    }
}