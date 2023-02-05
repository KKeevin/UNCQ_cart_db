using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp練習
{
    public partial class Form_signin : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBconnectionString = "";
        Form actform;
        public Form_signin()
        {
            InitializeComponent();
        }

        private void Form_signin_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; //.就是本機 //@就是不處理特殊符號
            scsb.InitialCatalog = "UNCQ"; //database名稱
            scsb.IntegratedSecurity = true;
            strDBconnectionString = scsb.ToString();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {                
            OpenNewForm(new Form_account(), sender);           
        }

        void OpenNewForm(Form Test, object btnsender)
        {
            panel_signup.Visible = true;
            if (actform != null)
            {
                actform.Close();
            }
            actform = Test;
            Test.TopLevel = false;
            Test.FormBorderStyle = FormBorderStyle.None;
            Test.Dock = DockStyle.Fill;
            panel_signup.Controls.Add(Test);
            Test.BringToFront();
            Test.Show();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            string acc = textBox1.Text;
            string pass = textBox2.Text;
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select [密碼] from account where [帳號] = @account;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@account",acc);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                if(pass == reader["密碼"].ToString())
                {
                    MessageBox.Show("登入成功");
                    GlobalVar.account = acc;
                    aaa();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密碼錯誤");
                }
            }
            else
            {
                MessageBox.Show("帳號錯誤");
            }
        }

        private void panel_signup_Paint(object sender, PaintEventArgs e)
        {

        }


        void aaa()
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select * from account where [帳號] = @status;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@status", GlobalVar.account);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                GlobalVar.status = Convert.ToInt32(reader["身分層級"]);
            }
        }
    }
}
