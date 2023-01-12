namespace formLogin
{
    partial class frm_home
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
            this.btn_attendence = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_loguser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_attendence
            // 
            this.btn_attendence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendence.Location = new System.Drawing.Point(182, 116);
            this.btn_attendence.Name = "btn_attendence";
            this.btn_attendence.Size = new System.Drawing.Size(147, 95);
            this.btn_attendence.TabIndex = 0;
            this.btn_attendence.Text = "Attendence";
            this.btn_attendence.UseVisualStyleBackColor = true;
            // 
            // btn_student
            // 
            this.btn_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.Location = new System.Drawing.Point(331, 116);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(147, 95);
            this.btn_student.TabIndex = 1;
            this.btn_student.Text = "Student";
            this.btn_student.UseVisualStyleBackColor = true;
            // 
            // btn_payment
            // 
            this.btn_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.Location = new System.Drawing.Point(182, 221);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(147, 95);
            this.btn_payment.TabIndex = 0;
            this.btn_payment.Text = "Payment";
            this.btn_payment.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(331, 221);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(147, 95);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add User/Admin";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Location = new System.Drawing.Point(480, 116);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(147, 95);
            this.btn_report.TabIndex = 1;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            // 
            // btn_setting
            // 
            this.btn_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.Location = new System.Drawing.Point(480, 221);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(147, 95);
            this.btn_setting.TabIndex = 1;
            this.btn_setting.Text = "Setting";
            this.btn_setting.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(697, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(91, 33);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_loguser
            // 
            this.lbl_loguser.AutoSize = true;
            this.lbl_loguser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loguser.Location = new System.Drawing.Point(12, 12);
            this.lbl_loguser.Name = "lbl_loguser";
            this.lbl_loguser.Size = new System.Drawing.Size(89, 20);
            this.lbl_loguser.TabIndex = 3;
            this.lbl_loguser.Text = "Welcome: ";
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_loguser);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.btn_attendence);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.Name = "frm_home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_attendence;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_loguser;
    }
}