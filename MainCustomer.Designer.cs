namespace Hotel
{
    partial class MainCustomer
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
            this.title = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bookingRoom = new System.Windows.Forms.Button();
            this.gettingInfo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 67;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(87)))));
            this.title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(335, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(211, 34);
            this.title.TabIndex = 11;
            this.title.Text = "Customer Home";
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
            // 
            // bookingRoom
            // 
            this.bookingRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.bookingRoom.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.bookingRoom.ForeColor = System.Drawing.Color.White;
            this.bookingRoom.Location = new System.Drawing.Point(432, 201);
            this.bookingRoom.Name = "bookingRoom";
            this.bookingRoom.Size = new System.Drawing.Size(232, 93);
            this.bookingRoom.TabIndex = 69;
            this.bookingRoom.Text = "Book A Room";
            this.bookingRoom.UseVisualStyleBackColor = false;
            this.bookingRoom.Click += new System.EventHandler(this.deleting_Click);
            // 
            // gettingInfo
            // 
            this.gettingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(183)))));
            this.gettingInfo.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.gettingInfo.ForeColor = System.Drawing.Color.White;
            this.gettingInfo.Location = new System.Drawing.Point(148, 201);
            this.gettingInfo.Name = "gettingInfo";
            this.gettingInfo.Size = new System.Drawing.Size(232, 93);
            this.gettingInfo.TabIndex = 68;
            this.gettingInfo.Text = "My Information";
            this.gettingInfo.UseVisualStyleBackColor = false;
            this.gettingInfo.Click += new System.EventHandler(this.adding_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(87)))));
            this.label13.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(358, 441);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 34);
            this.label13.TabIndex = 70;
            this.label13.Text = "Назад";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // MainCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookingRoom);
            this.Controls.Add(this.gettingInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bookingRoom;
        private System.Windows.Forms.Button gettingInfo;
        private System.Windows.Forms.Label label13;
    }
}