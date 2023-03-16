
namespace Hotel
{
    partial class Adinstrator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.user1 = new System.Windows.Forms.Label();
            this.user2 = new System.Windows.Forms.TextBox();
            this.pass1 = new System.Windows.Forms.Label();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 45;
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(87)))));
            this.title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(329, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(250, 34);
            this.title.TabIndex = 1;
            this.title.Text = "Adminstraror Login";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(546, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 93);
            this.button1.TabIndex = 51;
            this.button1.Text = "Adding Customer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(556, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 93);
            this.button2.TabIndex = 52;
            this.button2.Text = "Deleting Customer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button5_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.button5.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(277, 93);
            this.button5.TabIndex = 53;
            this.button5.Text = "Adding Employee";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.button6.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(12, 214);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(277, 93);
            this.button6.TabIndex = 55;
            this.button6.Text = "All Employees";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(556, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 93);
            this.button3.TabIndex = 56;
            this.button3.Text = "All Customers";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(308, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 93);
            this.button4.TabIndex = 57;
            this.button4.Text = "Adding New Room";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button8_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(87)))));
            this.label13.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(371, 517);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 34);
            this.label13.TabIndex = 58;
            this.label13.Text = "Назад";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // user1
            // 
            this.user1.AutoSize = true;
            this.user1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.user1.ForeColor = System.Drawing.Color.White;
            this.user1.Location = new System.Drawing.Point(295, 200);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(171, 36);
            this.user1.TabIndex = 60;
            this.user1.Text = "User Name:";
            // 
            // user2
            // 
            this.user2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.user2.Location = new System.Drawing.Point(302, 242);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(189, 36);
            this.user2.TabIndex = 59;
            // 
            // pass1
            // 
            this.pass1.AutoSize = true;
            this.pass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pass1.ForeColor = System.Drawing.Color.White;
            this.pass1.Location = new System.Drawing.Point(296, 281);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(155, 36);
            this.pass1.TabIndex = 62;
            this.pass1.Text = "Password:";
            // 
            // pass2
            // 
            this.pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pass2.Location = new System.Drawing.Point(303, 323);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(189, 36);
            this.pass2.TabIndex = 61;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.enter.ForeColor = System.Drawing.Color.White;
            this.enter.Location = new System.Drawing.Point(301, 365);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(157, 64);
            this.enter.TabIndex = 63;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // Adinstrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.user2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adinstrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adinstrator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label user1;
        private System.Windows.Forms.TextBox user2;
        private System.Windows.Forms.Label pass1;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.Button enter;
    }
}