
namespace Hotel
{
    partial class Employee
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
            this.find = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.all = new System.Windows.Forms.Button();
            this.deleting = new System.Windows.Forms.Button();
            this.adding = new System.Windows.Forms.Button();
            this.myCode = new System.Windows.Forms.Label();
            this.myPhone = new System.Windows.Forms.Label();
            this.myLName = new System.Windows.Forms.Label();
            this.myFName = new System.Windows.Forms.Label();
            this.mySalary = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.find.ForeColor = System.Drawing.Color.White;
            this.find.Location = new System.Drawing.Point(12, 198);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(157, 64);
            this.find.TabIndex = 28;
            this.find.Text = "Find Me";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 29;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(87)))));
            this.title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(335, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(147, 34);
            this.title.TabIndex = 11;
            this.title.Text = "Check Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(87)))));
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(764, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 39);
            this.label6.TabIndex = 10;
            this.label6.Tag = "";
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(87)))));
            this.label13.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(335, 539);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 34);
            this.label13.TabIndex = 41;
            this.label13.Text = "Назад";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Code
            // 
            this.Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Code.Location = new System.Drawing.Point(14, 156);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(157, 36);
            this.Code.TabIndex = 42;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(7, 114);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(269, 39);
            this.info.TabIndex = 43;
            this.info.Text = "Enter Your Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(474, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 63;
            this.label4.Text = "Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(474, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 31);
            this.label5.TabIndex = 62;
            this.label5.Text = "Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(474, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 31);
            this.label7.TabIndex = 61;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(474, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 31);
            this.label8.TabIndex = 60;
            this.label8.Text = "LName:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(474, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 31);
            this.label9.TabIndex = 59;
            this.label9.Text = "FName:";
            // 
            // all
            // 
            this.all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.all.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.all.ForeColor = System.Drawing.Color.White;
            this.all.Location = new System.Drawing.Point(18, 417);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(232, 93);
            this.all.TabIndex = 67;
            this.all.Text = "All Customers";
            this.all.UseVisualStyleBackColor = false;
            this.all.Visible = false;
            this.all.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleting
            // 
            this.deleting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.deleting.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.deleting.ForeColor = System.Drawing.Color.White;
            this.deleting.Location = new System.Drawing.Point(550, 417);
            this.deleting.Name = "deleting";
            this.deleting.Size = new System.Drawing.Size(232, 93);
            this.deleting.TabIndex = 66;
            this.deleting.Text = "Deleting Customer";
            this.deleting.UseVisualStyleBackColor = false;
            this.deleting.Visible = false;
            this.deleting.Click += new System.EventHandler(this.button5_Click);
            // 
            // adding
            // 
            this.adding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.adding.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.adding.ForeColor = System.Drawing.Color.White;
            this.adding.Location = new System.Drawing.Point(280, 417);
            this.adding.Name = "adding";
            this.adding.Size = new System.Drawing.Size(232, 93);
            this.adding.TabIndex = 65;
            this.adding.Text = "Adding Customer";
            this.adding.UseVisualStyleBackColor = false;
            this.adding.Visible = false;
            this.adding.Click += new System.EventHandler(this.button1_Click);
            // 
            // myCode
            // 
            this.myCode.AutoSize = true;
            this.myCode.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.myCode.ForeColor = System.Drawing.Color.White;
            this.myCode.Location = new System.Drawing.Point(582, 231);
            this.myCode.Name = "myCode";
            this.myCode.Size = new System.Drawing.Size(0, 31);
            this.myCode.TabIndex = 68;
            // 
            // myPhone
            // 
            this.myPhone.AutoSize = true;
            this.myPhone.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.myPhone.ForeColor = System.Drawing.Color.White;
            this.myPhone.Location = new System.Drawing.Point(582, 284);
            this.myPhone.Name = "myPhone";
            this.myPhone.Size = new System.Drawing.Size(0, 31);
            this.myPhone.TabIndex = 69;
            // 
            // myLName
            // 
            this.myLName.AutoSize = true;
            this.myLName.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.myLName.ForeColor = System.Drawing.Color.White;
            this.myLName.Location = new System.Drawing.Point(582, 175);
            this.myLName.Name = "myLName";
            this.myLName.Size = new System.Drawing.Size(0, 31);
            this.myLName.TabIndex = 70;
            // 
            // myFName
            // 
            this.myFName.AutoSize = true;
            this.myFName.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.myFName.ForeColor = System.Drawing.Color.White;
            this.myFName.Location = new System.Drawing.Point(582, 122);
            this.myFName.Name = "myFName";
            this.myFName.Size = new System.Drawing.Size(0, 31);
            this.myFName.TabIndex = 71;
            // 
            // mySalary
            // 
            this.mySalary.AutoSize = true;
            this.mySalary.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.mySalary.ForeColor = System.Drawing.Color.White;
            this.mySalary.Location = new System.Drawing.Point(582, 341);
            this.mySalary.Name = "mySalary";
            this.mySalary.Size = new System.Drawing.Size(0, 31);
            this.mySalary.TabIndex = 72;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.mySalary);
            this.Controls.Add(this.myFName);
            this.Controls.Add(this.myLName);
            this.Controls.Add(this.myPhone);
            this.Controls.Add(this.myCode);
            this.Controls.Add(this.all);
            this.Controls.Add(this.deleting);
            this.Controls.Add(this.adding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.Button deleting;
        private System.Windows.Forms.Button adding;
        private System.Windows.Forms.Label myCode;
        private System.Windows.Forms.Label myPhone;
        private System.Windows.Forms.Label myLName;
        private System.Windows.Forms.Label myFName;
        private System.Windows.Forms.Label mySalary;
    }
}