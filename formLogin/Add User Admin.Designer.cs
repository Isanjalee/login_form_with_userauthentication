namespace formLogin
{
    partial class Add_User_Admin
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
            this.components = new System.ComponentModel.Container();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.txt_username_add = new System.Windows.Forms.TextBox();
            this.tbllogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new formLogin.AppData();
            this.txt_password_add = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_new_add = new System.Windows.Forms.Button();
            this.btn_edit_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete_add = new System.Windows.Forms.Button();
            this.btn_cancel_add = new System.Windows.Forms.Button();
            this.dgv_adminuser = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbllogTableAdapter = new formLogin.AppDataTableAdapters.tbllogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adminuser)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(25, 31);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(116, 25);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "User Name:";
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(25, 78);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(104, 25);
            this.lbl_password.TabIndex = 0;
            this.lbl_password.Text = "Password:";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(25, 124);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(57, 25);
            this.lbl_role.TabIndex = 0;
            this.lbl_role.Text = "Role:";
            this.lbl_role.Click += new System.EventHandler(this.lbl_role_Click);
            // 
            // txt_username_add
            // 
            this.txt_username_add.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "userName", true));
            this.txt_username_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username_add.Location = new System.Drawing.Point(167, 31);
            this.txt_username_add.Name = "txt_username_add";
            this.txt_username_add.Size = new System.Drawing.Size(208, 30);
            this.txt_username_add.TabIndex = 1;
            // 
            // tbllogBindingSource
            // 
            this.tbllogBindingSource.DataMember = "tbllog";
            this.tbllogBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_password_add
            // 
            this.txt_password_add.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "password", true));
            this.txt_password_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password_add.Location = new System.Drawing.Point(167, 78);
            this.txt_password_add.Name = "txt_password_add";
            this.txt_password_add.Size = new System.Drawing.Size(208, 30);
            this.txt_password_add.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tbllogBindingSource, "role", true));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBox1.Location = new System.Drawing.Point(167, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // btn_new_add
            // 
            this.btn_new_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_add.Location = new System.Drawing.Point(30, 174);
            this.btn_new_add.Name = "btn_new_add";
            this.btn_new_add.Size = new System.Drawing.Size(345, 52);
            this.btn_new_add.TabIndex = 3;
            this.btn_new_add.Text = "New";
            this.btn_new_add.UseVisualStyleBackColor = true;
            this.btn_new_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_edit_add
            // 
            this.btn_edit_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_add.Location = new System.Drawing.Point(30, 243);
            this.btn_edit_add.Name = "btn_edit_add";
            this.btn_edit_add.Size = new System.Drawing.Size(345, 52);
            this.btn_edit_add.TabIndex = 3;
            this.btn_edit_add.Text = "Edit";
            this.btn_edit_add.UseVisualStyleBackColor = true;
            this.btn_edit_add.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(30, 312);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(345, 52);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_delete_add
            // 
            this.btn_delete_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_add.Location = new System.Drawing.Point(30, 384);
            this.btn_delete_add.Name = "btn_delete_add";
            this.btn_delete_add.Size = new System.Drawing.Size(345, 52);
            this.btn_delete_add.TabIndex = 3;
            this.btn_delete_add.Text = "Delete";
            this.btn_delete_add.UseVisualStyleBackColor = true;
            this.btn_delete_add.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_cancel_add
            // 
            this.btn_cancel_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_add.Location = new System.Drawing.Point(30, 454);
            this.btn_cancel_add.Name = "btn_cancel_add";
            this.btn_cancel_add.Size = new System.Drawing.Size(345, 52);
            this.btn_cancel_add.TabIndex = 3;
            this.btn_cancel_add.Text = "Cancel";
            this.btn_cancel_add.UseVisualStyleBackColor = true;
            this.btn_cancel_add.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgv_adminuser
            // 
            this.dgv_adminuser.AutoGenerateColumns = false;
            this.dgv_adminuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_adminuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dgv_adminuser.DataSource = this.tbllogBindingSource;
            this.dgv_adminuser.Location = new System.Drawing.Point(397, 31);
            this.dgv_adminuser.Name = "dgv_adminuser";
            this.dgv_adminuser.ReadOnly = true;
            this.dgv_adminuser.RowHeadersWidth = 51;
            this.dgv_adminuser.RowTemplate.Height = 24;
            this.dgv_adminuser.Size = new System.Drawing.Size(425, 475);
            this.dgv_adminuser.TabIndex = 4;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.FillWeight = 150F;
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.FillWeight = 150F;
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.FillWeight = 150F;
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbllogTableAdapter
            // 
            this.tbllogTableAdapter.ClearBeforeFill = true;
            // 
            // Add_User_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 546);
            this.Controls.Add(this.dgv_adminuser);
            this.Controls.Add(this.btn_cancel_add);
            this.Controls.Add(this.btn_delete_add);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit_add);
            this.Controls.Add(this.btn_new_add);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_password_add);
            this.Controls.Add(this.txt_username_add);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(868, 593);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(868, 593);
            this.Name = "Add_User_Admin";
            this.Text = "Add User/Admin";
            this.Load += new System.EventHandler(this.Add_User_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adminuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.TextBox txt_username_add;
        private System.Windows.Forms.TextBox txt_password_add;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_new_add;
        private System.Windows.Forms.Button btn_edit_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete_add;
        private System.Windows.Forms.Button btn_cancel_add;
        private System.Windows.Forms.DataGridView dgv_adminuser;
        private AppData appData;
        private System.Windows.Forms.BindingSource tbllogBindingSource;
        private AppDataTableAdapters.tbllogTableAdapter tbllogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}