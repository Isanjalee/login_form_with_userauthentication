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
    public partial class frm_home : Form
    {
        public frm_home(string log)
        {
            InitializeComponent();
            lbl_loguser.Text = log;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_User_Admin frm = new Add_User_Admin();
            frm.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login fl = new frm_login();
            fl.Show();
            this.Hide();
        }

        private void frm_home_Load(object sender, EventArgs e)
        {
            if (ulog.type == "A")
            {
                btn_add.Visible=true;
                btn_attendence.Visible=true;    
                btn_payment.Visible=true;   
                btn_report.Visible=true;
                btn_setting.Visible=true;
                btn_student.Visible=true;
            }else if (ulog.type == "U")
            {
                btn_add.Visible = false;
                btn_attendence.Visible = true;
                btn_payment.Visible = false;
                btn_report.Visible = true;
                btn_setting.Visible = false;
                btn_student.Visible = true;
            }
        }
    }
}
