using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin
{
    public partial class Add_User_Admin : Form
    {
        public Add_User_Admin()
        {
            InitializeComponent();
        }

        private void Add_User_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.appData.tbllog);
            Edit(false);

        }
        private void Edit(bool value)
        {
            txt_username_add.Enabled = value;
            txt_password_add.Enabled = value;
            comboBox1.Enabled = value;
        }

        private void lbl_role_Click(object sender, EventArgs e)
        {

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

       
        
        private void button5_Click(object sender, EventArgs e)
        {
            Edit(false);
            tbllogBindingSource.ResetBindings(false);
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to delete this record?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbllogBindingSource.RemoveCurrent();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tbllogBindingSource.EndEdit();
                tbllogTableAdapter.Update(appData.tbllog);
                dgv_adminuser.Refresh();
                txt_username_add.Focus();
                MessageBox.Show("Your data has been successfuly saved.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_username_add.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.tbllog.AddtbllogRow(appData.tbllog.NewtbllogRow());
                tbllogBindingSource.MoveLast();
                txt_username_add.Focus();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
            
        }
    }
}
