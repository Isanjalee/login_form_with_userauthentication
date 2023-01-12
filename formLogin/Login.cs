using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace formLogin
{
    public partial class frm_login : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.uaDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        String log;
        public frm_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbllog WHERE userName = '"+textBox1.Text+"'and password = '"+textBox2.Text+"'",con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;

            if(i == 1)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[3].ToString() == "Admin")
                {
                    ulog.type = "A";
                }else if (dr[3].ToString() == "User")
                {
                    ulog.type = "U";
                }
                log = "Welcome: " + textBox1.Text;
                this.Hide();
                frm_home fh = new frm_home(log);
                fh.Show();
                
            }
            else
            {
                MessageBox.Show("Please check your User Name or Password !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
